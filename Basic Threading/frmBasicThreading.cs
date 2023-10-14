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

namespace Basic_Threading
{
    public partial class frmBasicThreading : Form
    {
        public frmBasicThreading()
        {
            InitializeComponent();
            label1.Text = "-Before starting thread-";
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(label1.Text.ToString());

            Thread ThreadA = new Thread(MyThreadClass.thread1);
            ThreadA.Name = "Thread A Process";
            ThreadA.Start();

            Thread ThreadB = new Thread(MyThreadClass.thread1);
            ThreadB.Name = "Thread B Process";
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
