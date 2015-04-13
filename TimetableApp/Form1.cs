using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Helpers;
using System.IO;

namespace TimetableApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = File.ReadAllText(@"name.txt");
            dynamic obj = Json.Decode(s);
            label1.Text = obj.Status;
            Console.WriteLine(obj.Status + ", " + obj.Channel_type);
            Console.ReadLine();
        }
    }
}
