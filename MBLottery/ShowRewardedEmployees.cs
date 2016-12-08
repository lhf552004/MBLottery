using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BusinessObjects;
using System.Xml;

namespace MBLottery
{
    public partial class ShowRewardedEmployees : Form
    {
        public ShowRewardedEmployees()
        {
            InitializeComponent();
        }
        /// <summary>
        /// it loads employees' id who give up reward
        /// </summary>
        private List<string> giveUpIdList = new List<string>();
        /// <summary>
        /// key is index, which is used to sort employee
        /// </summary>
        private Dictionary<int, Employee> pendingEmployees = new Dictionary<int, Employee>();
        /// <summary>
        /// key is id
        /// </summary>
        private Dictionary<string, Employee> rewardedEmployees = new Dictionary<string, Employee>();
        private List<int> indexList = new List<int>();
        private List<ListViewItem> giveUpItemList = new List<ListViewItem>();
        private string resultFilePath;
        private LotteryStatus _status = LotteryStatus.NotStarted;
        private Employee currentRewardedEmployee = null;
        private int currentRewardedIndex = -1;
        private string inputPath = System.Windows.Forms.Application.StartupPath;
        private LotteryLevel _level;
        private string _curRemovedId = "";
        private void ShowRewardedEmployees_Load(object sender, EventArgs e)
        {
            resultFilePath = System.Windows.Forms.Application.StartupPath + "\\result.txt";
            rewardedEmployees.Clear();
            giveUpIdList.Clear();
            giveUpItemList.Clear();
            loadRewardedEmployees();
            _loadEmployees();
        }
        private void loadRewardedEmployees()
        {
            if (File.Exists(resultFilePath))
            {
                string encryptedString = File.ReadAllText(resultFilePath);
                string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                string[] employeeList = decrytedString.Split('\n');
                RewardedEmployeesList.Items.Clear();
                for (int i = 0; i < employeeList.Length; i++)
                {
                    string item = employeeList[i];
                    if (!string.IsNullOrEmpty(item))
                    {
                        string[] info = item.Split(',');
                        Employee curEmployee = new Employee();
                        curEmployee.Id = info[0];
                        curEmployee.Level = (LotteryLevel)(Enum.Parse(typeof(LotteryLevel), info[1]));
                        rewardedEmployees.Add(curEmployee.Id, curEmployee);
                        RewardedEmployeesList.Items.Add(info[0]);
                        RewardedEmployeesList.Items[i].SubItems.Add(info[1]);
                    }
                }
            }
        }
        private void _loadEmployees()
        {
            string id = "";
            string name = "";
            string translatedName = "";
            int index = 0;
            string employeesFilePath = System.Windows.Forms.Application.StartupPath + "\\Employee.XML";
            try
            {
                XmlDocument employeesDoc = new XmlDocument();
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
                        MBLottery._logHandler.logging("duplicated ID: " + id + " name: " + name);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void RewardedEmployeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (ListViewItem item in RewardedEmployeesList.SelectedItems)
            {
                string id = item.Text;
                string level = item.SubItems[1].Text;
                if (!giveUpIdList.Contains(id))
                {
                    giveUpIdList.Add(id);
                    giveUpItemList.Add(item);
                }
               
            }
            if (giveUpIdList.Count > 0)
            {
                BackToPoolButton.Enabled = true;
            }
            else
            {
                BackToPoolButton.Enabled = false;
            }

        }

        private void BackToPoolButton_Click(object sender, EventArgs e)
        {
            foreach (string id in giveUpIdList)
            {
                removeRewardedEmployees(id);
            }
            foreach (var item in giveUpItemList)
            {
                RewardedEmployeesList.Items.Remove(item);

            }
            giveUpItemList.Clear();
            ReLotteryButton.Enabled = true;
            BackToPoolButton.Enabled = false;

        }

        private void removeRewardedEmployees(string id)
        {
            string newRewaredEmployeesStr = "";
            if (!string.IsNullOrEmpty(id))
            {
                rewardedEmployees.Remove(id);
                if (File.Exists(resultFilePath))
                {
                    string encryptedString = File.ReadAllText(resultFilePath);
                    string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                    string[] employeeList = decrytedString.Split('\n');
                    RewardedEmployeesList.Items.Clear();
                    for (int i = 0; i < employeeList.Length; i++)
                    {
                        string item = employeeList[i];
                        if (!string.IsNullOrEmpty(item))
                        {
                            string[] info = item.Split(',');
                            if (id == info[0])
                            {
                                RewardedEmployeesList.Items.Add(info[0]);
                                RewardedEmployeesList.Items[i].SubItems.Add(info[1]);
                            }
                            else
                            {
                                newRewaredEmployeesStr += item.Substring(0, item.Length - 1) + Environment.NewLine;
                            }
                        }
                    }
                    string encrytedText = EncryptDecryptFile.Encrypt(newRewaredEmployeesStr);
                    MBLottery.writeToFile(resultFilePath, encrytedText);
                }
            }

        }

        private void ReLotteryButton_Click(object sender, EventArgs e)
        {

            switch (_status)
            {
                case LotteryStatus.Started:

                    timer1.Enabled = false;
                    _status = LotteryStatus.Stopped;
                    _rollingPendingList();
                    _rollingPendingList();
                    getRewardedEmplpyee();
                    break;
                case LotteryStatus.Stopped:
                case LotteryStatus.NotStarted:
                    if (isNeedToLottery())
                    {
                        _updatePendingEmp();
                        timer1.Enabled = true;
                        _status = LotteryStatus.Started;
                    }
                    else
                    {
                        MessageBox.Show("没有未抽奖名额.提前祝您春节快乐！！！");
                    }
                    break;
            }

        }
        private bool isNeedToLottery()
        {
            if (giveUpIdList.Count > 0)
            {
                foreach (string id in giveUpIdList)
                {
                    _curRemovedId = id;
                    _level = rewardedEmployees[id].Level;
                    break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        private void _rollingPendingList()
        {
            //int index = -1;
            Employee curEmployee = null;
            string employeeImagePath = "";
            try
            {
                int count = pendingEmployees.Values.Count;
                indexList = RandomExt.getRandomNumberList(MBLottery.rollingCount, count);

                MBLottery._logHandler.logging("Start-------------------");
                foreach (int index in indexList)
                {

                    MBLottery._logHandler.logging("Index: " + index);
                    if (pendingEmployees.ContainsKey(index))
                    {
                        curEmployee = pendingEmployees[index];
                        if (curEmployee != null)
                        {
                            employeeImagePath = System.Windows.Forms.Application.StartupPath + "\\Images\\Employees\\" + curEmployee.Id + ".jpg";
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
                }

                MBLottery._logHandler.logging("End-------------------");

            }
            catch (Exception ex)
            {
                MBLottery._logHandler.logging(ex.Message);
            }


        }
        private void getRewardedEmplpyee()
        {
            string employeeImagePath = "";
            currentRewardedEmployee = null;
            currentRewardedIndex = indexList[0];
            currentRewardedEmployee = pendingEmployees[currentRewardedIndex];
            if (currentRewardedEmployee != null)
            {
                currentRewardedEmployee.Level = _level;
                employeeImagePath = inputPath + "\\Images\\Employees\\" + currentRewardedEmployee.Id + ".jpg";
                if (File.Exists(employeeImagePath))
                {
                    AwardedEmployeePicBox.Image = Image.FromFile(employeeImagePath);
                }
                else
                {
                    AwardedEmployeePicBox.Image = Image.FromFile(inputPath + "\\Images\\Employees\\MB.jpg");
                }
                //remove out from lists
                pendingEmployees.Remove(currentRewardedIndex);
                giveUpIdList.Remove(_curRemovedId);
                _curRemovedId = "";
                _saveResult();
            }

        }
        private void _saveResult()
        {

            string plainText = "";
            string encrytedText;
            if (currentRewardedEmployee != null)
            {
                plainText = currentRewardedEmployee.Id + "," + Enum.GetName(typeof(LotteryLevel), currentRewardedEmployee.Level) + Environment.NewLine;
                MBLottery._logHandler.logging("rewarded: " + plainText);
                if (!File.Exists(resultFilePath))
                {
                    encrytedText = EncryptDecryptFile.Encrypt(plainText);
                    MBLottery.writeToFile(resultFilePath, encrytedText);
                }
                else
                {
                    string encryptedString = File.ReadAllText(resultFilePath);
                    string decrytedString = EncryptDecryptFile.Decrypt(encryptedString);
                    decrytedString = decrytedString + plainText;
                    encrytedText = EncryptDecryptFile.Encrypt(decrytedString);
                    MBLottery.writeToFile(resultFilePath, encrytedText);
                }
            }
            else
            {
                MBLottery._logHandler.logging("currentRewardedEmployee is empty.");
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            _rollingPendingList();
        }


    }
}
