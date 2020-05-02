using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rating
{
    public partial class LogWindow : Form
    {
       

        public LogWindow()
        {
            InitializeComponent();
        }

        private void LogWindow_Load(object sender, EventArgs e)//загрузка окна входа
        {
            login.Clear();
            passord.Clear();
            login.Focus();
        }
        public static int rull;//обевил как глобальную
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(this.login.Text==null)
            {
                this.masedg.Text = "Введите имя пользовател";
                this.masedg.Visible = true;
            }

            Main main = new Main();
           
            main.Show();
            main.Visible = false;
            for(int i=0; i < main.dataLogin.Rows.Count; i++)
            {
                if(this.login.Text==(string)main.dataLogin.Rows[i].Cells[0].Value)
                {
                    if(this.passord.Text==(string)main.dataLogin.Rows[i].Cells[1].Value)
                    {
                        
                        rull = (int)main.dataLogin.Rows[i].Cells[2].Value;//присвоел значение
                        this.Visible = false;
                        main.Visible = true;
                        return;
                    }
                }
            }
            

            this.masedg.Text = "Неверное имя пользователя или пароль";
            this.masedg.Visible = true;
        }
    }
}
