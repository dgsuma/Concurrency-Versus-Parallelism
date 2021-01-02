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

namespace AsyncVsThreadWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            SomeMethod();
        }

        public async void SomeMethod()
        {
            await Task.Delay(20000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
