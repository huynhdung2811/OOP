using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Draw
{
    class ClsCircle : ClsHinh
    {
        public ClsDiem begin = new ClsDiem();
        public ClsDiem end = new ClsDiem();
        public ClsCircle()
        {
            begin = new ClsDiem(0, 0);
            end = new ClsDiem(0, 0);
        }
        public ClsCircle(ClsDiem A, ClsDiem B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            Rectangle rect = new Rectangle();
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    rect.X = save[i].x;
                    rect.Y = save[i].y;
                    rect.Size = new Size(save[i + 1].x - save[i].x, save[i + 1].y - save[i].y);
                    g.DrawEllipse(pen, rect);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
}
