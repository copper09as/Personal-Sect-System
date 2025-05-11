namespace SectSystem
{
    partial class AddSectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sectGroup = new System.Windows.Forms.GroupBox();
            this.years = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tution = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.responTxt = new System.Windows.Forms.ListBox();
            this.sectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leaderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.resertBtn = new System.Windows.Forms.Button();
            this.leaderGroup = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.weaponTxt = new System.Windows.Forms.RichTextBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.cultivationBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ractionListBox = new System.Windows.Forms.ListBox();
            this.oldBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sectGroup.SuspendLayout();
            this.leaderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectGroup
            // 
            this.sectGroup.Controls.Add(this.years);
            this.sectGroup.Controls.Add(this.label5);
            this.sectGroup.Controls.Add(this.tution);
            this.sectGroup.Controls.Add(this.label3);
            this.sectGroup.Controls.Add(this.responTxt);
            this.sectGroup.Controls.Add(this.sectName);
            this.sectGroup.Controls.Add(this.label2);
            this.sectGroup.Controls.Add(this.label1);
            this.sectGroup.Location = new System.Drawing.Point(59, 48);
            this.sectGroup.Name = "sectGroup";
            this.sectGroup.Size = new System.Drawing.Size(284, 333);
            this.sectGroup.TabIndex = 0;
            this.sectGroup.TabStop = false;
            this.sectGroup.Text = "宗派信息";
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(138, 71);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(100, 25);
            this.years.TabIndex = 15;
            this.years.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.years_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "修行学年";
            // 
            // tution
            // 
            this.tution.FormattingEnabled = true;
            this.tution.ItemHeight = 15;
            this.tution.Items.AddRange(new object[] {
            "《九转锻器诀》",
            "《灵纹铭刻术》",
            "《五行炼丹要术》",
            "《活丹辨微》",
            "《剑气通玄录》",
            "《剑阵图录》",
            "《八荒刀魄经》",
            "《杀伐刀道》",
            "《焚天诀》",
            "《爆炎符箓学》",
            "《元素本质论》",
            "《禁咒语言学》",
            "《幻真秘典》",
            "《戏法战斗学》",
            "《灵力机械学》",
            "《跨界通讯术》",
            "《九转金身诀》",
            "《近战格斗学》",
            "《破魔枪道》",
            "《枪斗术》",
            "《本命蛊培育》",
            "《咒杀术》",
            "《阴阳合欢大法》",
            "《千幻魅影诀》",
            "《情丝绕》",
            "《欢喜禅》"});
            this.tution.Location = new System.Drawing.Point(125, 144);
            this.tution.Name = "tution";
            this.tution.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tution.Size = new System.Drawing.Size(140, 154);
            this.tution.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "宗派主修课程";
            // 
            // responTxt
            // 
            this.responTxt.FormattingEnabled = true;
            this.responTxt.ItemHeight = 15;
            this.responTxt.Items.AddRange(new object[] {
            "诛邪卫道",
            "法器管制",
            "推演劫数",
            "典籍守护",
            "祛瘟除瘴",
            "魂归天道",
            "天象调控",
            "姻缘天定",
            "红尘渡厄",
            "阴阳调和",
            "欲念监察"});
            this.responTxt.Location = new System.Drawing.Point(6, 144);
            this.responTxt.Name = "responTxt";
            this.responTxt.Size = new System.Drawing.Size(104, 154);
            this.responTxt.TabIndex = 5;
            // 
            // sectName
            // 
            this.sectName.Location = new System.Drawing.Point(6, 71);
            this.sectName.Name = "sectName";
            this.sectName.Size = new System.Drawing.Size(100, 25);
            this.sectName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "宗派职责";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宗派名字";
            // 
            // leaderName
            // 
            this.leaderName.Location = new System.Drawing.Point(15, 71);
            this.leaderName.Name = "leaderName";
            this.leaderName.Size = new System.Drawing.Size(100, 25);
            this.leaderName.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "宗主姓名";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(140, 403);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "添加";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // resertBtn
            // 
            this.resertBtn.Location = new System.Drawing.Point(515, 403);
            this.resertBtn.Name = "resertBtn";
            this.resertBtn.Size = new System.Drawing.Size(75, 23);
            this.resertBtn.TabIndex = 2;
            this.resertBtn.Text = "重置";
            this.resertBtn.UseVisualStyleBackColor = true;
            this.resertBtn.Click += new System.EventHandler(this.resertBtn_Click);
            // 
            // leaderGroup
            // 
            this.leaderGroup.Controls.Add(this.label9);
            this.leaderGroup.Controls.Add(this.weaponTxt);
            this.leaderGroup.Controls.Add(this.female);
            this.leaderGroup.Controls.Add(this.male);
            this.leaderGroup.Controls.Add(this.cultivationBox);
            this.leaderGroup.Controls.Add(this.label8);
            this.leaderGroup.Controls.Add(this.ractionListBox);
            this.leaderGroup.Controls.Add(this.oldBox);
            this.leaderGroup.Controls.Add(this.label7);
            this.leaderGroup.Controls.Add(this.label4);
            this.leaderGroup.Controls.Add(this.label6);
            this.leaderGroup.Controls.Add(this.leaderName);
            this.leaderGroup.Location = new System.Drawing.Point(402, 48);
            this.leaderGroup.Name = "leaderGroup";
            this.leaderGroup.Size = new System.Drawing.Size(284, 333);
            this.leaderGroup.TabIndex = 16;
            this.leaderGroup.TabStop = false;
            this.leaderGroup.Text = "宗主信息";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "常用兵器";
            // 
            // weaponTxt
            // 
            this.weaponTxt.Location = new System.Drawing.Point(151, 263);
            this.weaponTxt.Name = "weaponTxt";
            this.weaponTxt.Size = new System.Drawing.Size(100, 35);
            this.weaponTxt.TabIndex = 22;
            this.weaponTxt.Text = "无";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(72, 279);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(43, 19);
            this.female.TabIndex = 21;
            this.female.TabStop = true;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(15, 279);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(43, 19);
            this.male.TabIndex = 20;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // cultivationBox
            // 
            this.cultivationBox.FormattingEnabled = true;
            this.cultivationBox.ItemHeight = 15;
            this.cultivationBox.Items.AddRange(new object[] {
            "凡阶",
            "练气",
            "筑基",
            "金丹",
            "元婴",
            "化神",
            "合体",
            "渡劫",
            "大乘"});
            this.cultivationBox.Location = new System.Drawing.Point(165, 151);
            this.cultivationBox.Name = "cultivationBox";
            this.cultivationBox.Size = new System.Drawing.Size(64, 79);
            this.cultivationBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "修为";
            // 
            // ractionListBox
            // 
            this.ractionListBox.FormattingEnabled = true;
            this.ractionListBox.ItemHeight = 15;
            this.ractionListBox.Items.AddRange(new object[] {
            "妖",
            "人",
            "灵",
            "仙",
            "鬼",
            "魔",
            "巫",
            "星"});
            this.ractionListBox.Location = new System.Drawing.Point(33, 151);
            this.ractionListBox.Name = "ractionListBox";
            this.ractionListBox.Size = new System.Drawing.Size(64, 79);
            this.ractionListBox.TabIndex = 17;
            // 
            // oldBox
            // 
            this.oldBox.Location = new System.Drawing.Point(151, 71);
            this.oldBox.Name = "oldBox";
            this.oldBox.Size = new System.Drawing.Size(100, 25);
            this.oldBox.TabIndex = 17;
            this.oldBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oldBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "种族";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "年龄";
            // 
            // AddSectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leaderGroup);
            this.Controls.Add(this.resertBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.sectGroup);
            this.Name = "AddSectForm";
            this.Text = "宗派管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSectForm_FormClosing);
            this.Load += new System.EventHandler(this.AddSectForm_Load);
            this.sectGroup.ResumeLayout(false);
            this.sectGroup.PerformLayout();
            this.leaderGroup.ResumeLayout(false);
            this.leaderGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sectGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox responTxt;
        private System.Windows.Forms.TextBox sectName;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ListBox tution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox leaderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resertBtn;
        private System.Windows.Forms.GroupBox leaderGroup;
        private System.Windows.Forms.TextBox oldBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ractionListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.ListBox cultivationBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox weaponTxt;
        private System.Windows.Forms.RadioButton female;
    }
}