using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Linq;
using System.Xml;
using BusinessObjects;
using System.IO;

using System.Threading;

namespace MBLottery
{
    enum LotteryStatus
    {
        NotStarted = 0,
        Started = 1,
        Stopped = 2
    }

    public partial class MBLottery : Form
    {
        public MBLottery()
        {
            InitializeComponent();
            //this.skinEngine1.SkinFile = Application.StartupPath + "//Skins//DiamondRed.ssk";  
        }
        #region Field
        private string inputPath = System.Windows.Forms.Application.StartupPath;
        private string outputPath = System.Windows.Forms.Application.StartupPath;
        private string logFileName = "MBLottery";

        public static int rollingCount = 14;
        private Dictionary<LotteryLevel, int> acutualLotteryCountDic = new Dictionary<LotteryLevel, int>();
        private Dictionary<LotteryLevel, int> targetLotteryCountDic = new Dictionary<LotteryLevel, int>();
      
        private LotteryStatus _status = LotteryStatus.NotStarted;
        private LotteryLevel _level = LotteryLevel.ThirdLevel;
        /// <summary>
        /// key is index
        /// value is Employee
        /// </summary>
        private Dictionary<int, Employee> pendingEmployees = new Dictionary<int, Employee>();

        private Dictionary<string, Employee> rewardedEmployees = new Dictionary<string, Employee>();
        private Employee currentRewardedEmployee = null;
        private int currentRewardedIndex = -1;

        private XmlDocument employeesDoc;
        private string employeesFilePath = "";
        private string resultFilePath = "";
        public static LogHandler _logHandler;
        private bool _debugMode = true;
        private List<int> indexList = new List<int>();
        private bool _IsAuto;
        private AutoSizeFormClass asc = new AutoSizeFormClass();
        private int screenNo = 0;
        private int giveUpIndex = 9999;
        System.Media.SoundPlayer lotteryPlayer;
       
        #endregion



        #region Private Method

        private void backgroundLotteryingAudioHandler(bool isPlay,bool isLottery =false, bool isSpecial=false)
        {
            if (isPlay)
            {
                if (isLottery)
                {
                    lotteryPlayer.SoundLocation = inputPath + "\\Musics\\lotterying.wav";
                    lotteryPlayer.PlayLooping();
                }
                else
                {
                    if (isSpecial)
                    {
                        lotteryPlayer.SoundLocation = inputPath + "\\Musics\\specialCongratulation.wav";

                    }
                    else
                    {
                        lotteryPlayer.SoundLocation = inputPath + "\\Musics\\congratulation.wav";
                    }
                    lotteryPlayer.Play();
                }  
            }
            else
            {
                lotteryPlayer.Stop();
            }
            
        }

        

