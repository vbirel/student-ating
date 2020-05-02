namespace rating
{
    partial class LogWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.TextBox();
            this.passord = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.masedg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(12, 64);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(228, 20);
            this.login.TabIndex = 0;
            // 
            // passord
            // 
            this.passord.Location = new System.Drawing.Point(12, 128);
            this.passord.Name = "passord";
            this.passord.Size = new System.Drawing.Size(228, 20);
            this.passord.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(73, 174);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(104, 29);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "Войти";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // masedg
            // 
            this.masedg.AutoSize = true;
            this.masedg.ForeColor = System.Drawing.Color.Red;
            this.masedg.Location = new System.Drawing.Point(12, 96);
            this.masedg.Name = "masedg";
            this.masedg.Size = new System.Drawing.Size(35, 13);
            this.masedg.TabIndex = 3;
            this.masedg.Text = "label1";
            this.masedg.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "пароль";
            // 
            // LogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 242);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masedg);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.passord);
            this.Controls.Add(this.login);
            this.Name = "LogWindow";
            this.Text = "login";
            this.Load += new System.EventHandler(this.LogWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox passord;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label masedg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

