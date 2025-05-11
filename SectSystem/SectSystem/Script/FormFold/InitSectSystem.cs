using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SectSystem.Data;

namespace SectSystem.Main
{
    public partial class InitSectSystem : Form
    {
        public InitSectSystem()
        {
            InitializeComponent();
        }

        private void InitSectSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (AddSectForm.isOpen)
                return;
            AddSectForm addSect = new AddSectForm();
            addSect.MdiParent = this;
            addSect.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ViewSectForm.isOpen)
                return;
            ViewSectForm viewSect = new ViewSectForm();
            viewSect.MdiParent = this;
            viewSect.Show();
        }
    }
}
