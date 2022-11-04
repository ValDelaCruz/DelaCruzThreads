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

namespace DelaCruzThreads
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart threadObj = new ThreadStart(MyThreadClass.Thread1);
            Console.WriteLine("");
            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.WriteLine("Hi, I'm Allysah Valerie C. Dela Cruz");
            Thread.Sleep(1500);
            Console.WriteLine("From BSIT 3.1 - A");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Thread.Sleep(1000);
            Console.WriteLine("-Before starting thread-");
            Thread.Sleep(1000);

            ThreadA = new Thread(threadObj);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(threadObj);
            ThreadB.Name = "Thread B Process";

            //Thread starting...
            ThreadA.Start();
            ThreadB.Start();

            //Thread calling stopped...
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            lblThread.Text = "-End of Thread-";            
        }

        
    }
}
