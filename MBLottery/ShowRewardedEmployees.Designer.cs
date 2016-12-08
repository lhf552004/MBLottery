namespace MBLottery
{
    partial class ShowRewardedEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.RewardedEmployeesList = new System.Windows.Forms.ListView();
            this.IDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackToPoolButton = new System.Windows.Forms.Button();
            this.ReLotteryButton = new System.Windows.Forms.Button();
            this.AwardedEmployeePicBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AwardedEmployeePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "获奖名单";
            // 
            // RewardedEmployeesList
            // 
            this.RewardedEmployeesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCol,
            this.levelCol});
            this.RewardedEmployeesList.Location = new System.Drawing.Point(149, 83);
            this.RewardedEmployeesList.Name = "RewardedEmployeesList";
            this.RewardedEmployeesList.Size = new System.Drawing.Size(488, 511);
            this.RewardedEmployeesList.TabIndex = 3;
            this.RewardedEmployeesList.UseCompatibleStateImageBehavior = false;
            this.RewardedEmployeesList.View = System.Windows.Forms.View.Details;
            this.RewardedEmployeesList.SelectedIndexChanged += new System.EventHandler(this.RewardedEmployeesList_SelectedIndexChanged);
            // 
            // IDCol
            // 
            this.IDCol.Text = "员工号";
            this.IDCol.Width = 254;
            // 
            // levelCol
            // 
            this.levelCol.Text = "获奖级别";
            this.levelCol.Width = 227;
            // 
            // BackToPoolButton
            // 
            this.BackToPoolButton.BackColor = System.Drawing.Color.Maroon;
            this.BackToPoolButton.BackgroundImage = global::MBLottery.Properties.Resources.backPool;
            this.BackToPoolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToPoolButton.Enabled = false;
            this.BackToPoolButton.Location = new System.Drawing.Point(84, 294);
            this.BackToPoolButton.Name = "BackToPoolButton";
            this.BackToPoolButton.Size = new System.Drawing.Size(47, 44);
            this.BackToPoolButton.TabIndex = 21;
            this.BackToPoolButton.UseVisualStyleBackColor = false;
            this.BackToPoolButton.Visible = false;
            this.BackToPoolButton.Click += new System.EventHandler(this.BackToPoolButton_Click);
            // 
            // ReLotteryButton
            // 
            this.ReLotteryButton.BackColor = System.Drawing.Color.Tomato;
            this.ReLotteryButton.Enabled = false;
            this.ReLotteryButton.Location = new System.Drawing.Point(701, 214);
            this.ReLotteryButton.Name = "ReLotteryButton";
            this.ReLotteryButton.Size = new System.Drawing.Size(75, 70);
            this.ReLotteryButton.TabIndex = 22;
            this.ReLotteryButton.Text = "重新抽奖";
            this.ReLotteryButton.UseVisualStyleBackColor = false;
            this.ReLotteryButton.Visible = false;
            this.ReLotteryButton.Click += new System.EventHandler(this.ReLotteryButton_Click);
            // 
            // AwardedEmployeePicBox
            // 
            this.AwardedEmployeePicBox.BackColor = System.Drawing.Color.Transparent;
            this.AwardedEmployeePicBox.Location = new System.Drawing.Point(648, 318);
            this.AwardedEmployeePicBox.Name = "AwardedEmployeePicBox";
            this.AwardedEmployeePicBox.Size = new System.Drawing.Size(171, 169);
            this.AwardedEmployeePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwardedEmployeePicBox.TabIndex = 23;
            this.AwardedEmployeePicBox.TabStop = false;
            this.AwardedEmployeePicBox.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShowRewardedEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(831, 606);
            this.Controls.Add(this.AwardedEmployeePicBox);
            this.Controls.Add(this.ReLotteryButton);
            this.Controls.Add(this.BackToPoolButton);
            this.Controls.Add(this.RewardedEmployeesList);
            this.Controls.Add(this.label1);
            this.Name = "ShowRewardedEmployees";
            this.Text = "显示获奖员工";
            this.Load += new System.EventHandler(this.ShowRewardedEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AwardedEmployeePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView RewardedEmployeesList;
        private System.Windows.Forms.ColumnHeader IDCol;
        private System.Windows.Forms.ColumnHeader levelCol;
        private System.Windows.Forms.Button BackToPoolButton;
        private System.Windows.Forms.Button ReLotteryButton;
        private System.Windows.Forms.PictureBox AwardedEmployeePicBox;
        private System.Windows.Forms.Timer timer1;
    }
}