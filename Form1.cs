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

namespace kursovaya
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted

    }

    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("den_nedeli", "День недели");
            dataGridView1.Columns.Add("nomer_kabineta", "Номер кабинета");
            dataGridView1.Columns.Add("nazvanie_klassa", "Название класса");
            dataGridView1.Columns.Add("nazvanie_uroka", "Название урока");
            dataGridView1.Columns.Add("uchitel", "Учитель");
            dataGridView1.Columns.Add("nomer_uroka", "Номер урока");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = $"select * from raspisaniee";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                id.Text = row.Cells[0].Value.ToString();
                den.Text = row.Cells[1].Value.ToString();
                nomerk.Text = row.Cells[2].Value.ToString();
                nazvkl.Text = row.Cells[3].Value.ToString();
                nazvur.Text = row.Cells[4].Value.ToString();
                uchitel.Text = row.Cells[5].Value.ToString();
                nomerur.Text = row.Cells[6].Value.ToString();
            }
        }

        private void newzap_Click(object sender, EventArgs e)
        {
            dobavlenie dobav = new dobavlenie();
            dobav.Show();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }



        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from raspisaniee where concat (id, den_nedeli, nomer_kabineta, nazvanie_klassa, nazvanie_uroka, uchitel, nomer_uroka) like '%" + pois.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();
        }

        private void pois_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty )
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;

                return;
            }

    
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;


        }



        private void Update()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuary = $"delete from raspisaniee where id = {id}";

                    var command = new SqlCommand(deleteQuary, dataBase.getConnection());
                    command.ExecuteNonQuery();

                }

                if (rowState == RowState.Modified)
                {
                    var ID = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var dennedeli = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var nomerkabineta = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var nazvanieklassa = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var nazvanieuroka = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var uchiteli = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var nomeruroka = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"update raspisaniee set den_nedeli = '{dennedeli}', nomer_kabineta = '{nomerkabineta}', nazvanie_klassa = '{nazvanieklassa}', nazvanie_uroka = '{nazvanieuroka}', uchitel = '{uchiteli}', nomer_uroka = '{nomeruroka}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();

        }

        private void udalenie_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void soxranit_Click(object sender, EventArgs e)
        {
            Update();
        }


        private void Change()
        {
            var SelectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var ID = id.Text;
            var dennedeli = den.Text;
            var nomerkabineta = nomerk.Text;
            var nazvanieklassa = nazvkl.Text;
            var nazvanieuroka = nazvur.Text;
            var uchiteli = uchitel.Text;
            int nomeruroka;

            if (dataGridView1.Rows[SelectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(nomerur.Text, out nomeruroka))
                {
                    dataGridView1.Rows[SelectedRowIndex].SetValues(ID, dennedeli, nomerkabineta, nazvanieklassa, nazvanieuroka, uchiteli, nomeruroka);
                    dataGridView1.Rows[SelectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер должен быть целым числом!");
                }
            }

        }
        private void izmenit_Click(object sender, EventArgs e)
        {
            Change();
        }
    }
}
