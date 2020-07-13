using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace Registration_on_course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string imglocation;
        int n = 150000;


        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Чижова\Desktop\Registration_on_course\Registration_on_course\Students_profile.mdf;Integrated Security=True");

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.students_profileDataSet);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_profileDataSet1.Teachers". При необходимости она может быть перемещена или удалена.
            this.teachersTableAdapter.Fill(this.students_profileDataSet1.Teachers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_profileDataSet1.Stud". При необходимости она может быть перемещена или удалена.
            students_profileDataSet1.EnforceConstraints = false;
            this.studTableAdapter.Fill(this.students_profileDataSet1.Stud);
     
           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "students_profileDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.students_profileDataSet.Table);

        }

        




        private void student_birthdateLabel_Click(object sender, EventArgs e)
        {

        }

        private void student_privilegesLabel_Click(object sender, EventArgs e)
        {

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand comand = connection.CreateCommand();
            comand.CommandText = "select * from Stud";
            comand.ExecuteNonQuery();
            DataTable update = new DataTable();
            SqlDataAdapter updateda = new SqlDataAdapter(comand);
            updateda.Fill(update);
            studDataGridView.DataSource = update;

            connection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog vievdialog = new OpenFileDialog();

            vievdialog.Filter = "png filles(*.png|*.png|jpg filles(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (vievdialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = vievdialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            byte[] img = null;

            FileStream Streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            img = brs.ReadBytes((int)Streem.Length);

            SqlCommand cmd = new SqlCommand();
            connection.Open();
            SqlDataAdapter ad = new SqlDataAdapter("Select student_id from Stud", connection);
            DataTable dt = new DataTable();
            ad.Fill(dt);


            if (dt.Rows.Count <= 10)
            {
                student_groupTextBox.Text = "1 группа";
            }
            else if ((dt.Rows.Count > 10 )&& (dt.Rows.Count <= 20))
            {
                student_groupTextBox.Text = "2 группа";
            }
            else  if ((dt.Rows.Count > 20) && (dt.Rows.Count <= 30))
            {
                student_groupTextBox.Text = "3 группа";
            }
            else if (dt.Rows.Count >=30)
            {
                student_groupTextBox.Text = "Запись окончена";
                
                
            }

            cmd = new SqlCommand("INSERT into Stud( student_name, student_lastname , student_birthdate,student_averagegrade,student_privileges , student_semesterprise, student_photo,student_telephone,student_group) VALUES ( N'" + student_nameTextBox.Text + "',N'" + student_lastnameTextBox.Text + "',N'" + student_birthdateDateTimePicker.Text + "',N'" + student_averagegradeTextBox.Text + "',N'" + student_privilegesComboBox.Text + "',N'" + student_semesterpriseTextBox.Text + "' ,@images,'" + maskedTextBox1.Text + "',N'" + student_groupTextBox.Text + "')", connection);
            cmd.Parameters.Add(new SqlParameter("@images", img));
            cmd.ExecuteNonQuery();

           
            connection.Close();
            MessageBox.Show("Данные о продукте успешно сохранены");
        }

        private void student_privilegesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (student_privilegesComboBox.Text == "Нет")
            {
                student_semesterpriseTextBox.Text = n.ToString();
            }
            else if (student_privilegesComboBox.Text == "Первая группа")
            {
                student_semesterpriseTextBox.Text = (n - ((n * 15) / 100)).ToString();
            }
            else if (student_privilegesComboBox.Text == "Вторая группа")
            {
                student_semesterpriseTextBox.Text = (n - ((n * 20) / 100)).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand deletecomand = new SqlCommand("DELETE FROM Stud where student_id ='" + int.Parse(textBox1.Text) + "'", connection);
            deletecomand.ExecuteScalar();
            connection.Close();
            MessageBox.Show("Запись удалена");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBox2.Visible = true;
        }
    }
    }

