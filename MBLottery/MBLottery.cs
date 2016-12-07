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
        private Dictionary<LotteryLevel, bool> _levelsIsLotteried = new Dictionary<LotteryLevel, bool>();
        private string inputPath = System.Windows.Forms.Application.StartupPath;
        private string outputPath = System.Windows.Forms.Application.StartupPath;
        private string logFileName = "MBLottery";

        private bool _flag = false;
        public static int rollingCount = 14;
        private int actualLotteryCount = 0;
        private int targetLotteryCount = 10;
        private LotteryStatus _status = LotteryStatus.NotStarted;
        private LotteryLevel _level = LotteryLevel.ThirdLevel;
        /// <summary>
        /// key is index
        /// value is Employee
        /// </summary>
        private Dictionary<int, Employee> pendingEmployees = new Dictionary<int, Employee>();

        private List<Employee> rewardedEmployees = new List<Employee>();
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
        private bool isCleaned = false;
        private int screenNo = 0;
        private string selectedRewardedIndex = "";
        #endregion



        #region Private Method


        private void _autoSelect()
        {
            if (_IsAuto)
            {
                if (actualLotteryCount >= targetLotteryCount)
                {
                    _levelsIsLotteried[_level] = true;
                    actualLotteryCount = 0;
                    switch (_level)
                    {
                        case LotteryLevel.ThirdLevel:
                            SecondRadioButton_CheckedChanged(null, null);
                            SecondRadioButton.Checked = true;
                            break;
                        case LotteryLevel.SecondLevel:
                            FirstRadioButton_CheckedChanged(null, null);
                            FirstRadioButton.Checked = true;
                            break;
                        case LotteryLevel.FirstLevel:
                            SpecialRadioButton_CheckedChanged(null, null);
                            SpecialRadioButton.Checked = true;
                            break;

                    }

                }
            }
            else
            {
                _level = LotteryLevel.Unknown;
                targetLotteryCount = -1;
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
                    rewardedEmployees.Add(item.Value);
                    pendingEmployees.Remove(item.Key);
                }
                tempDic.Clear();
            }
        }
        private void _congratulateToSpecialAwarded()
        {
            var queryResults = from item in rewardedEmployees
                               where item.Level == LotteryLevel.SpecialLevel
                               select item;
            foreach (var temp in queryResults)
            {
                string info = "恭喜" + temp.Id + "获得特等奖！";
                InfoLabel.Text = info;
                break;
            }
        }
        private void _showAwardedEmployee()
        {
            try
            {
                rewardedEmployees.Add(currentRewardedEmployee);
                RewardedEmployeesListBox.Items.Clear();
                int i = rewardedEmployees.Count;
                for (; i > 0; i--)
                {
                    Employee temp = rewardedEmployees[i - 1];
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

        private void _showAwardedEmployees()
        {
            try
            {
                RewardedEmployeesListBox.Items.Clear();
                foreach (var curEmployee in rewardedEmployees)
                {
                    RewardedEmployeesListBox.Items.Add(curEmployee.Id + " 获得 " + getTransLevel(curEmployee.Level));
                    string xPath = "//Employee[@id='" + curEmployee.Id + "']";
                    XmlElement theElement = (XmlElement)employeesDoc.SelectSingleNode(xPath);
                    theElement.SetAttribute("lotteryLevel", Enum.GetName(typeof(LotteryLevel), curEmployee.Level));
                    theElement.InnerText = "";
                }
                PendingEmployeesListBox.Items.Clear();
                employeesDoc.Save(outputPath + "\\Employee.XML");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                _logHandler.logging(ex.Message);
            }


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
        /// <summary>
        /// check level and count is setted 
        /// </summary>
        /// <returns></returns>
        private bool _checkPara()
        {
            bool isOK = false;
            if (_level != LotteryLevel.Unknown && targetLotteryCount > 0)
            {
                isOK = true;
            }
            return isOK;
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
            _levelsIsLotteried.Add(LotteryLevel.SpecialLevel, false);
            _levelsIsLotteried.Add(LotteryLevel.FirstLevel, false);
            _levelsIsLotteried.Add(LotteryLevel.SecondLevel, false);
            _levelsIsLotteried.Add(LotteryLevel.ThirdLevel, false);
            _levelsIsLotteried.Add(LotteryLevel.AdditionalLevel, false);
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
            isCleaned = true;
        }
        #endregion



        #region Event Handler
        private void LotteryButton_Click(object sender, EventArgs e)
        {
            if (!isCleaned)
            {
                cleanData();
            }
            if (!_checkPara())
            {
                MessageBox.Show("Please set award level and count.", "Setting");
                return;
            }
            if (_flag)
            {
                //user clicked "stop" button
                //now should deal with rewarded employees
                _flag = false;
                LotteryButton.Text = "Start";
                _status = LotteryStatus.Stopped;

                //StatusLabel.Font.

                _getAwardedEmployee();
                //_showAwardedEmployees();
                timer1.Enabled = false;

                TotalEmployeesLabel.Text = pendingEmployees.Count.ToString();
                InfoLabel.Text = "已完成" + getTransLevel(_level) + "抽奖";
                _autoSelect();
                if (_level == LotteryLevel.SpecialLevel)
                {
                    _congratulateToSpecialAwarded();
                }
                GiveUpButton.Enabled = true;
            }
            else
            {
                //user clicked "Start" button
                //now is searching pending employees in the timer
                if (targetLotteryCount > pendingEmployees.Count)
                {
                    MessageBox.Show("Selected count should not bigger than total employees");
                    return;
                }
                if (_levelsIsLotteried[_level])
                {
                    MessageBox.Show(getTransLevel(_level) + "已经完成，请选择其他抽奖级别。");
                    return;
                }
                if (_status == LotteryStatus.Stopped)
                {
                    _updatePendingEmp();
                }
                GiveUpButton.Enabled = false;
                _flag = true;
                PendingEmployeesListBox.Items.Clear();
                //RewardedEmployeesListBox.Items.Clear();
                LotteryButton.Text = "Stop";
                _status = LotteryStatus.Started;
                InfoLabel.Text = "现在进行" + getTransLevel(_level) + "抽奖";
                actualLotteryCount++;
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
            targetLotteryCount = int.Parse(SpecialRewardCountNum.Value.ToString());
            _logHandler.logging("Special rewarded target count: " + targetLotteryCount);
        }
        private void FirstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.FirstLevel;
            targetLotteryCount = int.Parse(FirstRewardCountNum.Value.ToString());
            _logHandler.logging("First rewarded target count: " + targetLotteryCount);
        }
        private void SecondRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.SecondLevel;
            targetLotteryCount = int.Parse(SecondRewardCountNum.Value.ToString());
            _logHandler.logging("Second rewarded target count: " + targetLotteryCount);
        }

        private void ThirdRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _level = LotteryLevel.ThirdLevel;
            targetLotteryCount = int.Parse(ThirdRewardCountNum.Value.ToString());
            _logHandler.logging("Third rewarded target count: " + targetLotteryCount);
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

            _IsAuto = AutoSelectLevelCheckBox.Checked;
            _initializeLevelDic();

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
            _loadEmployees();
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
            actualLotteryCount--;
            if (_levelsIsLotteried[_level] == true)
            {
                _levelsIsLotteried[_level] = false;
            }
            rewardedEmployees.Remove(currentRewardedEmployee);
            pendingEmployees.Add(currentRewardedIndex, currentRewardedEmployee);
            RewardedEmployeesListBox.Items.Clear();
            int i = rewardedEmployees.Count;
            for (; i > 0; i--)
            {
                Employee temp = rewardedEmployees[i - 1];
                RewardedEmployeesListBox.Items.Add(temp.Id + " 获得 " + getTransLevel(temp.Level));
            }
            //remove the rewarded employee from file
            string resultFilePath = System.Windows.Forms.Application.StartupPath + "\\result.txt";
            if (File.Exists(resultFilePath))
            {
                string encryptedString = File.ReadAllText(resultFilePath);
                string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                string[] employeeList = decrytedString.Split('\n');
                for (i = 0; i < employeeList.Length; i++)
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
            curItem = curItem.Trim();
            if (!string.IsNullOrEmpty(curItem))
            {
                BackToPoolButton.Enabled = true;
                string[] rewardedInfo = curItem.Split(' ');
                selectedRewardedIndex = rewardedInfo[0];
                var queryResults = from item in rewardedEmployees
                                   where item.Id == selectedRewardedIndex
                                   select item;
                foreach (var item in queryResults)
                {
                    if (item != null)
                    {
                        currentRewardedEmployee = (Employee)item;
                        currentRewardedIndex = 999999;

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
            }

        }

        private void BackToPoolButton_Click(object sender, EventArgs e)
        {

            GiveUpButton_Click(null, null);
            BackToPoolButton.Enabled = false;
        }

        #endregion
    }
}