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
    public partial class dobavlenie : Form
    {
        DataBase dataBase = new DataBase();

        public dobavlenie()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void dobav_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var dni = textBox1.Text;
            var nomerkabineta = textBox2.Text;
            var nazvanieklassa = textBox3.Text;
            var nazvanieuroka = textBox4.Text;
            var uchitel = textBox5.Text;
            int nomeruroka;

            if (int.TryParse(textBox6.Text, out nomeruroka))
            {
                var addQuery = $"insert into raspisaniee (den_nedeli, nomer_kabineta, nazvanie_klassa, nazvanie_uroka, uchitel, nomer_uroka) values ('{dni}', '{nomerkabineta}','{nazvanieklassa}','{nazvanieuroka}','{uchitel}','{nomeruroka}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно добавлена!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись должна иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataBase.closeConnection();
        }
    }
}