        private int getRemainCount(LotteryLevel theLevel)
        {
            int remainCount = 0;
            int actualLotteryCount = acutualLotteryCountDic[theLevel];
            int targetLotteryCount = targetLotteryCountDic[theLevel];
            remainCount = targetLotteryCount - actualLotteryCount;
            if (remainCount < 0)
            {
                remainCount = 0;
            }
            return remainCount;
        }
        private bool _autoSelect()
        {
            bool isOK = false;
            foreach (LotteryLevel type in Enum.GetValues(typeof(LotteryLevel)))
            {
                if (type == LotteryLevel.Unknown)
                {
                    break;
                }
                // TODO: 遍历操作  
                if (getRemainCount(type) > 0)
                {
                    isOK = true;
                    _level = type;
                    changeRadio(type);
                    break;
                }
            } 
            return isOK;
        }
        private void changeRadio(LotteryLevel type)
        {
            switch (type)
            {
                case LotteryLevel.SpecialLevel:
                    SpecialRadioButton.Checked = true;
                    break;
                case LotteryLevel.FirstLevel:
                    FirstRadioButton.Checked = true;
                    break;
                case LotteryLevel.SecondLevel:
                    SecondRadioButton.Checked = true;
                    break;
                case LotteryLevel.ThirdLevel:
                    ThirdRadioButton.Checked = true;
                    break;
                case LotteryLevel.AdditionalLevel:
                    AdditionalRadioButton.Checked = true;
                    break;
            }
        }
        private void _getAwardedEmployee()
        {
            currentRewardedEmployee = null;
            _rollingPendingList();
            _rollingPendingList();
            if (currentRewardedEmployee != null)
            {
                currentRewardedEmployee.Level = _level;
                pendingEmployees.Remove(currentRewardedIndex);
                rewardedEmployees.Add(currentRewardedEmployee.Id, currentRewardedEmployee);
                acutualLotteryCountDic[_level] = acutualLotteryCountDic[_level] + 1;
                _showAwardedEmployee();
                _saveResult();
            }
        }
        private void _getAwardedEmployees()
        {
            _rollingPendingList();
            foreach (string id in PendingEmployeesListBox.Items)
            {
                var queryResults = from item in pendingEmployees
                                   where item.Value.Id == id
                                   select item;
                Dictionary<int, Employee> tempDic = new Dictionary<int, Employee>();
                foreach (var temp in queryResults)
                {
                    tempDic.Add(temp.Key, temp.Value);

                }
                foreach (var item in tempDic)
                {
                    item.Value.Level = _level;
                    rewardedEmployees.Add(item.Value.Id, item.Value);
                    pendingEmployees.Remove(item.Key);
                }
                tempDic.Clear();
            }
        }

