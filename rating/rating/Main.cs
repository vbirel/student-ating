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
    public partial class Main : Form
    {
       public LogWindow logWindow = new LogWindow();//создал переменую класса для того чтобы вызвать ту переменую
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рейтинг_студентовDataSet3.Rating". При необходимости она может быть перемещена или удалена.
            this.ratingTableAdapter.Fill(this.рейтинг_студентовDataSet3.Rating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "рейтинг_студентовDataSet2.Personal_Information". При необходимости она может быть перемещена или удалена.
            this.personal_InformationTableAdapter.Fill(this.рейтинг_студентовDataSet2.Personal_Information);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teacherDate.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.teacherDate.Teachers);              
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loginDait.login". При необходимости она может быть перемещена или удалена.
            this.loginTableAdapter.Fill(this.loginDait.login);
           
            

        }

        public void Main_VisibleChanged(object sender, EventArgs e)
        {
            if (logWindow.rull > 2)//почемуто всегда 0
            {
                tabControl.TabPages.Remove(tabPage1);
            }
        }
    }
}
