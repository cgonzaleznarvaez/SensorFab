using MySql.Data.MySqlClient;
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

namespace WindowsFormsApplication2
{
    public partial class AddModel : Form
    {
        DBConnect database;

        public AddModel(DBConnect db)
        {
            InitializeComponent();
            database = db;
            fill();
        }


        private void acceptBtn_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO model VALUES('" + modelTxt.Text.ToString() + "', '" + descriptionTxt.Text + "', '" + familyComboBox.Text + "', '" +
                subDiaComboBox.Text + "', '" + subSubComboBox.Text + "', '" + primeSubComboBox.Text + "', '" + primeDiaComboBox.Text + "')";
            database.insert(query);

            query = "INSERT INTO compound VALUES('" + modelTxt.Text.ToString() + "', '" + goldBackComboBox.Text + "', '" + goldFrontComboBox.Text + "', '" +
                glassComboBox.Text + "', '" + pinkGlassComboBox.Text + "', '" + conductorComboBox.Text + "', '" + fritComboBox.Text + "')";
            database.insert(query);
            this.Close();
        }

        private void fill()
        {
            database.openConnection();

            writeComboBox(pinkGlassComboBox, "pg_id", "pink_glass");
            writeComboBox(glassComboBox, "g_id", "glass");
            writeComboBox(goldFrontComboBox, "gf_id", "gold_front");
            writeComboBox(goldBackComboBox, "gb_id", "gold_back");
            writeComboBox(primeDiaComboBox, "pmd_id", "prime_matter_diaf");
            writeComboBox(primeSubComboBox, "pms_id", "prime_matter_sub");
            writeComboBox(subDiaComboBox, "sd_id", "sub_diafragm");
            writeComboBox(subSubComboBox, "ss_id", "sub_substrate");
            writeComboBox(familyComboBox, "family_name", "family");
            writeComboBox(conductorComboBox, "c_id", "conductor");
            writeComboBox(fritComboBox, "f_id", "frit");

            
            database.closeConnection();
        }

        private void writeComboBox(ComboBox comboBox, String field, String datab)
        {
            String query = "SELECT " + field + " FROM " + datab;
            MySqlCommand sc = new MySqlCommand(query, database.connection);
            MySqlDataReader reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(field, typeof(string));
                dt.Load(reader);
                comboBox.ValueMember = field;
                comboBox.DisplayMember = field;
                comboBox.DataSource = dt;
            }
            reader.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