        private void _showAwardedEmployee()
        {
            try
            {
                RewardedEmployeesListBox.Items.Clear();
                List<Employee> tempList = new List<Employee>();
                foreach (Employee temp in rewardedEmployees.Values)
                {
                    tempList.Add(temp);
                }
                int i = tempList.Count;
                for (; i > 0; i--)
                {
                    Employee temp = tempList[i - 1];
                    RewardedEmployeesListBox.Items.Add(temp.Id + " 获得 " + getTransLevel(temp.Level));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                _logHandler.logging(ex.Message);
            }


        }

        private void _saveResult()
        {

            string plainText = "";
            string encrytedText;
            if (currentRewardedEmployee != null)
            {
                plainText = currentRewardedEmployee.Id + "," + Enum.GetName(typeof(LotteryLevel), currentRewardedEmployee.Level) + Environment.NewLine;
                _logHandler.logging("rewarded: " + plainText);
                if (!File.Exists(resultFilePath))
                {
                    encrytedText = EncryptDecryptFile.Encrypt(plainText);
                    writeToFile(resultFilePath, encrytedText);
                }
                else
                {
                    string encryptedString = File.ReadAllText(resultFilePath);
                    string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                    decrytedString = decrytedString + plainText;
                    encrytedText = EncryptDecryptFile.Encrypt(decrytedString);
                    writeToFile(resultFilePath, encrytedText);
                }
            }
            else
            {
                _logHandler.logging("currentRewardedEmployee is empty.");
            }
        }
        public static void writeToFile(string filePath, string text)
        {
            StreamWriter sw = new StreamWriter(filePath, false, Encoding.Unicode);
            sw.Write(text);
            sw.Flush();
            sw.Close();
        }

        private string getTransLevel(LotteryLevel theLevel)
        {


            string translatedLevel = "";
            switch (theLevel)
            {
                case LotteryLevel.SpecialLevel:
                    translatedLevel = "特等奖";
                    break;
                case LotteryLevel.FirstLevel:
                    translatedLevel = "一等奖";
                    break;
                case LotteryLevel.SecondLevel:
                    translatedLevel = "二等奖";
                    break;
                case LotteryLevel.ThirdLevel:
                    translatedLevel = "三等奖";
                    break;
                case LotteryLevel.AdditionalLevel:
                    translatedLevel = "安慰奖";
                    break;
            }
            return translatedLevel;

        }
        /// <summary>
        /// get random index for employees
        /// </summary>
        private void _rollingPendingList()
        {
            //int index = -1;
            Employee curEmployee = null;

            try
            {
                int count = pendingEmployees.Values.Count;
                indexList = RandomExt.getRandomNumberList(rollingCount, count);
                PendingEmployeesListBox.Items.Clear();
                _logHandler.logging("Start-------------------");
                foreach (int index in indexList)
                {

                    _logHandler.logging("Index: " + index);
                    if (pendingEmployees.ContainsKey(index))
                    {
                        curEmployee = pendingEmployees[index];
                        if (curEmployee != null && !PendingEmployeesListBox.Items.Contains(curEmployee.Id))
                        {
                            PendingEmployeesListBox.Items.Add(curEmployee.Id);
                            _logHandler.logging("added index: " + index);

                        }
                    }
                }
                currentRewardedIndex = indexList[0];
                currentRewardedEmployee = pendingEmployees[currentRewardedIndex];
                string employeeImagePath = inputPath + "\\Images\\Employees\\" + currentRewardedEmployee.Id + ".jpg";
                if (File.Exists(employeeImagePath))
                {
                    AwardedEmployeePicBox.Image = Image.FromFile(employeeImagePath);
                }
                else
                {
                    AwardedEmployeePicBox.Image = Image.FromFile(inputPath + "\\Images\\Employees\\MB.jpg");
                }
                _logHandler.logging("End-------------------");

            }
            catch (Exception ex)
            {
                _logHandler.logging(ex.Message);
            }


        }

        /// <summary>
        /// after previous lottery, the index of employees should be reassgined.
        /// </summary>
        private void _updatePendingEmp()
        {
            int index = 0;
            List<Employee> tempList = new List<Employee>();
            foreach (Employee curE in pendingEmployees.Values)
            {
                tempList.Add(curE);
            }
            pendingEmployees.Clear();
            foreach (var item in tempList)
            {
                pendingEmployees.Add(index, item);
                index++;
            }

        }
        private bool _iDIsExisted(string ID)
        {
            bool isExisted = false;
            var queryResults = from item in pendingEmployees.Values
                               where item.Id == ID
                               select item;
            foreach (var item in queryResults)
            {
                isExisted = true;
                break;
            }
            return isExisted;
        }
        /// <summary>
        /// read employees file into application
        /// </summary>
        private void _loadEmployees()
        {
            string id = "";
            string name = "";
            string translatedName = "";
            int index = 0;

            try
            {
                employeesDoc = new XmlDocument();
                employeesDoc.Load(employeesFilePath);
                XmlReaderSettings settings = new XmlReaderSettings();

                settings.IgnoreComments = true;//ignore the comment

                //get target root
                XmlElement targetRootElem = employeesDoc.DocumentElement;

                XmlNodeList targetTextNodes;

                targetTextNodes = targetRootElem.GetElementsByTagName("Employee");
                foreach (XmlNode node in targetTextNodes)
                {
                    XmlElement targetElement = (XmlElement)node;
                    id = targetElement.GetAttribute("id");   //get the value of attribute "id"  
                    name = targetElement.GetAttribute("name");   //get the value of attribute "name"  
                    translatedName = targetElement.InnerText;
                    if (!_iDIsExisted(id))
                    {
                        //Employee newEmployee = new Employee();
                        //newEmployee.Id = id;
                        //newEmployee.Name = name;
                        //newEmployee.TranslatedName = translatedName;

                        if (rewardedEmployees.ContainsKey(id))
                        {
                            rewardedEmployees[id].Name = name;
                            rewardedEmployees[id].TranslatedName = translatedName;
                        }
                        else
                        {
                            Employee newEmployee = new Employee();
                            newEmployee.Id = id;
                            newEmployee.Name = name;
                            newEmployee.TranslatedName = translatedName;
                            if (!pendingEmployees.ContainsKey(index))
                            {
                                pendingEmployees.Add(index, newEmployee);
                                index++;
                            }
                        }
                    }
                    else
                    {
                        _logHandler.logging("duplicated ID: " + id + " name: " + name);
                    }

                }
                TotalEmployeesLabel.Text = pendingEmployees.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _loadRewardedEmployees()
        {
            int actualSpecialCount = 0;
            int actualFirstCount = 0;
            int actualSecondCount = 0;
            int actualThirdCount = 0;
            if (File.Exists(resultFilePath))
            {
                string encryptedString = File.ReadAllText(resultFilePath);
                string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                string[] employeeList = decrytedString.Split('\n');
                for (int i = 0; i < employeeList.Length; i++)
                {
                    string item = employeeList[i];
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] info = item.Split(',');
                        Employee curEmployee = new Employee();
                        curEmployee.Id = info[0];
                        curEmployee.Level = (LotteryLevel)(Enum.Parse(typeof(LotteryLevel), info[1]));
                        if (curEmployee.Level == LotteryLevel.SpecialLevel)
                        {
                            actualSpecialCount++;
                        }
                        else if (curEmployee.Level == LotteryLevel.FirstLevel)
                        {
                            actualFirstCount++;
                        }
                        else if (curEmployee.Level == LotteryLevel.SecondLevel)
                        {
                            actualSecondCount++;
                        }
                        else if (curEmployee.Level == LotteryLevel.ThirdLevel)
                        {
                            actualThirdCount++;
                        }
                        rewardedEmployees.Add(curEmployee.Id, curEmployee);
                    }
                }
               

            }
            acutualLotteryCountDic[LotteryLevel.SpecialLevel] = actualSpecialCount;
            acutualLotteryCountDic[LotteryLevel.FirstLevel] = actualFirstCount;
            acutualLotteryCountDic[LotteryLevel.SecondLevel] = actualSecondCount;
            acutualLotteryCountDic[LotteryLevel.ThirdLevel] = actualThirdCount;
        }


        private void _showOpenFileBtn()
        {
            if (!string.IsNullOrEmpty(employeesFilePath))
            {
                OpenFileButton.Visible = false;
            }
            else
            {
                OpenFileButton.Visible = true;
            }
        }

        private System.Windows.Forms.DialogResult _openFile()
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.DialogResult.Cancel;
            if (OpenEmployeesFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                employeesFilePath = OpenEmployeesFileDialog.FileName.ToString();
                result = System.Windows.Forms.DialogResult.OK;
            }
            return result;
        }
        /// <summary>
        /// set the output path depending on the choice whether using default path
        /// </summary>
        private void setOutputPath()
        {
            string basePath = System.Windows.Forms.Application.StartupPath;
            outputPath = basePath + "\\" + "Output";
            if (!Directory.Exists(outputPath))//if not exists, create one
            {
                Directory.CreateDirectory(outputPath);
            }
        }



