using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinCosTransaction
{
    public partial class SinAndCosForm : Form
    {
        public SinAndCosForm()
        {
            InitializeComponent();
        }
        Pen pen = new Pen(Color.Black, 2.0F);
        Pen pen2 = new Pen(Color.Green, 2.0F);
        
        List<PointF> sinPoints = new List<PointF>();
        List<PointF> cosPoints = new List<PointF>();
        List<PointF> xPoints = new List<PointF>();
        List<PointF> yPoints = new List<PointF>();

        int isaret;
        Matematik matematik = new Matematik();
        public void SinyalCiz(int baslangic,int bitis,int sign)
        {
            this.isaret = sign;
            if (isaret == 0)
            {
                for (int i = baslangic; i < bitis; i++)
                {
                    float sinY = (float)matematik.SinBul(i) * (-1);

                    float sinX = pictureBox1.Height / 2;
                    sinPoints.Add(new PointF(i+pictureBox1.Width/2,sinY*sinX+sinX));
                    
                }
            }else if (isaret == 1)
            {
                for (int i = baslangic; i < bitis; i++)
                {
                    float cosY = (float)matematik.cosBul(i) * (-1);

                    float cosX = pictureBox1.Height / 2;
                    cosPoints.Add(new PointF(i +pictureBox1.Width/2, cosY * cosX + cosX));
                }
            }
            for (int i = 0;i < 427; i++) 
                yPoints.Add(new PointF(pictureBox1.Width / 2, i));
            for (int i = 0; i < 787; i++)
            {
                xPoints.Add(new PointF(i,pictureBox1.Height / 2));
            }

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(Color.White);
            if (isaret == 0)
            {
                
                if (sinPoints.Count() > 0)
                {
                    e.Graphics.DrawCurve(pen, sinPoints.ToArray());
                }
            }else if (isaret == 1) 
            {
                if (cosPoints.Count() > 0)
                {
                    e.Graphics.DrawCurve(pen, cosPoints.ToArray());
                }
            }

            e.Graphics.DrawCurve(pen2, xPoints.ToArray());            
            e.Graphics.DrawCurve(pen2, yPoints.ToArray());            
        }
    }
}
