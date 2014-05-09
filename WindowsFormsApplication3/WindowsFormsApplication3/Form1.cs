using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Data.SQLite;
using System.Data.Common;
using SKYPE4COMLib;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _dirName = Environment.GetEnvironmentVariable("APPDATA") + @"\Skype";
           //message_dialog = new NewMessage();
        }
       // NewMessage message_dialog;
        private Skype skype_machine;
        private string checked_friend;
        private string _dirName;
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            skype_machine = new Skype();
            if (!skype_machine.Client.IsRunning)
            {
                skype_machine.Client.Start(true, true);
            }
            //Подписываемся на событие присоединения к Skype
            ((_ISkypeEvents_Event)skype_machine).AttachmentStatus += OurAttachmentStatus;
            skype_machine.Attach(9,false);

        }

        private void OurAttachmentStatus(TAttachmentStatus status)
        {
            if (status == TAttachmentStatus.apiAttachSuccess)
            {
                MessageBox.Show("Присоединение прошло успешно");
                label1.Text = "Привет, " + skype_machine.CurrentUserProfile.FullName;
                button1.BackgroundImage = WindowsFormsApplication3.Properties.Resources.skype__on;
                if (skype_machine.Friends.Count > 0)
                {
                    for (int i = 1; i < skype_machine.Friends.Count; i++)
                    {
                        listBox1.Items.Add(skype_machine.Friends[i].Handle);
                    }
                }
            }
            /*skype_machine.Client.OpenAddContactDialog("pavlusha_kalashnikov");
            string uname = "pavlusha_kalashnikov";
            skype_machine.SendMessage(uname, tmsg);
            skype_machine.PlaceCall("pavlusha_kalashnikov");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
                    if (checkBox1.Checked)
                    {
                        for (int i = 1; i < skype_machine.Friends.Count; i++)
                        {
                            if (skype_machine.Friends[i].OnlineStatus != TOnlineStatus.olsOffline)
                            {
                                listBox1.Items.Add(skype_machine.Friends[i].Handle);
                            }
                        }
                    }

                    else if(!checkBox1.Checked)
                    {
                        for (int i = 1; i < skype_machine.Friends.Count; i++)
                        {
                             listBox1.Items.Add(skype_machine.Friends[i].Handle);
                        }
                    }

            }
            

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checked_friend = listBox1.SelectedItem.ToString();
            listBox2.Items.Clear();
           
            if (listBox1.SelectedIndex > -1 )
            {
                string skypeUserName = skype_machine.CurrentUserHandle;
                string participant = listBox1.SelectedItem.ToString();
                string database = _dirName + @"\" + skypeUserName + @"\main.db";

                if (File.Exists(database))
                {
                    SQLiteConnection sqlite = new SQLiteConnection("data source=" + database);
                    SQLiteDataAdapter ad;
                    DataTable dt = new DataTable();
                    SQLiteCommand cmd;

                    try
                    {
                        sqlite.Open();
                        cmd = sqlite.CreateCommand();
                        cmd.CommandText = @"select from_dispname,author,timestamp, body_xml from Messages Where dialog_partner = '"
                            + participant + "'";
                        ad = new SQLiteDataAdapter(cmd);
                        ad.Fill(dt);
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        foreach (DbDataRecord record in reader)
                        {
                            string auth = record["from_dispname"].ToString();
                            string messag = record["body_xml"].ToString();
                            double newdate = Convert.ToDouble(record["timestamp"].ToString()) ;
                            DateTime pDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds((double)newdate);
                           listBox2.Items.Add( pDate+" "+ auth+": ");
                            listBox2.Items.Add("   "+messag+"  ");
                            
                        }
                        sqlite.Close();
                        //dataGridView1.DataSource = dt;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void ShowInfo(string user)
        {
           
           string name;
           name = skype_machine.get_User(user).FullName;
            if(name=="")
            {
                name = "no information";
            }
            MessageBox.Show(name);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //ShowInfo(checked_friend);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            listBox1.ContextMenuStrip = contextMenuStrip1;

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
           if(e.Button==MouseButtons.Right)
         {
               //listBox1_SelectedIndexChanged(sender, e);
          }

            
        }

        private void позвонитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // if (checked_friend != TOnlineStatus.olsOffline)
                //(skype_machine.Friends[i].OnlineStatus != TOnlineStatus.olsOffline)
            if (skype_machine.get_User(checked_friend).OnlineStatus == TOnlineStatus.olsOffline)
            {
                MessageBox.Show(checked_friend + " status is " + skype_machine.get_User(checked_friend).OnlineStatus);
            }
            else
                skype_machine.PlaceCall(checked_friend);
        }
       
        public void Send_Message(string text)
        {
            skype_machine.SendMessage(checked_friend, text);
        }

        private void написатьСообщениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //message_dialog.ShowDialog();
        }
    }
}
