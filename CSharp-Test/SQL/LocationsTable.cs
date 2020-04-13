using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp_Test.SQL
{
    public partial class LocationsTable : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Everything\Coding\lang-projects\C#\CSharp-Test\CSharp-Test\DataTest.mdf;Integrated Security=True");
        private DataTable tablePlaces = new DataTable();
        private bool saved = false;

        private void LoadData()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Places ORDER BY name", connection);
            
            SqlDataReader reader = command.ExecuteReader();

            tablePlaces.Clear();
            tablePlaces.Load(reader);

            dataGridPlaces.DataSource = tablePlaces;

            connection.Close();
            //Hide the ID Columns
            dataGridPlaces.Columns[0].Visible = false;

        }

        private void UpdateData()
        {
            connection.Open();

            SqlCommand command = new SqlCommand("", connection);

            foreach (DataGridViewRow row in dataGridPlaces.Rows)
            {
                if (row.Cells[0].Style.ForeColor == Color.DarkOrange)
                {
                    command.CommandText = $"UPDATE Places SET name = '{row.Cells["name"].Value}' WHERE idPlace = '{row.Cells["idPlace"].Value}'";
                    command.ExecuteNonQuery();
                } 
                else if (row.Cells[0].Style.ForeColor == Color.LimeGreen)
                {
                    command.CommandText = $"INSERT INTO Places (name) VALUES ('{row.Cells["name"].Value}')";
                    command.ExecuteNonQuery();
                }
            }

            connection.Close();
        }

        public LocationsTable()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            UpdateData();
            saved = true;
            MessageBox.Show("Database was updated", "SQL Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void dataGridPlaces_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridPlaces.Rows[e.RowIndex].Cells)
                if (cell.Style.ForeColor != Color.LimeGreen)
                    cell.Style.ForeColor = Color.DarkOrange;
        }

        private void dataGridPlaces_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridPlaces.Rows[e.RowIndex].IsNewRow)
            {
                foreach (DataGridViewCell cell in dataGridPlaces.Rows[e.RowIndex].Cells)
                    cell.Style.ForeColor = Color.LimeGreen;
            }
        }
        private void dataGridPlaces_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result =
                MessageBox.Show($"You're about to delete {e.Row.Cells["name"].Value}. Are you sure?",
                    "Confirm Delete Request", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                connection.Open();

                SqlCommand command = new SqlCommand("", connection);
                command.CommandText = $"DELETE FROM Places WHERE idPlace='{e.Row.Cells["idPlace"].Value}'";
                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        //Warn the user that data won't be saved
        private void LocationsTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to leave without saving the data and updating the Database?", 
                    "SQL Table", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void txbFilter_TextChanged(object sender, System.EventArgs e)
        {
            LoadData();
            tablePlaces.DefaultView.RowFilter = $"name LIKE '%{txbFilter.Text}%'";
        }
    }
}
