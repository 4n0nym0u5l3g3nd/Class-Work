using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Connectionlab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
           
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=cse200");
            string InsertQuery="INSERT INTO cse200.student_list(Name,ID) Values(' "+nameTextBox.Text+"','"+idTextBox.Text+"')";
            DBconnect.Open();
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data is inserted");
            }
            else
            {
                MessageBox.Show("Data is not inserted");
            }
            DBconnect.Close();

        }
        
    }
}
