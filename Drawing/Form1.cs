using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Drawing : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        int s = 2;
        bool moving = false;
        bool penDrow = false;
        bool rect = false;
        Pen pen;
        Rectangle rectangle;
      
        public Drawing()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, s);
            rectangle = new Rectangle(0, 0, 10, 10);
        }

    
        private void label1_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            pen.Color = lb.BackColor;
            lb.BorderStyle = BorderStyle.Fixed3D;
            
       
        }


        private void pencil_Click(object sender, EventArgs e)
        {
            pencilSize.Visible = true;
            penDrow = true;
            rect = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
       
            x=e.X ;
            y=e.Y ;

            if (rect && !penDrow && x != -1 && y != -1)
            {
                g.DrawRectangle(pen, x, y, 20, 30);
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            
            x = -1;
            y = -1;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (moving && penDrow && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                
            }
           

            x = e.X;
            y = e.Y;
        }

       

        private void pencilSize_ValueChanged(object sender, EventArgs e)
        {
            s = Convert.ToInt32(pencilSize.Value);
            pen.Width = s;
        }

        private void rubber_Click(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void rectangleBox2_Click(object sender, EventArgs e)
        {
            rect = true;
            penDrow = false;

        }
    }
}
