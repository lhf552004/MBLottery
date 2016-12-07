using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace MBLottery
{
    class ImageGenerate
    {
        public static void generateJPG()
        {
   //         Bitmap bmp = new Bitmap(700, 550);                      //改图只显示最近输入的700个点的数据曲线。
   //Graphics graphics = Graphics.FromImage(bmp);
   //SolidBrush brush1 = new SolidBrush(Color.FromArgb(236, 233, 216));
   //graphics.FillRectangle(brush1, 0, 0, 700, 550);//Brushes.Sienna
   ////DrawXYSys(new Point(orgx,orgy), 710, 500, graphics);//在图形上画出坐标系
   //bmp.Save("c:\\11.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
   
  //Graphics g = Graphics.FromHwnd(this.panel4.Handle);
  // g.DrawImage(bmp, new Point(0, 0));//在内存里画完后显示在控件上，避免闪。
  // // 保存到硬盘上
  // //bmp.Save("c:\\11.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);//指定图片格式   
  // bmp.Dispose(); g.Dispose(); graphics.Dispose(); brush1.Dispose();//一定释放内存。
            string employeesFilePath = System.Windows.Forms.Application.StartupPath + "\\Employee.XML";
            string id = "";
            string name = "";
            string translatedName = "";
            XmlDocument employeesDoc;
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
                Image img = DrawText(id, new Font("Arial", 40), Color.FromArgb(0, 0, 0), Color.FromArgb(236, 233, 216));
                string imgPath = System.Windows.Forms.Application.StartupPath + "\\Images\\Employees\\" + id + ".jpg";
                img.Save(imgPath, System.Drawing.Imaging.ImageFormat.Jpeg);

            }
    


            
        }

        private static Image DrawText(String text, Font font, Color textColor, Color backColor)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(500, 500);
            Graphics drawing = Graphics.FromImage(img);

            ////measure the string to see how big the image needs to be
            //SizeF textSize = drawing.MeasureString(text, font);

            ////free up the dummy image and old graphics object
            //img.Dispose();
            //drawing.Dispose();

            ////create a new image of the right size
            //img = new Bitmap(700, 500);

            //drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);

            drawing.DrawString(text, font, textBrush, 180, 200);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }
    }
}
