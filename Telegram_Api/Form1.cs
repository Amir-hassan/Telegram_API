using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLSharp.Core;
using Ionic.Zlib;


namespace Telegram_Api
{
    public partial class Form1 : Form
    {

        public TelegramClient client;
        public string hash;
        Int32 ApiId;
        string ApiHash ;
        string Phone_Number ;

        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            /*
              1) go to https://my.telegram.org/
              2) Creat ApiId and ApiHash code
            */
             ApiId = 0;
             ApiHash = "";
             Phone_Number = ""; //+98**********

            var store = new FileSessionStore();
            client = new TelegramClient(store, "session", ApiId, ApiHash);
            await client.Connect();

            if (!client.IsUserAuthorized())
            {

                hash = await client.SendCodeRequest(Phone_Number);
                panel_HashCode.Visible = true;
             }
            else
            {
                panel_HashCode.Visible = false;
            }
        }

        private async void Btn_Message_Click(object sender, EventArgs e)
        {
            // send msg:
            //var userByPhoneId = await client.ImportContactByPhoneNumber("+98**********");
            var userByUN = await client.ImportByUserName(Txt_send.Text);
                           await client.SendMessage(Convert.ToInt32(userByUN), txt_message_body.Text);
            txt_message_body.Text = string.Empty;
        }

        private async void btn_Hash_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await client.MakeAuth(Phone_Number, hash, Txt_HashCode.Text);
                if (user == null)
                {
                     MessageBox.Show("Error in Authenticate.", "Error",MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
