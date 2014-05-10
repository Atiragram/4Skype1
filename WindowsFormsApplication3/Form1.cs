﻿using System;
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
           
        }
        NewMessage message_dialog;
        UserInfo user_info;
        private Skype skype_machine;
        private string checked_friend;
        private string _dirName;
        private User current_user;
        private List<string> OnlineFriends= new List<string>();
        private List<string> AllFriends = new List<string>();
        
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
            skype_machine.Attach(9, false);
            ((_ISkypeEvents_Event)skype_machine).AttachmentStatus += OurAttachmentStatus;
             skype_machine.MessageStatus += ReceiveMessage;

        }

        private void OurAttachmentStatus(TAttachmentStatus status)
        {
            if (status == TAttachmentStatus.apiAttachSuccess)
            {
                MessageBox.Show("Присоединение прошло успешно");
                current_user = new User(skype_machine);
                label1.Text = "Привет, " + current_user.GetUser();
                button1.BackgroundImage = WindowsFormsApplication3.Properties.Resources.skype__on;
                checkBox1.Visible = true;
                groupBox1.Visible = true;
                listBox1.Visible = true;
                AllFriends = current_user.GetAllFriends(skype_machine);
                foreach (string friend in AllFriends)
                {
                    listBox1.Items.Add(friend);
                }
                
            }
        }
        private void ReceiveMessage(ChatMessage pmessage, TChatMessageStatus status)
        {
            //Если сообщение получено
            if (status == TChatMessageStatus.cmsReceived)
            {
                if(checked_friend!=null)
                {
                    if(listBox1.Visible==true)
                    {
                        listBox2.Items.Clear();
                        ShowMessageHistory(); 
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OnlineFriends.Clear();
            AllFriends.Clear();
            
                    if (checkBox1.Checked)
                    {
                        OnlineFriends=current_user.GetOnlineFriends(skype_machine);
                        foreach(string friend in OnlineFriends)
                        {
                            listBox1.Items.Add(friend);
                        }
                    }

                    else if(!checkBox1.Checked)
                    {
                        AllFriends = current_user.GetAllFriends(skype_machine);
                        foreach (string friend in AllFriends)
                        {
                            listBox1.Items.Add(friend);
                        }
                    }

            }
            

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (listBox1.SelectedIndex > -1 )
            {
                checked_friend = listBox1.SelectedItem.ToString();
                listBox2.Visible = false;
                button2.Visible = false;
            }
               
        }

        public string ShowInfo(string user)
        {

            string name="", bd="", country="", city="", disp_name="", online="";
            if (skype_machine.get_User(user).FullName != null)
                 name = skype_machine.get_User(user).FullName;
          
              if (skype_machine.get_User(user).Birthday.ToString()!= null)
                  bd = skype_machine.get_User(user).Birthday.ToString();

              if (skype_machine.get_User(user).Country != null)
                    country = skype_machine.get_User(user).Country;

              if (skype_machine.get_User(user).City != null)
                      city = skype_machine.get_User(user).City;

              if (skype_machine.get_User(user).DisplayName != null)
           disp_name= skype_machine.get_User(user).DisplayName;

              if (skype_machine.get_User(user).LastOnline.ToString()!= null)
           online = skype_machine.get_User(user).LastOnline.ToString();

              string result = name + "\n\r" + country + "\n\r" + city + "\n\r" + bd + "\n\r" + online;
            return result;
            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
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
        }

        private void позвонитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (skype_machine.get_User(checked_friend).OnlineStatus == TOnlineStatus.olsOffline)
            {
                MessageBox.Show(checked_friend + " status is " + skype_machine.get_User(checked_friend).OnlineStatus);
            }
            else
                skype_machine.PlaceCall(checked_friend);
        }
       
       

        private void написатьСообщениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            message_dialog = new NewMessage(checked_friend);
            message_dialog.Text = "Сообщение для " + checked_friend;
           
            if( message_dialog.ShowDialog()==DialogResult.OK)
            {
                skype_machine.SendMessage(checked_friend, message_dialog.text_message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                 foreach (string s in listBox2.Items)
                 sw.WriteLine(s);
                sw.Close();
            }
        }

        private void показатьИсториюСообщенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ShowMessageHistory();   
        }

        private void полнаяИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_info = new UserInfo(checked_friend, skype_machine);
            user_info.Text = "Контакт " + checked_friend;
            user_info.ShowDialog();
        }

        private void ShowMessageHistory()
        {

            string skypeUserName = skype_machine.CurrentUserHandle;
            string friend = listBox1.SelectedItem.ToString();
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
                        + friend + "'";
                    ad = new SQLiteDataAdapter(cmd);
                    ad.Fill(dt);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    foreach (DbDataRecord record in reader)
                    {
                        string auth = record["from_dispname"].ToString();
                        string messag = record["body_xml"].ToString();
                        double newdate = Convert.ToDouble(record["timestamp"].ToString());
                        DateTime pDate = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds((double)newdate);
                        listBox2.Items.Add(pDate + " " + auth + ": ");
                        listBox2.Items.Add("   " + messag + "  ");
                        listBox2.Items.Add(" ");

                    }
                    listBox2.Visible = true;
                    button2.Visible = true;
                    sqlite.Close();
                    //dataGridView1.DataSource = dt;
                }
                catch (Exception)
                {

                }
            }
        }
        }
    }

