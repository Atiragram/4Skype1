using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYPE4COMLib;

namespace WindowsFormsApplication3
{
    public partial class UserInfo : Form
    {
        private string friend;
        private Skype skype;
        public UserInfo(string friend, Skype skype)
        {
            this.friend = friend;
            this.skype=skype;
            InitializeComponent();
           // main = new Form1();
        }
       // Form1 main;
        private void UserInfo_Load(object sender, EventArgs e)
        {
            FriendInfo friendinfo = new FriendInfo();
           string FullName= friendinfo.GetFullName(friend,skype);
           string DispName = friendinfo.GetDispname(friend, skype);
           string Birdth = friendinfo.GetBirthday(friend, skype);
           string Country = friendinfo.GetCountry(friend, skype);
           string City = friendinfo.GetCity(friend, skype);
           string Online = friendinfo.GetLastVisit(friend, skype);
          if (FullName==null)
            label1.Text += "Имя: "+DispName+"\n\r";
          else
              label1.Text += "Имя: " + FullName + "\n\r";

          label1.Text += "Дата Рождения: " + Birdth + "\n\r";
          label1.Text += "Страна: " + Country + "\n\r";
          label1.Text += "Имя: " +City +"\n\r";
          label1.Text += "Последний раз заходил: " + Online + "\n\r";
               
        }
        
    }
}
