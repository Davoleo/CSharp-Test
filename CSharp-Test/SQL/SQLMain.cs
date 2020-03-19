using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharp_Test.SQL
{
    public partial class SQLMain : Form
    {
        public SQLMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Everything\Coding\lang-projects\C#\CSharp-Test\CSharp-Test\DataTest.mdf;Integrated Security=True"
            );
            connection.Open();

            MessageBox.Show("Connection Established");

            SqlCommand command = new SqlCommand($"INSERT INTO OS (nameOS, year, averageLicenseCost) VALUES ('{txbOS.Text}', '{dtpReleaseYear.Value.Year}', '{txbPrice.Text.Replace(',', '.')}')", connection);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Connection Terminated");
        }
    }
}
