using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharp_Test.SQL
{
    public partial class SQLMain : Form
    {

        public static readonly SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Everything\Coding\lang-projects\C#\CSharp-Test\CSharp-Test\DataTest.mdf;Integrated Security=True"
            );

        List<int> places = new List<int>();

        public SQLMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            MessageBox.Show("Connection Established");

            SqlCommand command = new SqlCommand("INSERT INTO OS (nameOS, year, averageLicenseCost, nextConventionPlace) " +
                                                $"VALUES ('{txbOS.Text}', '{dtpReleaseYear.Value.Year}', '{txbPrice.Text.Replace(',', '.')}', '{places[comboPlaces.SelectedIndex]}')", connection);
            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Connection Terminated");
        }

        private void SQLMain_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlDataReader reader;
            SqlCommand command = new SqlCommand("SELECT * FROM Places ORDER BY name", connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                ComboData data = new ComboData((string) reader["name"], (int) reader["idPlace"]);
                comboPlaces.Items.Add(data);
            }
                
            comboPlaces.SelectedIndex = 0;
            connection.Close();
        }

        private void comboPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((comboPlaces.Items[comboPlaces.SelectedIndex] as ComboData).ID + " is the currently Selected Place");
        }
    }
}
