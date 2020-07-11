using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rd;

        private void Thread1Button_Click(object sender, EventArgs e)
        {
            
            //Start new thread

            Thread thread = new Thread(t =>

            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 1), new Rectangle(width, height, 10, 10));
                    //Delay
                    Thread.Sleep(100);
                }
            }

            )
            {
                IsBackground = true
            };

            thread.Start();
          

        }

        private void Thread2Button_Click(object sender, EventArgs e)
        {
            //Start new thread
            Thread thread = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 1), new Rectangle(width, height, 10, 10));


                }
            })
            { IsBackground = true };
            thread.Start();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }
    }
}
