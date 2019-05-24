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

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

    private void Button1_Click(object sender, EventArgs e)
        {
            
            Thread t1 = new Thread(SayHello);
            t1.Name = "thread1";
            t1.Priority = ThreadPriority.AboveNormal;
            t1.Start();
        }
        private void SayHello()
        {
            label1.Text = "lukasersvans";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "hello nigga";
        }
    }

}
