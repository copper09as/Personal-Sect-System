namespace SectSystem
{
    partial class RegisterUi
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
            this.ConfirmBox = new System.Windows.Forms.TextBox();
            this.ConfitmPasTxt = new System.Windows.Forms.Label();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.AccountTxt = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConfirmBox
            // 
            this.ConfirmBox.Location = new System.Drawing.Point(142, 153);
            this.ConfirmBox.Name = "ConfirmBox";
            this.ConfirmBox.Size = new System.Drawing.Size(223, 25);
            this.ConfirmBox.TabIndex = 10;
            this.ConfirmBox.UseSystemPasswordChar = true;
            // 
            // ConfitmPasTxt
            // 
            this.ConfitmPasTxt.AutoSize = true;
            this.ConfitmPasTxt.Location = new System.Drawing.Point(69, 156);
            this.ConfitmPasTxt.Name = "ConfitmPasTxt";
            this.ConfitmPasTxt.Size = new System.Drawing.Size(67, 15);
            this.ConfitmPasTxt.TabIndex = 11;
            this.ConfitmPasTxt.Text = "确认密码";
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(142, 50);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(223, 25);
            this.AccountBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(142, 102);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(223, 25);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // AccountTxt
            // 
            this.AccountTxt.AutoSize = true;
            this.AccountTxt.Location = new System.Drawing.Point(99, 53);
            this.AccountTxt.Name = "AccountTxt";
            this.AccountTxt.Size = new System.Drawing.Size(37, 15);
            this.AccountTxt.TabIndex = 7;
            this.AccountTxt.Text = "账号";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.AutoSize = true;
            this.PasswordTxt.Location = new System.Drawing.Point(99, 105);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(37, 15);
            this.PasswordTxt.TabIndex = 8;
            this.PasswordTxt.Text = "密码";
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(195, 201);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(75, 23);
            this.RegBtn.TabIndex = 9;
            this.RegBtn.Text = "注册";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // RegisterUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 247);
            this.Controls.Add(this.ConfitmPasTxt);
            this.Controls.Add(this.ConfirmBox);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.AccountTxt);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.AccountBox);
            this.Name = "RegisterUi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterUi_FormClosing);
            this.Load += new System.EventHandler(this.RegisterUi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConfirmBox;
        private System.Windows.Forms.Label ConfitmPasTxt;
        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label AccountTxt;
        private System.Windows.Forms.Label PasswordTxt;
        private System.Windows.Forms.Button RegBtn;
    }
}