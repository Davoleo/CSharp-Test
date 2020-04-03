using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharp_Test.SQL
{
    public partial class SqlMain : Form
    {

        private static readonly SqlConnection Connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Everything\Coding\lang-projects\C#\CSharp-Test\CSharp-Test\DataTest.mdf;Integrated Security=True"
            );

        private readonly DataTable placesTable = new DataTable();

        public SqlMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.Open();

            MessageBox.Show("Connection Established");

            SqlCommand command = new SqlCommand("INSERT INTO OS (nameOS, year, averageLicenseCost, nextConventionPlace) " +
                                                $"VALUES ('{txbOS.Text}', '{dtpReleaseYear.Value.Year}', '{txbPrice.Text.Replace(',', '.')}', '{comboPlaces.SelectedValue}')", Connection);
            command.ExecuteNonQuery();

            Connection.Close();

            MessageBox.Show("Connection Terminated");
        }

        private void SQLMain_Load(object sender, EventArgs e)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Places ORDER BY name", Connection);

            SqlDataReader reader = command.ExecuteReader();

            placesTable.Load(reader);

            comboPlaces.DataSource = placesTable;
            comboPlaces.DisplayMember = "name";
            comboPlaces.ValueMember = "idPlace";
            comboPlaces.SelectedIndex = 0;

            Connection.Close();
        }

        private void comboPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboPlaces.SelectedValue + " is the current Selected Place");
        }
    }
}
