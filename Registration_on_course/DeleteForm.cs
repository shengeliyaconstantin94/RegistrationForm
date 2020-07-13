using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_on_course
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Пользователь\Desktop\Registration_on_course\Registration_on_course\Students_profile.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand deletecomand = new SqlCommand("delete from Stud where student_id ='" + int.Parse(textBox1.Text) + "' AND student_lastname = '"+textBox2.Text+"'",connection);
            deletecomand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись удалена");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Visible = true;
           label2.Visible = true;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