        private void _initializeLevelDic()
        {

            int targetSpecialCount = (int)SpecialRewardCountNum.Value;
            int targetFirstCount = (int)FirstRewardCountNum.Value;
            int targetSecondCount = (int)SecondRewardCountNum.Value;
            int targetThirdCount = (int)ThirdRewardCountNum.Value;

            int actualSpecialCount = (from item in rewardedEmployees where item.Value.Level == LotteryLevel.SpecialLevel select item).Count();
            int actualFirstCount = (from item in rewardedEmployees where item.Value.Level == LotteryLevel.FirstLevel select item).Count();
            int actualSecondCount = (from item in rewardedEmployees where item.Value.Level == LotteryLevel.SecondLevel select item).Count();
            int actualThirdCount = (from item in rewardedEmployees where item.Value.Level == LotteryLevel.ThirdLevel select item).Count();

            targetLotteryCountDic.Add(LotteryLevel.SpecialLevel, targetSpecialCount);
            targetLotteryCountDic.Add(LotteryLevel.FirstLevel, targetFirstCount);
            targetLotteryCountDic.Add(LotteryLevel.SecondLevel, targetSecondCount);
            targetLotteryCountDic.Add(LotteryLevel.ThirdLevel, targetThirdCount);
            targetLotteryCountDic.Add(LotteryLevel.AdditionalLevel, 0);

            acutualLotteryCountDic.Add(LotteryLevel.SpecialLevel, actualSpecialCount);
            acutualLotteryCountDic.Add(LotteryLevel.FirstLevel, actualFirstCount);
            acutualLotteryCountDic.Add(LotteryLevel.SecondLevel, actualSecondCount);
            acutualLotteryCountDic.Add(LotteryLevel.ThirdLevel, actualThirdCount);
            acutualLotteryCountDic.Add(LotteryLevel.AdditionalLevel, 0);
        }

