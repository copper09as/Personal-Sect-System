namespace SectSystem
{
    partial class ChangeSectForm
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.sectPreName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.leaderName = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tution = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.responTxt = new System.Windows.Forms.ListBox();
            this.sectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sectGroup
            // 
            this.sectGroup.Controls.Add(this.confirmBtn);
            this.sectGroup.Controls.Add(this.sectPreName);
            this.sectGroup.Controls.Add(this.label4);
            this.sectGroup.Controls.Add(this.leaderName);
            this.sectGroup.Controls.Add(this.years);
            this.sectGroup.Controls.Add(this.label5);
            this.sectGroup.Controls.Add(this.tution);
            this.sectGroup.Controls.Add(this.label3);
            this.sectGroup.Controls.Add(this.responTxt);
            this.sectGroup.Controls.Add(this.sectName);
            this.sectGroup.Controls.Add(this.label2);
            this.sectGroup.Controls.Add(this.label1);
            this.sectGroup.Location = new System.Drawing.Point(122, 47);
            this.sectGroup.Name = "sectGroup";
            this.sectGroup.Size = new System.Drawing.Size(530, 333);
            this.sectGroup.TabIndex = 1;
            this.sectGroup.TabStop = false;
            this.sectGroup.Text = "宗派信息";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(351, 240);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 23);
            this.confirmBtn.TabIndex = 19;
            this.confirmBtn.Text = "确认更改";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // sectPreName
            // 
            this.sectPreName.AutoSize = true;
            this.sectPreName.Location = new System.Drawing.Point(59, 58);
            this.sectPreName.Name = "sectPreName";
            this.sectPreName.Size = new System.Drawing.Size(52, 15);
            this.sectPreName.TabIndex = 18;
            this.sectPreName.Text = "原名字";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "宗主姓名";
            // 
            // leaderName
            // 
            this.leaderName.Location = new System.Drawing.Point(351, 68);
            this.leaderName.Name = "leaderName";
            this.leaderName.Size = new System.Drawing.Size(100, 25);
            this.leaderName.TabIndex = 17;
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(176, 68);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(100, 25);
            this.years.TabIndex = 15;
            this.years.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.years_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 39);
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
            this.tution.Location = new System.Drawing.Point(163, 141);
            this.tution.Name = "tution";
            this.tution.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tution.Size = new System.Drawing.Size(140, 154);
            this.tution.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 115);
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
            this.responTxt.Location = new System.Drawing.Point(44, 141);
            this.responTxt.Name = "responTxt";
            this.responTxt.Size = new System.Drawing.Size(104, 154);
            this.responTxt.TabIndex = 5;
            // 
            // sectName
            // 
            this.sectName.Location = new System.Drawing.Point(351, 170);
            this.sectName.Name = "sectName";
            this.sectName.Size = new System.Drawing.Size(100, 25);
            this.sectName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "宗派职责";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "宗派名字";
            // 
            // ChangeSectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sectGroup);
            this.Name = "ChangeSectForm";
            this.Text = "修改数据";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeSectForm_FormClosing);
            this.Load += new System.EventHandler(this.ChangeSectForm_Load);
            this.sectGroup.ResumeLayout(false);
            this.sectGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sectGroup;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox tution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox responTxt;
        private System.Windows.Forms.TextBox sectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leaderName;
        private System.Windows.Forms.Label sectPreName;
        private System.Windows.Forms.Button confirmBtn;
    }
}