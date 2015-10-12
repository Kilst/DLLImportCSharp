using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//..
using System.Runtime.InteropServices;

namespace TestCppDllImport.view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("Test.lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int GetText(int choice);
        [DllImport("Test.lib.dll")]
        static extern IntPtr Hello();
        [DllImport("Test.lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern IntPtr GuessNumber(int guess);
        [DllImport("Test.lib.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int TimesNumbers(int num1, int num2);

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != String.Empty)
            {
                int choice = int.Parse(txtNumber.Text);
                int num = GetText(choice);
                MessageBox.Show("Number multiplied by 4: " + num);
                string helloWorld = Marshal.PtrToStringAnsi(Hello());
                MessageBox.Show(helloWorld);
            }
            else
                MessageBox.Show("Empty Field!");
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != String.Empty)
            {
                int guess = int.Parse(txtNumber.Text);
                string response = Marshal.PtrToStringAnsi(GuessNumber(guess));
                MessageBox.Show(response);

                MessageBox.Show("TimesNumbers(28, 32) = " + TimesNumbers(28, 32));
            }
            else
                MessageBox.Show("Empty Field!");
        }
    }
}