        private void _maximizeForm(int screenNo = 0)
        {
            int iActualTop = 0;
            int iActualLeft = 0;
            int iActulaWidth = 0;
            int iActulaHeight = 0;
            if (screenNo != 0 && Screen.AllScreens.Length - 1 >= screenNo)
            {

                this.Location = new Point(Screen.AllScreens[screenNo].Bounds.Left, Screen.AllScreens[screenNo].Bounds.Top);

                iActualTop = Screen.AllScreens[screenNo].Bounds.Top;
                iActualLeft = Screen.AllScreens[screenNo].Bounds.Width;
                iActulaWidth = Screen.AllScreens[screenNo].Bounds.Width;
                iActulaHeight = Screen.AllScreens[screenNo].Bounds.Height;
            }
            else
            {
                this.Location = new Point(0, 0);
                iActulaWidth = Screen.PrimaryScreen.Bounds.Width;

                iActulaHeight = Screen.PrimaryScreen.Bounds.Height;
            }


            //asc.controllInitializeSize(this);

            this.Size = new Size(iActulaWidth, iActulaHeight);

            asc.controlAutoSize(this, iActualTop, iActualLeft, iActulaWidth, iActulaHeight);
        }

        private void cleanData()
        {
            if (File.Exists(resultFilePath))
            {
                File.Delete(resultFilePath);
            }
            rewardedEmployees.Clear();
            RewardedEmployeesListBox.Items.Clear();
            acutualLotteryCountDic[LotteryLevel.SpecialLevel] = 0;
            acutualLotteryCountDic[LotteryLevel.FirstLevel] = 0;
            acutualLotteryCountDic[LotteryLevel.SecondLevel] = 0;
            acutualLotteryCountDic[LotteryLevel.ThirdLevel] = 0;
            AwardedEmployeePicBox.Visible = false;
            PendingEmployeesListBox.Items.Clear();
        }
        #endregion



