using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public static class Painter
    {
        private static int widthImg = 698;
        private static int heightImg = 133;
        private static int intervalBlocks = 50;
        private static int thickness = 3;
        private static int x, y, width, height, count, length;
        private static double multiplier;
        private static Image? img;
        private static Pen blackPen = new Pen(Color.Black, thickness);
        private static Pen greenPen = new Pen(Color.Green, thickness);
        private static Pen greenPenArrow = new Pen(Color.Green, thickness*3);
        private static Pen redPen = new Pen(Color.Red, thickness);
        private static Pen redPenArrow = new Pen(Color.Red, thickness*3);
        private static Font font = new Font("Arial", 15);
        private static SolidBrush brush = new SolidBrush(Color.Black);
        private static bool hadInterval;
        public static void PaintList(List<string> list, int actionList, string name)
        {
            greenPenArrow.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            redPenArrow.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            x = 40;
            y = 20;
            height = 80;
            hadInterval = false;

            img = new Bitmap(widthImg, heightImg);

            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.Clear(Color.White);
                count = 0;
                length = list.Count;
                foreach (string item in list)
                {
                    width = item.Length * 20;

                    if (count >= length - Math.Abs(actionList))
                    {
                        if (actionList > 0)
                        {
                            hadInterval = drawArrow(gr, greenPenArrow, hadInterval);
                            gr.DrawRectangle(greenPen, x, y, width, height);
                        }
                        else if (actionList < 0)
                        {
                            hadInterval = drawArrow(gr, redPenArrow, hadInterval);
                            gr.DrawRectangle(redPen, x, y, width, height);
                        }
                    }
                    else
                    {
                        gr.DrawRectangle(blackPen, x, y, width, height);
                    }
                    multiplier = item.Length == 1 ? 10 : 7.5;
                    gr.DrawString(item, font, brush, (float)(x + width / 2 - item.Length * multiplier), (float)(y + height / 2 - 10));

                    x += width;
                    count++;
                }
            }
            img.Save(name, ImageFormat.Jpeg);
        }
        private static bool drawArrow(Graphics gr, Pen pen, bool hadInterval)
        {
            if (!hadInterval)
            {
                gr.DrawLine(pen, x + 5, y + height / 2, x + intervalBlocks - 5, y + height / 2);

                x += intervalBlocks;
                hadInterval = true;
            }
            return hadInterval;
        }
    }
}
