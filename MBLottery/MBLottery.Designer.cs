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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBLottery));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LotteryButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.OpenEmployeesFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TotalEmployeesLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PendingEmployeesListBox = new System.Windows.Forms.ListBox();
            this.AutoSelectLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.SetScreenButton = new System.Windows.Forms.Button();
            this.AwardedEmployeePicBox = new System.Windows.Forms.PictureBox();
            this.BackToPoolButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
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
            this.LotteryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LotteryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.LotteryButton.FlatAppearance.BorderSize = 0;
            this.LotteryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LotteryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LotteryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LotteryButton.ForeColor = System.Drawing.Color.Gold;
            this.LotteryButton.Location = new System.Drawing.Point(420, 596);
            this.LotteryButton.Name = "LotteryButton";
            this.LotteryButton.Size = new System.Drawing.Size(227, 61);
            this.LotteryButton.TabIndex = 0;
            this.LotteryButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LotteryButton.UseVisualStyleBackColor = false;
            this.LotteryButton.Click += new System.EventHandler(this.LotteryButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFileButton.Location = new System.Drawing.Point(861, 0);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 21);
            this.OpenFileButton.TabIndex = 7;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
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
            this.TotalEmployeesLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.TotalEmployeesLabel.Location = new System.Drawing.Point(858, 199);
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
            this.ExitButton.Size = new System.Drawing.Size(42, 34);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            this.ExitButton.MouseHover += new System.EventHandler(this.ExitButton_MouseHover);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Gold;
            this.StatusLabel.Location = new System.Drawing.Point(86, 241);
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
            this.PendingEmployeesListBox.Location = new System.Drawing.Point(848, 220);
            this.PendingEmployeesListBox.Name = "PendingEmployeesListBox";
            this.PendingEmployeesListBox.Size = new System.Drawing.Size(148, 261);
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
            this.AutoSelectLevelCheckBox.Location = new System.Drawing.Point(18, 180);
            this.AutoSelectLevelCheckBox.Name = "AutoSelectLevelCheckBox";
            this.AutoSelectLevelCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoSelectLevelCheckBox.TabIndex = 14;
            this.AutoSelectLevelCheckBox.Text = "自动选择";
            this.AutoSelectLevelCheckBox.UseVisualStyleBackColor = false;
            this.AutoSelectLevelCheckBox.Visible = false;
            this.AutoSelectLevelCheckBox.CheckedChanged += new System.EventHandler(this.AutoSelectLevelCheckBox_CheckedChanged);
            // 
            // SetScreenButton
            // 
            this.SetScreenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SetScreenButton.Location = new System.Drawing.Point(0, 690);
            this.SetScreenButton.Name = "SetScreenButton";
            this.SetScreenButton.Size = new System.Drawing.Size(17, 17);
            this.SetScreenButton.TabIndex = 15;
            this.SetScreenButton.UseVisualStyleBackColor = true;
            this.SetScreenButton.Visible = false;
            this.SetScreenButton.Click += new System.EventHandler(this.SetScreenButton_Click);
            // 
            // AwardedEmployeePicBox
            // 
            this.AwardedEmployeePicBox.BackColor = System.Drawing.Color.Transparent;
            this.AwardedEmployeePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AwardedEmployeePicBox.Location = new System.Drawing.Point(425, 233);
            this.AwardedEmployeePicBox.Name = "AwardedEmployeePicBox";
            this.AwardedEmployeePicBox.Size = new System.Drawing.Size(210, 309);
            this.AwardedEmployeePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwardedEmployeePicBox.TabIndex = 16;
            this.AwardedEmployeePicBox.TabStop = false;
            this.AwardedEmployeePicBox.Visible = false;
            // 
            // BackToPoolButton
            // 
            this.BackToPoolButton.BackColor = System.Drawing.Color.Maroon;
            this.BackToPoolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToPoolButton.Enabled = false;
            this.BackToPoolButton.FlatAppearance.BorderSize = 0;
            this.BackToPoolButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackToPoolButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackToPoolButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToPoolButton.Location = new System.Drawing.Point(652, 403);
            this.BackToPoolButton.Name = "BackToPoolButton";
            this.BackToPoolButton.Size = new System.Drawing.Size(53, 33);
            this.BackToPoolButton.TabIndex = 20;
            this.BackToPoolButton.UseVisualStyleBackColor = false;
            this.BackToPoolButton.Click += new System.EventHandler(this.BackToPoolButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(780, 553);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(177, 30);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // AdditionalRewardUnitLabel
            // 
            this.AdditionalRewardUnitLabel.AutoSize = true;
            this.AdditionalRewardUnitLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdditionalRewardUnitLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalRewardUnitLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AdditionalRewardUnitLabel.Location = new System.Drawing.Point(783, 668);
            this.AdditionalRewardUnitLabel.Name = "AdditionalRewardUnitLabel";
            this.AdditionalRewardUnitLabel.Size = new System.Drawing.Size(26, 22);
            this.AdditionalRewardUnitLabel.TabIndex = 9;
            this.AdditionalRewardUnitLabel.Text = "名";
            this.AdditionalRewardUnitLabel.Visible = false;
            // 
            // AdditionalRewardCountNum
            // 
            this.AdditionalRewardCountNum.BackColor = System.Drawing.Color.Firebrick;
            this.AdditionalRewardCountNum.Location = new System.Drawing.Point(714, 668);
            this.AdditionalRewardCountNum.Name = "AdditionalRewardCountNum";
            this.AdditionalRewardCountNum.Size = new System.Drawing.Size(63, 21);
            this.AdditionalRewardCountNum.TabIndex = 17;
            this.AdditionalRewardCountNum.Visible = false;
            this.AdditionalRewardCountNum.ValueChanged += new System.EventHandler(this.AdditionalRewardCountNum_ValueChanged);
            // 
            // BossPowerCheckBox
            // 
            this.BossPowerCheckBox.AutoSize = true;
            this.BossPowerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.BossPowerCheckBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BossPowerCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BossPowerCheckBox.Location = new System.Drawing.Point(818, 666);
            this.BossPowerCheckBox.Name = "BossPowerCheckBox";
            this.BossPowerCheckBox.Size = new System.Drawing.Size(58, 24);
            this.BossPowerCheckBox.TabIndex = 14;
            this.BossPowerCheckBox.Text = "惊喜";
            this.BossPowerCheckBox.UseVisualStyleBackColor = false;
            this.BossPowerCheckBox.CheckedChanged += new System.EventHandler(this.BossPowerCheckBox_CheckedChanged);
            // 
            // RewardedEmployeesListBox
            // 
            this.RewardedEmployeesListBox.BackColor = System.Drawing.Color.Firebrick;
            this.RewardedEmployeesListBox.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardedEmployeesListBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.RewardedEmployeesListBox.FormattingEnabled = true;
            this.RewardedEmployeesListBox.ItemHeight = 28;
            this.RewardedEmployeesListBox.Location = new System.Drawing.Point(713, 319);
            this.RewardedEmployeesListBox.Name = "RewardedEmployeesListBox";
            this.RewardedEmployeesListBox.Size = new System.Drawing.Size(244, 200);
            this.RewardedEmployeesListBox.TabIndex = 4;
            this.RewardedEmployeesListBox.SelectedIndexChanged += new System.EventHandler(this.RewardedEmployeesListBox_SelectedIndexChanged);
            // 
            // RewardedEmpNameLabel
            // 
            this.RewardedEmpNameLabel.AutoSize = true;
            this.RewardedEmpNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RewardedEmpNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RewardedEmpNameLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.RewardedEmpNameLabel.Location = new System.Drawing.Point(130, 486);
            this.RewardedEmpNameLabel.Name = "RewardedEmpNameLabel";
            this.RewardedEmpNameLabel.Size = new System.Drawing.Size(0, 38);
            this.RewardedEmpNameLabel.TabIndex = 2;
            // 
            // PrizeNameLabel
            // 
            this.PrizeNameLabel.AutoSize = true;
            this.PrizeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PrizeNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrizeNameLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PrizeNameLabel.Location = new System.Drawing.Point(130, 406);
            this.PrizeNameLabel.Name = "PrizeNameLabel";
            this.PrizeNameLabel.Size = new System.Drawing.Size(0, 38);
            this.PrizeNameLabel.TabIndex = 2;
            // 
            // MBLottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 709);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BackToPoolButton);
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
        private System.Windows.Forms.OpenFileDialog OpenEmployeesFileDialog;
        private System.Windows.Forms.Label TotalEmployeesLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListBox PendingEmployeesListBox;
        private System.Windows.Forms.CheckBox AutoSelectLevelCheckBox;
        private System.Windows.Forms.Button SetScreenButton;
        private System.Windows.Forms.PictureBox AwardedEmployeePicBox;
        private System.Windows.Forms.Button BackToPoolButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label AdditionalRewardUnitLabel;
        private System.Windows.Forms.NumericUpDown AdditionalRewardCountNum;
        private System.Windows.Forms.CheckBox BossPowerCheckBox;
        private System.Windows.Forms.Label RewardedEmpNameLabel;
        private System.Windows.Forms.Label PrizeNameLabel;
    }
}