        #region Event Handler
        private void LotteryButton_Click(object sender, EventArgs e)
        {

            backgroundLotteryingAudioHandler(false);
           
            if (_status == LotteryStatus.Started)
            {
                //user clicked "stop" button
                //now should deal with rewarded employees
                LotteryButton.Text = "Start";
                _status = LotteryStatus.Stopped;

                //StatusLabel.Font.
               
                
                _getAwardedEmployee();
                //_showAwardedEmployees();
                timer1.Enabled = false;

                TotalEmployeesLabel.Text = pendingEmployees.Count.ToString();
                InfoLabel.Text = "恭喜: " + currentRewardedEmployee.Id + ","  + currentRewardedEmployee.Name + "获得" + getTransLevel(_level) + ",剩余" + getRemainCount(_level) + "个";
                InfoENLabel.Text = "Congratulation: " + currentRewardedEmployee.Id + "," + currentRewardedEmployee.Name + " get " + Enum.GetName(typeof(LotteryLevel), _level) +  "reward. Remaining " + getRemainCount(_level);
                //_autoSelect();
                if (_level == LotteryLevel.SpecialLevel)
                {
                    backgroundLotteryingAudioHandler(true,false,true);
                }
                else
                {
                    backgroundLotteryingAudioHandler(true, false, false);
                }
                GiveUpButton.Enabled = true;
            }
            else if (_status == LotteryStatus.Stopped || _status == LotteryStatus.NotStarted)
            {
               
                //user clicked "Start" button
                //now is searching pending employees in the timer
                if (!_autoSelect())
                {
                    //MessageBox.Show("本年度抽奖已经完成，祝大家吃好喝好玩好！！！");
                    End theEnd = new End();
                    
                    theEnd.ShowDialog();
                    return;
                }
                backgroundLotteryingAudioHandler(true, true);
                _updatePendingEmp();
                GiveUpButton.Enabled = false;
                //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

                //wplayer.URL = "My MP3 file.mp3";
                //wplayer.Controls.Play();


                PendingEmployeesListBox.Items.Clear();
                LotteryButton.Text = "Stop";
                _status = LotteryStatus.Started;
                InfoLabel.Text = "现在进行" + getTransLevel(_level) + "抽奖";
                InfoENLabel.Text = "Now getting " + Enum.GetName(typeof(LotteryLevel), _level) + " lottery";
                timer1.Enabled = true;

                AwardedEmployeePicBox.Visible = true;
            }

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            _rollingPendingList();
        }


        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            _openFile();
            _showOpenFileBtn();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SpecialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.SpecialLevel;

        }
        private void FirstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.FirstLevel;
          
        }
        private void SecondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.SecondLevel;
           
        }

        private void ThirdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.ThirdLevel;
        }
        private void AutoSelectLevelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _IsAuto = AutoSelectLevelCheckBox.Checked;
        }

        private void MBLottery_Load(object sender, EventArgs e)
        {

            _maximizeForm();
            PendingEmployeesListBox.Items.Clear();
            RewardedEmployeesListBox.Items.Clear();
            acutualLotteryCountDic.Clear();
            targetLotteryCountDic.Clear();
            _IsAuto = AutoSelectLevelCheckBox.Checked;
            _initializeLevelDic();
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            try
            {
                lotteryPlayer = new System.Media.SoundPlayer();
                lotteryPlayer.SoundLocation = inputPath + "\\lotterying.wav";
            }
            catch (System.Exception ex)
            {
                _logHandler.logging(ex.Message);
            }
            //player.SoundLocation = "Sound.wav";
            //player.Play();
            //setOutputPath();
            _logHandler = new LogHandler(outputPath, logFileName);
            if (_debugMode)
            {
                employeesFilePath = outputPath + "\\Employee.XML";
                resultFilePath = outputPath + "\\result.txt";
            }
            else
            {
                if (!(_openFile() == System.Windows.Forms.DialogResult.OK))
                {
                    return;
                }
            }
            _loadRewardedEmployees();
            _loadEmployees();
            _showAwardedEmployee();
            _showOpenFileBtn();
            this.Show();

        }
        private void SetScreenButton_Click(object sender, EventArgs e)
        {
            if (screenNo == 0)
            {
                screenNo = 1;

            }
            else
            {
                screenNo = 0;
            }
            _maximizeForm(screenNo);
            // Screen CurrentScreen = Screen.FromPoint(new Point(Cursor.Position.X, Cursor.Position.Y));
            //MessageBox.Show("Left: " +CurrentScreen.Bounds.Left + ", Top: "+ CurrentScreen.Bounds.Top);

        }

        private void GiveUpButton_Click(object sender, EventArgs e)
        {
            string newPlainText = "";
            rewardedEmployees.Remove(currentRewardedEmployee.Id);
            pendingEmployees.Add(currentRewardedIndex, currentRewardedEmployee);
            //update from count dictionary
            acutualLotteryCountDic[currentRewardedEmployee.Level] = acutualLotteryCountDic[currentRewardedEmployee.Level] - 1;
            _showAwardedEmployee();
            //remove the rewarded employee from file
            string resultFilePath = System.Windows.Forms.Application.StartupPath + "\\result.txt";
            if (File.Exists(resultFilePath))
            {
                string encryptedString = File.ReadAllText(resultFilePath);
                string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                string[] employeeList = decrytedString.Split('\n');
                for (int i = 0; i < employeeList.Length; i++)
                {
                    string item = employeeList[i];
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] info = item.Split(',');
                        if (info[0] == currentRewardedEmployee.Id)
                        {

                        }
                        else
                        {
                            newPlainText += item.Substring(0, item.Length - 1) + Environment.NewLine;
                        }
                    }
                }
                string encrytedText = EncryptDecryptFile.Encrypt(newPlainText);
                writeToFile(resultFilePath, encrytedText);
                AwardedEmployeePicBox.Visible = false;
            }

        }

        private void ShowRewardedListButton_Click(object sender, EventArgs e)
        {
            ShowRewardedEmployees newFrm = new ShowRewardedEmployees();
            newFrm.ShowDialog();
        }

        private void RewardedEmployeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = RewardedEmployeesListBox.SelectedItem.ToString();
            string selectedRewardedIndex = "";
            curItem = curItem.Trim();
            if (!string.IsNullOrEmpty(curItem))
            {
                BackToPoolButton.Enabled = true;
                string[] rewardedInfo = curItem.Split(' ');
                selectedRewardedIndex = rewardedInfo[0];
                var queryResults = from item in rewardedEmployees
                                   where item.Value.Id == selectedRewardedIndex
                                   select item;
                foreach (var item in queryResults)
                {
                    if (item.Value != null)
                    {
                        currentRewardedEmployee = item.Value;
                        currentRewardedIndex = giveUpIndex;
                        giveUpIndex++;
                    }
                }

                string employeeImagePath = inputPath + "\\Images\\Employees\\" + currentRewardedEmployee.Id + ".jpg";
                if (File.Exists(employeeImagePath))
                {
                    AwardedEmployeePicBox.Image = Image.FromFile(employeeImagePath);
                }
                else
                {
                    AwardedEmployeePicBox.Image = Image.FromFile(inputPath + "\\Images\\Employees\\MB.jpg");
                }
                AwardedEmployeePicBox.Visible = true;
            }

        }

        private void BackToPoolButton_Click(object sender, EventArgs e)
        {

            GiveUpButton_Click(null, null);
            BackToPoolButton.Enabled = false;
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要删除抽奖记录吗", "复位", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cleanData();
            }
        }

        private void SpecialRewardCountNum_ValueChanged(object sender, EventArgs e)
        {
            int targetSpecialCount = (int)SpecialRewardCountNum.Value;
            targetLotteryCountDic[LotteryLevel.SpecialLevel] = targetSpecialCount;
        }

        private void FirstRewardCountNum_ValueChanged(object sender, EventArgs e)
        {
            int targetFirstCount = (int)FirstRewardCountNum.Value;
            targetLotteryCountDic[LotteryLevel.FirstLevel] = targetFirstCount;
        }

        private void SecondRewardCountNum_ValueChanged(object sender, EventArgs e)
        {
            int targetSecondCount = (int)SecondRewardCountNum.Value;
            targetLotteryCountDic[LotteryLevel.SecondLevel] = targetSecondCount;
        }

        private void ThirdRewardCountNum_ValueChanged(object sender, EventArgs e)
        {
            int targetThirdCount = (int)ThirdRewardCountNum.Value;
            targetLotteryCountDic[LotteryLevel.ThirdLevel] = targetThirdCount;
        }
        private void AdditionalRewardCountNum_ValueChanged(object sender, EventArgs e)
        {
            int targetAdditionalCount = (int)AdditionalRewardCountNum.Value;
            targetLotteryCountDic[LotteryLevel.AdditionalLevel] = targetAdditionalCount;
        }
        #endregion

        private void BossPowerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BossPowerCheckBox.Checked == true)
            {
                AdditionalRadioButton.Visible = true;
                AdditionalRewardCountNum.Visible = true;
            } 
            else
            {
                AdditionalRadioButton.Visible = false;
                AdditionalRewardCountNum.Visible = false;
            }
            
        }

       

       
    }
}