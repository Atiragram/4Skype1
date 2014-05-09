using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class UserInfo : Form
    {
        private string info;
        public UserInfo(string str)
        {
            info = str;
            InitializeComponent();
            main = new Form1();
        }
        Form1 main;
        private void UserInfo_Load(object sender, EventArgs e)
        {
            label1.Text = info;
        }
        
    }
}
