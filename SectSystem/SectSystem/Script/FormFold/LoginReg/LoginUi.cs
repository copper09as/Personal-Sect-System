using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SectSystem.Main;

namespace SectSystem
{
    public partial class Login : Form
    {
        private SynchronizationContext _uiContext;
        public Login()
        {
            InitializeComponent();
            NetManager.AddMsgListener("MsgLogin", OnMsgLogin);
            _uiContext = SynchronizationContext.Current; // 保存UI线程上下文
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MsgLogin msgLogin = new MsgLogin()
            {
                id = AccountBox.Text,
                pw = PasswordBox.Text
            };
            NetManager.Send(msgLogin);
            /*if (DbManager.CheckPassword(AccountBox.Text, PasswordBox.Text))
            {
                MessageBox.Show("登录成功");
                this.Hide();
                InitSectSystem sect = new InitSectSystem();
                sect.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }*/

        }
        private void OnMsgLogin(MsgBase msgBase)
        {
            // 确保在 UI 线程上执行

            MsgLogin msg = (MsgLogin)msgBase;
            if (msg.result == 0)
            {
                MessageBox.Show("登录成功");
                this.Hide();
                InitSectSystem sect = new InitSectSystem();
                sect.Show();
            }
            else
            {
                MessageBox.Show("账号或密码错误");
            }
        }
        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (RegisterUi.isOpen)
                return;
            RegisterUi reg = new RegisterUi();
            reg.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents(); 

           NetManager.Update();
        }
    }
}
