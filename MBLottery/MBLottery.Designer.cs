using BusinessObjects;
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
            this.TotalEmployeesLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PendingEmployeesListBox = new System.Windows.Forms.ListBox();
            this.AutoSelectLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.SetScreenButton = new System.Windows.Forms.Button();
            this.AwardedEmployeePicBox = new System.Windows.Forms.PictureBox();
            this.GiveUpButton = new System.Windows.Forms.Button();
            this.ShowRewardedListButton = new System.Windows.Forms.Button();
            this.BackToPoolButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AdditionalRewardUnitLabel = new System.Windows.Forms.Label();
            this.AdditionalRewardCountNum = new System.Windows.Forms.NumericUpDown();
            this.BossPowerCheckBox = new System.Windows.Forms.CheckBox();
            this.RewardedEmployeesListBox = new System.Windows.Forms.ListBox();
            this.RewardedEmpNameLabel = new System.Windows.Forms.Label();
            this.PrizeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AwardedEmployeePicBox)).BeginInit();
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
            this.LotteryButton.BackgroundImage = global::MBLottery.Properties.Resources.start;
            this.LotteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LotteryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LotteryButton.FlatAppearance.BorderSize = 0;
            this.LotteryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LotteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LotteryButton.ForeColor = System.Drawing.Color.Gold;
            this.LotteryButton.Location = new System.Drawing.Point(420, 646);
            this.LotteryButton.Name = "LotteryButton";
            this.LotteryButton.Size = new System.Drawing.Size(227, 66);
            this.LotteryButton.TabIndex = 0;
            this.LotteryButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LotteryButton.UseVisualStyleBackColor = false;
            this.LotteryButton.Click += new System.EventHandler(this.LotteryButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Image = global::MBLottery.Properties.Resources.setting;
            this.OpenFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.Location = new System.Drawing.Point(861, 0);
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
            this.RewardedEmployeesLabel.Location = new System.Drawing.Point(766, 329);
            this.RewardedEmployeesLabel.Name = "RewardedEmployeesLabel";
            this.RewardedEmployeesLabel.Size = new System.Drawing.Size(210, 25);
            this.RewardedEmployeesLabel.TabIndex = 2;
            this.RewardedEmployeesLabel.Text = "Rewarded Employee";
            this.RewardedEmployeesLabel.Visible = false;
            // 
            // OpenEmployeesFileDialog
            // 
            this.OpenEmployeesFileDialog.FileName = "EmployeeXML";
            this.OpenEmployeesFileDialog.Title = "Please select employees XML file";
            // 
            // TotalEmployeesLabel
            // 
            this.TotalEmployeesLabel.AutoSize = true;
            this.TotalEmployeesLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalEmployeesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalEmployeesLabel.ForeColor = System.Drawing.Color.Gold;
            this.TotalEmployeesLabel.Location = new System.Drawing.Point(858, 216);
            this.TotalEmployeesLabel.Name = "TotalEmployeesLabel";
            this.TotalEmployeesLabel.Size = new System.Drawing.Size(16, 16);
            this.TotalEmployeesLabel.TabIndex = 9;
            this.TotalEmployeesLabel.Text = "0";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Location = new System.Drawing.Point(979, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(42, 37);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
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
            this.label5.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Gold;
            this.StatusLabel.Location = new System.Drawing.Point(86, 261);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(96, 25);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Not Start";
            this.StatusLabel.Visible = false;
            // 
            // PendingEmployeesListBox
            // 
            this.PendingEmployeesListBox.BackColor = System.Drawing.Color.Red;
            this.PendingEmployeesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PendingEmployeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingEmployeesListBox.ForeColor = System.Drawing.Color.Gold;
            this.PendingEmployeesListBox.FormattingEnabled = true;
            this.PendingEmployeesListBox.ItemHeight = 29;
            this.PendingEmployeesListBox.Location = new System.Drawing.Point(848, 238);
            this.PendingEmployeesListBox.Name = "PendingEmployeesListBox";
            this.PendingEmployeesListBox.Size = new System.Drawing.Size(148, 290);
            this.PendingEmployeesListBox.TabIndex = 4;
            this.PendingEmployeesListBox.Visible = false;
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
            this.AwardedEmployeePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AwardedEmployeePicBox.Location = new System.Drawing.Point(425, 252);
            this.AwardedEmployeePicBox.Name = "AwardedEmployeePicBox";
            this.AwardedEmployeePicBox.Size = new System.Drawing.Size(210, 335);
            this.AwardedEmployeePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwardedEmployeePicBox.TabIndex = 16;
            this.AwardedEmployeePicBox.TabStop = false;
            this.AwardedEmployeePicBox.Visible = false;
            // 
            // GiveUpButton
            // 
            this.GiveUpButton.BackColor = System.Drawing.Color.Red;
            this.GiveUpButton.Enabled = false;
            this.GiveUpButton.Location = new System.Drawing.Point(801, 597);
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
            this.BackToPoolButton.Location = new System.Drawing.Point(649, 412);
            this.BackToPoolButton.Name = "BackToPoolButton";
            this.BackToPoolButton.Size = new System.Drawing.Size(47, 44);
            this.BackToPoolButton.TabIndex = 20;
            this.BackToPoolButton.UseVisualStyleBackColor = false;
            this.BackToPoolButton.Click += new System.EventHandler(this.BackToPoolButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Red;
            this.ResetButton.BackgroundImage = global::MBLottery.Properties.Resources.restart;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(694, 646);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(227, 66);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(766, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "获奖名单";
            this.label9.Visible = false;
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
            this.label10.Visible = false;
            // 
            // AdditionalRewardUnitLabel
            // 
            this.AdditionalRewardUnitLabel.AutoSize = true;
            this.AdditionalRewardUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalRewardUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalRewardUnitLabel.ForeColor = System.Drawing.Color.Gold;
            this.AdditionalRewardUnitLabel.Location = new System.Drawing.Point(804, 174);
            this.AdditionalRewardUnitLabel.Name = "AdditionalRewardUnitLabel";
            this.AdditionalRewardUnitLabel.Size = new System.Drawing.Size(26, 20);
            this.AdditionalRewardUnitLabel.TabIndex = 9;
            this.AdditionalRewardUnitLabel.Text = "名";
            this.AdditionalRewardUnitLabel.Visible = false;
            // 
            // AdditionalRewardCountNum
            // 
            this.AdditionalRewardCountNum.BackColor = System.Drawing.Color.Red;
            this.AdditionalRewardCountNum.Location = new System.Drawing.Point(735, 174);
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
            this.BossPowerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossPowerCheckBox.ForeColor = System.Drawing.Color.Gold;
            this.BossPowerCheckBox.Location = new System.Drawing.Point(848, 172);
            this.BossPowerCheckBox.Name = "BossPowerCheckBox";
            this.BossPowerCheckBox.Size = new System.Drawing.Size(57, 22);
            this.BossPowerCheckBox.TabIndex = 14;
            this.BossPowerCheckBox.Text = "惊喜";
            this.BossPowerCheckBox.UseVisualStyleBackColor = false;
            this.BossPowerCheckBox.CheckedChanged += new System.EventHandler(this.BossPowerCheckBox_CheckedChanged);
            // 
            // RewardedEmployeesListBox
            // 
            this.RewardedEmployeesListBox.BackColor = System.Drawing.Color.Firebrick;
            this.RewardedEmployeesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardedEmployeesListBox.ForeColor = System.Drawing.Color.Gold;
            this.RewardedEmployeesListBox.FormattingEnabled = true;
            this.RewardedEmployeesListBox.ItemHeight = 25;
            this.RewardedEmployeesListBox.Location = new System.Drawing.Point(713, 346);
            this.RewardedEmployeesListBox.Name = "RewardedEmployeesListBox";
            this.RewardedEmployeesListBox.Size = new System.Drawing.Size(244, 229);
            this.RewardedEmployeesListBox.TabIndex = 4;
            this.RewardedEmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.RewardedEmployeesListBox_SelectedIndexChanged);
            // 
            // RewardedEmpNameLabel
            // 
            this.RewardedEmpNameLabel.AutoSize = true;
            this.RewardedEmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RewardedEmpNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardedEmpNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.RewardedEmpNameLabel.Location = new System.Drawing.Point(126, 527);
            this.RewardedEmpNameLabel.Name = "RewardedEmpNameLabel";
            this.RewardedEmpNameLabel.Size = new System.Drawing.Size(0, 25);
            this.RewardedEmpNameLabel.TabIndex = 2;
            // 
            // PrizeNameLabel
            // 
            this.PrizeNameLabel.AutoSize = true;
            this.PrizeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrizeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeNameLabel.ForeColor = System.Drawing.Color.Gold;
            this.PrizeNameLabel.Location = new System.Drawing.Point(130, 440);
            this.PrizeNameLabel.Name = "PrizeNameLabel";
            this.PrizeNameLabel.Size = new System.Drawing.Size(0, 25);
            this.PrizeNameLabel.TabIndex = 2;
            // 
            // MBLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MBLottery.Properties.Resources.BackgroundNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BackToPoolButton);
            this.Controls.Add(this.ShowRewardedListButton);
            this.Controls.Add(this.GiveUpButton);
            this.Controls.Add(this.AdditionalRewardCountNum);
            this.Controls.Add(this.AwardedEmployeePicBox);
            this.Controls.Add(this.SetScreenButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.BossPowerCheckBox);
            this.Controls.Add(this.AutoSelectLevelCheckBox);
            this.Controls.Add(this.PendingEmployeesListBox);
            this.Controls.Add(this.RewardedEmployeesListBox);
            this.Controls.Add(this.PrizeNameLabel);
            this.Controls.Add(this.RewardedEmpNameLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RewardedEmployeesLabel);
            this.Controls.Add(this.LotteryButton);
            this.Controls.Add(this.AdditionalRewardUnitLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TotalEmployeesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MBLottery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MBLottery";
            this.Load += new System.EventHandler(this.MBLottery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AwardedEmployeePicBox)).EndInit();
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
        private System.Windows.Forms.Label TotalEmployeesLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListBox PendingEmployeesListBox;
        private System.Windows.Forms.CheckBox AutoSelectLevelCheckBox;
        private System.Windows.Forms.Button SetScreenButton;
        private System.Windows.Forms.PictureBox AwardedEmployeePicBox;
        private System.Windows.Forms.Button GiveUpButton;
        private System.Windows.Forms.Button ShowRewardedListButton;
        private System.Windows.Forms.Button BackToPoolButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AdditionalRewardUnitLabel;
        private System.Windows.Forms.NumericUpDown AdditionalRewardCountNum;
        private System.Windows.Forms.CheckBox BossPowerCheckBox;
        private System.Windows.Forms.Label RewardedEmpNameLabel;
        private System.Windows.Forms.Label PrizeNameLabel;
    }
}

