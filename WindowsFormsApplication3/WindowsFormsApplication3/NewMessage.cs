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
    public partial class NewMessage : Form
    {
        public NewMessage()
        {
            InitializeComponent();
            main = new Form1();
        }
        Form1 main;
        public string text_message;
        private void button1_Click(object sender, EventArgs e)
        {
            text_message = textBox1.Text;
            main.Send_Message(text_message);
            this.Close();
        }

        private void NewMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
