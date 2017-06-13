using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Windows10S_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenCommandPrompt(object sender, EventArgs e)
        {
            Process.Start("CMD.EXE");
        }

        private void OpenConsoleApp(object sender, EventArgs e)
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            int index = location.LastIndexOf("\\");
            string source = $"{location.Substring(0, index)}\\Windows10S-Console.exe";
            Process.Start(source);
        }
    }
}
