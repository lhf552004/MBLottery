using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class CustomListBox : ListBox
    {
        public CustomListBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
        protected override void OnSelectedIndexChanged(EventArgs pe)
        {
            this.Invalidate();
            base.OnSelectedIndexChanged(pe);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (this.Focused && this.SelectedItem != null)
            {
                Rectangle itemRect = this.GetItemRectangle(this.SelectedIndex);
                pe.Graphics.FillRectangle(Brushes.Green, itemRect);
            }
            for (int i = 0; i < Items.Count; i++)
            {
                //StringFormat strFmt = new System.Drawing.StringFormat();
                //strFmt.Alignment = StringAlignment.Center; //文本垂直居中  
                //strFmt.LineAlignment = StringAlignment.Center; //文本水平居中  
                pe.Graphics.DrawString(this.GetItemText(Items[i]), this.Font, new SolidBrush(this.ForeColor), this.GetItemRectangle(i));
            }
            base.OnPaint(pe);
        }

    }
}
