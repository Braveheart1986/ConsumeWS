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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsumeWS
{
    public partial  class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Fibonancci_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            //Form not closable
            form.ControlBox = false;
            Extens.CloseAfterDelay(form,2000);
            form.ShowDialog();

            localhost.WebService1 Fib = new localhost.WebService1();
            MessageBox.Show("the value in Fibonacci sequence = " + Fib.Fibonacci(10));
        }
        
    }
}

public static class Extens
{
    public static async Task CloseAfterDelay(this Form form, int millisecondsDelay)
    {
        await Task.Delay(millisecondsDelay);
        form.Close();
    }
}