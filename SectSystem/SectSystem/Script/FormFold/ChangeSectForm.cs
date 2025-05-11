using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SectSystem.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SectSystem
{
    public partial class ChangeSectForm : Form
    {
        private string id;
        public static bool isOpen;
        public ChangeSectForm(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (sectName.Text == "")
            {
                MessageBox.Show("宗教名字不得为空");
                return;
            }
            if (int.TryParse(years.Text, out int yearNum))
            {
                if (yearNum < 0)
                {
                    MessageBox.Show("学年不得小于0");
                    return;
                }
            }
            else
            {
                MessageBox.Show("学年需为正整数");
                return;
            }
            if (responTxt.Text == "")
            {
                MessageBox.Show("宗派职责未选择");
                return;
            }
            if (tution.Text == "")
            {
                MessageBox.Show("宗派主修课程未选择");
                return;
            }
            if (leaderName.Text == "")
            {
                MessageBox.Show("宗主名字不得为空");
                return;
            }
            DialogResult result = MessageBox.Show(
                "是否修改门派信息！",
                "Warning",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.OK)
            {
                MessageBox.Show("修改已取消。", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<string> tutionsList = new List<string>();
            foreach (var item in tution.SelectedItems)
            {
                tutionsList.Add(item.ToString());
            }
            string tutionsJson = JsonConvert.SerializeObject(tutionsList);
            SectData sect = new SectData
            {
                Id = int.Parse(id),
                Name = sectName.Text,
                Responsibility = responTxt.Text,
                LeaderName = leaderName.Text,
                Tutions = tutionsJson,
                Years = yearNum
            };
            if(DbManager.UpdateData(StringResource.UpdateSectDataSql(sect)))
            {
                MessageBox.Show("修改数据成功");
                EventCenter.Instance.Trigger(StringResource.updateFromDataBase);
            }
        }

        private void ChangeSectForm_Load(object sender, EventArgs e)
        {
            isOpen = true;
        }

        private void ChangeSectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isOpen = false;
        }
    }
}
