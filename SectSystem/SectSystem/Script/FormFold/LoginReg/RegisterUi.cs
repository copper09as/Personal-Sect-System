using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SectSystem
{
    public partial class RegisterUi : Form
    {
        public static bool isOpen;

        //MsgRegister
        public RegisterUi()
        {
            InitializeComponent();
            isOpen = true;
        }
        
        private void RegBtn_Click(object sender, EventArgs e)
        {

            if (AccountBox.Text == "")
            {
                MessageBox.Show("账号不能为空");
                return;
            }
            if (PasswordBox.Text == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }
            if (ConfirmBox.Text != PasswordBox.Text)
            {
                MessageBox.Show("两次密码不同");
                return;
            }
            MsgRegister msgRegister = new MsgRegister()
            {
                id = AccountBox.Text,
                pw = PasswordBox.Text
            };
            NetManager.Send(msgRegister);

        }

        private void RegisterUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            NetManager.RemoveListenear(StringResource.msgRegister, OnMsgRegister);
            isOpen = false;
        }
        private void OnMsgRegister(MsgBase msgBase)
        {
            MsgRegister msg = (MsgRegister)msgBase;
            if(msg.result ==  0)
            {
                MessageBox.Show("注册成功");
                Close();
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }
        private void RegisterUi_Load(object sender, EventArgs e)
        {
            isOpen = true;
            NetManager.AddMsgListener(StringResource.msgRegister, OnMsgRegister);
        }


    }
}
