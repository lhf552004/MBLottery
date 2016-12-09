namespace MBLottery
{
    partial class MBLottery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LotteryButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.RewardedEmployeesLabel = new System.Windows.Forms.Label();
            this.OpenEmployeesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalEmployeesLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FirstRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondRadioButton = new System.Windows.Forms.RadioButton();
            this.ThirdRadioButton = new System.Windows.Forms.RadioButton();
            this.SpecialRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.RewardedEmployeesListBox = new System.Windows.Forms.ListBox();
            this.PendingEmployeesListBox = new System.Windows.Forms.ListBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AutoSelectLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.SetScreenButton = new System.Windows.Forms.Button();
            this.AwardedEmployeePicBox = new System.Windows.Forms.PictureBox();
            this.SpecialRewardCountNum = new System.Windows.Forms.NumericUpDown();
            this.FirstRewardCountNum = new System.Windows.Forms.NumericUpDown();
            this.SecondRewardCountNum = new System.Windows.Forms.NumericUpDown();
            this.ThirdRewardCountNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GiveUpButton = new System.Windows.Forms.Button();
            this.ShowRewardedListButton = new System.Windows.Forms.Button();
            this.BackToPoolButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.InfoENLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AdditionalRadioButton = new System.Windows.Forms.RadioButton();
            this.AdditionalRewardCountNum = new System.Windows.Forms.NumericUpDown();
            this.BossPowerCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AwardedEmployeePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialRewardCountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstRewardCountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondRewardCountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdRewardCountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalRewardCountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LotteryButton
            // 
            this.LotteryButton.BackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.BackgroundImage = global::MBLottery.Properties.Resources.Small;
            this.LotteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LotteryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LotteryButton.FlatAppearance.BorderSize = 0;
            this.LotteryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LotteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LotteryButton.ForeColor = System.Drawing.Color.Gold;
            this.LotteryButton.Location = new System.Drawing.Point(363, 341);
            this.LotteryButton.Name = "LotteryButton";
            this.LotteryButton.Size = new System.Drawing.Size(194, 218);
            this.LotteryButton.TabIndex = 0;
            this.LotteryButton.Text = "Click me!";
            this.LotteryButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LotteryButton.UseVisualStyleBackColor = false;
            this.LotteryButton.Click += new System.EventHandler(this.LotteryButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = global::MBLottery.Properties.Resources.setting;
            this.OpenFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.Location = new System.Drawing.Point(949, 0);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 7;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // RewardedEmployeesLabel
            // 
            this.RewardedEmployeesLabel.AutoSize = true;
            this.RewardedEmployeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.RewardedEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardedEmployeesLabel.ForeColor = System.Drawing.Color.Gold;
            this.RewardedEmployeesLabel.Location = new System.Drawing.Point(739, 329);
            this.RewardedEmployeesLabel.Name = "RewardedEmployeesLabel";
            this.RewardedEmployeesLabel.Size = new System.Drawing.Size(210, 25);
            this.RewardedEmployeesLabel.TabIndex = 2;
            this.RewardedEmployeesLabel.Text = "Rewarded Employee";
            // 
            // OpenEmployeesFileDialog
            // 
            this.OpenEmployeesFileDialog.FileName = "EmployeeXML";
            this.OpenEmployeesFileDialog.Title = "Please select employees XML file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(302, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "等待抽奖员工数:";
            // 
            // TotalEmployeesLabel
            // 
            this.TotalEmployeesLabel.AutoSize = true;
            this.TotalEmployeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEmployeesLabel.ForeColor = System.Drawing.Color.Gold;
            this.TotalEmployeesLabel.Location = new System.Drawing.Point(503, 226);
            this.TotalEmployeesLabel.Name = "TotalEmployeesLabel";
            this.TotalEmployeesLabel.Size = new System.Drawing.Size(27, 29);
            this.TotalEmployeesLabel.TabIndex = 9;
            this.TotalEmployeesLabel.Text = "0";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Linen;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Image = global::MBLottery.Properties.Resources.Exit;
            this.ExitButton.Location = new System.Drawing.Point(777, 716);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(238, 41);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FirstRadioButton
            // 
            this.FirstRadioButton.AutoSize = true;
            this.FirstRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstRadioButton.Enabled = false;
            this.FirstRadioButton.Location = new System.Drawing.Point(646, 192);
            this.FirstRadioButton.Name = "FirstRadioButton";
            this.FirstRadioButton.Size = new System.Drawing.Size(61, 17);
            this.FirstRadioButton.TabIndex = 12;
            this.FirstRadioButton.Text = "一等奖";
            this.FirstRadioButton.UseVisualStyleBackColor = false;
            // 
            // SecondRadioButton
            // 
            this.SecondRadioButton.AutoSize = true;
            this.SecondRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SecondRadioButton.Enabled = false;
            this.SecondRadioButton.Location = new System.Drawing.Point(646, 215);
            this.SecondRadioButton.Name = "SecondRadioButton";
            this.SecondRadioButton.Size = new System.Drawing.Size(61, 17);
            this.SecondRadioButton.TabIndex = 12;
            this.SecondRadioButton.Text = "二等奖";
            this.SecondRadioButton.UseVisualStyleBackColor = false;
            // 
            // ThirdRadioButton
            // 
            this.ThirdRadioButton.AutoSize = true;
            this.ThirdRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.ThirdRadioButton.Checked = true;
            this.ThirdRadioButton.Enabled = false;
            this.ThirdRadioButton.Location = new System.Drawing.Point(646, 238);
            this.ThirdRadioButton.Name = "ThirdRadioButton";
            this.ThirdRadioButton.Size = new System.Drawing.Size(61, 17);
            this.ThirdRadioButton.TabIndex = 12;
            this.ThirdRadioButton.Text = "三等奖";
            this.ThirdRadioButton.UseVisualStyleBackColor = false;
            // 
            // SpecialRadioButton
            // 
            this.SpecialRadioButton.AutoSize = true;
            this.SpecialRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SpecialRadioButton.Enabled = false;
            this.SpecialRadioButton.Location = new System.Drawing.Point(646, 169);
            this.SpecialRadioButton.Name = "SpecialRadioButton";
            this.SpecialRadioButton.Size = new System.Drawing.Size(61, 17);
            this.SpecialRadioButton.TabIndex = 12;
            this.SpecialRadioButton.Text = "特等奖";
            this.SpecialRadioButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(782, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "名";
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubjectLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = System.Drawing.Color.Yellow;
            this.SubjectLabel.Location = new System.Drawing.Point(312, 111);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(610, 55);
            this.SubjectLabel.TabIndex = 9;
            this.SubjectLabel.Text = "纽豹集团无锡2017年会抽奖";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(12, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Rolling Employees";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Gold;
            this.StatusLabel.Location = new System.Drawing.Point(417, 280);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(96, 25);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Not Start";
            this.StatusLabel.Visible = false;
            // 
            // RewardedEmployeesListBox
            // 
            this.RewardedEmployeesListBox.BackColor = System.Drawing.Color.Red;
            this.RewardedEmployeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardedEmployeesListBox.ForeColor = System.Drawing.Color.Gold;
            this.RewardedEmployeesListBox.FormattingEnabled = true;
            this.RewardedEmployeesListBox.ItemHeight = 25;
            this.RewardedEmployeesListBox.Location = new System.Drawing.Point(744, 359);
            this.RewardedEmployeesListBox.Name = "RewardedEmployeesListBox";
            this.RewardedEmployeesListBox.Size = new System.Drawing.Size(270, 304);
            this.RewardedEmployeesListBox.TabIndex = 4;
            this.RewardedEmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.RewardedEmployeesListBox_SelectedIndexChanged);
            // 
            // PendingEmployeesListBox
            // 
            this.PendingEmployeesListBox.BackColor = System.Drawing.Color.Red;
            this.PendingEmployeesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PendingEmployeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingEmployeesListBox.ForeColor = System.Drawing.Color.Gold;
            this.PendingEmployeesListBox.FormattingEnabled = true;
            this.PendingEmployeesListBox.ItemHeight = 29;
            this.PendingEmployeesListBox.Location = new System.Drawing.Point(17, 359);
            this.PendingEmployeesListBox.Name = "PendingEmployeesListBox";
            this.PendingEmployeesListBox.Size = new System.Drawing.Size(218, 290);
            this.PendingEmployeesListBox.TabIndex = 4;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Gold;
            this.InfoLabel.Location = new System.Drawing.Point(391, 280);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 25);
            this.InfoLabel.TabIndex = 2;
            // 
            // AutoSelectLevelCheckBox
            // 
            this.AutoSelectLevelCheckBox.AutoSize = true;
            this.AutoSelectLevelCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoSelectLevelCheckBox.Checked = true;
            this.AutoSelectLevelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSelectLevelCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.AutoSelectLevelCheckBox.Location = new System.Drawing.Point(18, 195);
            this.AutoSelectLevelCheckBox.Name = "AutoSelectLevelCheckBox";
            this.AutoSelectLevelCheckBox.Size = new System.Drawing.Size(74, 17);
            this.AutoSelectLevelCheckBox.TabIndex = 14;
            this.AutoSelectLevelCheckBox.Text = "自动选择";
            this.AutoSelectLevelCheckBox.UseVisualStyleBackColor = false;
            this.AutoSelectLevelCheckBox.Visible = false;
            this.AutoSelectLevelCheckBox.CheckedChanged += new System.EventHandler(this.AutoSelectLevelCheckBox_CheckedChanged);
            // 
            // SetScreenButton
            // 
            this.SetScreenButton.BackgroundImage = global::MBLottery.Properties.Resources.settingSmall;
            this.SetScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetScreenButton.Location = new System.Drawing.Point(0, 748);
            this.SetScreenButton.Name = "SetScreenButton";
            this.SetScreenButton.Size = new System.Drawing.Size(17, 18);
            this.SetScreenButton.TabIndex = 15;
            this.SetScreenButton.UseVisualStyleBackColor = true;
            this.SetScreenButton.Click += new System.EventHandler(this.SetScreenButton_Click);
            // 
            // AwardedEmployeePicBox
            // 
            this.AwardedEmployeePicBox.BackColor = System.Drawing.Color.Transparent;
            this.AwardedEmployeePicBox.Location = new System.Drawing.Point(375, 587);
            this.AwardedEmployeePicBox.Name = "AwardedEmployeePicBox";
            this.AwardedEmployeePicBox.Size = new System.Drawing.Size(171, 169);
            this.AwardedEmployeePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwardedEmployeePicBox.TabIndex = 16;
            this.AwardedEmployeePicBox.TabStop = false;
            this.AwardedEmployeePicBox.Visible = false;
            // 
            // SpecialRewardCountNum
            // 
            this.SpecialRewardCountNum.BackColor = System.Drawing.Color.Red;
            this.SpecialRewardCountNum.Location = new System.Drawing.Point(713, 169);
            this.SpecialRewardCountNum.Name = "SpecialRewardCountNum";
            this.SpecialRewardCountNum.Size = new System.Drawing.Size(63, 20);
            this.SpecialRewardCountNum.TabIndex = 17;
            this.SpecialRewardCountNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpecialRewardCountNum.ValueChanged += new System.EventHandler(this.SpecialRewardCountNum_ValueChanged);
            // 
            // FirstRewardCountNum
            // 
            this.FirstRewardCountNum.BackColor = System.Drawing.Color.Red;
            this.FirstRewardCountNum.Location = new System.Drawing.Point(713, 191);
            this.FirstRewardCountNum.Name = "FirstRewardCountNum";
            this.FirstRewardCountNum.Size = new System.Drawing.Size(63, 20);
            this.FirstRewardCountNum.TabIndex = 17;
            this.FirstRewardCountNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.FirstRewardCountNum.ValueChanged += new System.EventHandler(this.FirstRewardCountNum_ValueChanged);
            // 
            // SecondRewardCountNum
            // 
            this.SecondRewardCountNum.BackColor = System.Drawing.Color.Red;
            this.SecondRewardCountNum.Location = new System.Drawing.Point(713, 213);
            this.SecondRewardCountNum.Name = "SecondRewardCountNum";
            this.SecondRewardCountNum.Size = new System.Drawing.Size(63, 20);
            this.SecondRewardCountNum.TabIndex = 17;
            this.SecondRewardCountNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.SecondRewardCountNum.ValueChanged += new System.EventHandler(this.SecondRewardCountNum_ValueChanged);
            // 
            // ThirdRewardCountNum
            // 
            this.ThirdRewardCountNum.BackColor = System.Drawing.Color.Red;
            this.ThirdRewardCountNum.Location = new System.Drawing.Point(713, 235);
            this.ThirdRewardCountNum.Name = "ThirdRewardCountNum";
            this.ThirdRewardCountNum.Size = new System.Drawing.Size(63, 20);
            this.ThirdRewardCountNum.TabIndex = 17;
            this.ThirdRewardCountNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThirdRewardCountNum.ValueChanged += new System.EventHandler(this.ThirdRewardCountNum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(782, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(782, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(782, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "名";
            // 
            // GiveUpButton
            // 
            this.GiveUpButton.BackColor = System.Drawing.Color.Red;
            this.GiveUpButton.Enabled = false;
            this.GiveUpButton.Location = new System.Drawing.Point(566, 599);
            this.GiveUpButton.Name = "GiveUpButton";
            this.GiveUpButton.Size = new System.Drawing.Size(88, 79);
            this.GiveUpButton.TabIndex = 18;
            this.GiveUpButton.Text = "放弃";
            this.GiveUpButton.UseVisualStyleBackColor = false;
            this.GiveUpButton.Visible = false;
            this.GiveUpButton.Click += new System.EventHandler(this.GiveUpButton_Click);
            // 
            // ShowRewardedListButton
            // 
            this.ShowRewardedListButton.BackColor = System.Drawing.Color.Red;
            this.ShowRewardedListButton.Location = new System.Drawing.Point(17, 119);
            this.ShowRewardedListButton.Name = "ShowRewardedListButton";
            this.ShowRewardedListButton.Size = new System.Drawing.Size(74, 63);
            this.ShowRewardedListButton.TabIndex = 19;
            this.ShowRewardedListButton.Text = "获奖记录";
            this.ShowRewardedListButton.UseVisualStyleBackColor = false;
            this.ShowRewardedListButton.Visible = false;
            this.ShowRewardedListButton.Click += new System.EventHandler(this.ShowRewardedListButton_Click);
            // 
            // BackToPoolButton
            // 
            this.BackToPoolButton.BackColor = System.Drawing.Color.Maroon;
            this.BackToPoolButton.BackgroundImage = global::MBLottery.Properties.Resources.backPool;
            this.BackToPoolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToPoolButton.Enabled = false;
            this.BackToPoolButton.Location = new System.Drawing.Point(691, 471);
            this.BackToPoolButton.Name = "BackToPoolButton";
            this.BackToPoolButton.Size = new System.Drawing.Size(47, 44);
            this.BackToPoolButton.TabIndex = 20;
            this.BackToPoolButton.UseVisualStyleBackColor = false;
            this.BackToPoolButton.Click += new System.EventHandler(this.BackToPoolButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Red;
            this.ResetButton.Location = new System.Drawing.Point(17, 59);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 49);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Text = "重新抽奖";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(304, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(713, 32);
            this.label7.TabIndex = 9;
            this.label7.Text = "Muehlbauer (Wuxi) 2017 Annual Dinner And Lottery";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(302, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total of Pending Employees ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(739, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "获奖名单";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(12, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "滚动名单";
            // 
            // InfoENLabel
            // 
            this.InfoENLabel.AutoSize = true;
            this.InfoENLabel.BackColor = System.Drawing.Color.Transparent;
            this.InfoENLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoENLabel.ForeColor = System.Drawing.Color.Gold;
            this.InfoENLabel.Location = new System.Drawing.Point(391, 312);
            this.InfoENLabel.Name = "InfoENLabel";
            this.InfoENLabel.Size = new System.Drawing.Size(0, 23);
            this.InfoENLabel.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gold;
            this.label11.Location = new System.Drawing.Point(782, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "名";
            // 
            // AdditionalRadioButton
            // 
            this.AdditionalRadioButton.AutoSize = true;
            this.AdditionalRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalRadioButton.Enabled = false;
            this.AdditionalRadioButton.Location = new System.Drawing.Point(646, 261);
            this.AdditionalRadioButton.Name = "AdditionalRadioButton";
            this.AdditionalRadioButton.Size = new System.Drawing.Size(61, 17);
            this.AdditionalRadioButton.TabIndex = 12;
            this.AdditionalRadioButton.Text = "安慰奖";
            this.AdditionalRadioButton.UseVisualStyleBackColor = false;
            this.AdditionalRadioButton.Visible = false;
            // 
            // AdditionalRewardCountNum
            // 
            this.AdditionalRewardCountNum.BackColor = System.Drawing.Color.Red;
            this.AdditionalRewardCountNum.Location = new System.Drawing.Point(713, 258);
            this.AdditionalRewardCountNum.Name = "AdditionalRewardCountNum";
            this.AdditionalRewardCountNum.Size = new System.Drawing.Size(63, 20);
            this.AdditionalRewardCountNum.TabIndex = 17;
            this.AdditionalRewardCountNum.Visible = false;
            this.AdditionalRewardCountNum.ValueChanged += new System.EventHandler(this.AdditionalRewardCountNum_ValueChanged);
            // 
            // BossPowerCheckBox
            // 
            this.BossPowerCheckBox.AutoSize = true;
            this.BossPowerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.BossPowerCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.BossPowerCheckBox.Location = new System.Drawing.Point(675, 284);
            this.BossPowerCheckBox.Name = "BossPowerCheckBox";
            this.BossPowerCheckBox.Size = new System.Drawing.Size(74, 17);
            this.BossPowerCheckBox.TabIndex = 14;
            this.BossPowerCheckBox.Text = "领导特权";
            this.BossPowerCheckBox.UseVisualStyleBackColor = false;
            this.BossPowerCheckBox.CheckedChanged += new System.EventHandler(this.BossPowerCheckBox_CheckedChanged);
            // 
            // MBLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBLottery.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.InfoENLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BackToPoolButton);
            this.Controls.Add(this.ShowRewardedListButton);
            this.Controls.Add(this.GiveUpButton);
            this.Controls.Add(this.AdditionalRewardCountNum);
            this.Controls.Add(this.ThirdRewardCountNum);
            this.Controls.Add(this.SecondRewardCountNum);
            this.Controls.Add(this.FirstRewardCountNum);
            this.Controls.Add(this.SpecialRewardCountNum);
            this.Controls.Add(this.AwardedEmployeePicBox);
            this.Controls.Add(this.SetScreenButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.BossPowerCheckBox);
            this.Controls.Add(this.AutoSelectLevelCheckBox);
            this.Controls.Add(this.PendingEmployeesListBox);
            this.Controls.Add(this.RewardedEmployeesListBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RewardedEmployeesLabel);
            this.Controls.Add(this.AdditionalRadioButton);
            this.Controls.Add(this.ThirdRadioButton);
            this.Controls.Add(this.SecondRadioButton);
            this.Controls.Add(this.LotteryButton);
            this.Controls.Add(this.SpecialRadioButton);
            this.Controls.Add(this.FirstRadioButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalEmployeesLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MBLottery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MBLottery";
            this.Load += new System.EventHandler(this.MBLottery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AwardedEmployeePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialRewardCountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstRewardCountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondRewardCountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdRewardCountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdditionalRewardCountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button LotteryButton;
        //private ControlLibrary.CustomListBox RewardedEmployeesListBox;
        private System.Windows.Forms.ListBox RewardedEmployeesListBox;
        private System.Windows.Forms.Label RewardedEmployeesLabel;
        private System.Windows.Forms.OpenFileDialog OpenEmployeesFileDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalEmployeesLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RadioButton FirstRadioButton;
        private System.Windows.Forms.RadioButton SecondRadioButton;
        private System.Windows.Forms.RadioButton ThirdRadioButton;
        private System.Windows.Forms.RadioButton SpecialRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListBox PendingEmployeesListBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.CheckBox AutoSelectLevelCheckBox;
        private System.Windows.Forms.Button SetScreenButton;
        private System.Windows.Forms.PictureBox AwardedEmployeePicBox;
        private System.Windows.Forms.NumericUpDown SpecialRewardCountNum;
        private System.Windows.Forms.NumericUpDown FirstRewardCountNum;
        private System.Windows.Forms.NumericUpDown SecondRewardCountNum;
        private System.Windows.Forms.NumericUpDown ThirdRewardCountNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GiveUpButton;
        private System.Windows.Forms.Button ShowRewardedListButton;
        private System.Windows.Forms.Button BackToPoolButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label InfoENLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton AdditionalRadioButton;
        private System.Windows.Forms.NumericUpDown AdditionalRewardCountNum;
        private System.Windows.Forms.CheckBox BossPowerCheckBox;
    }
}

