using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MBLottery
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
            System.DateTime targetTime=new System.DateTime(2017,1,20); 
            System.DateTime curTime = System.DateTime.Now;

            if (targetTime.Date == curTime.Date && curTime.Hour>18)
            {
                label3.Visible = true;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
