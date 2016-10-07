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

        private void AddModel_Load(object sender, EventArgs e)
        {
            
        }
        private void fill()
        {
            database.openConnection();
            String query;
            MySqlDataReader reader;
            MySqlCommand sc;
            DataTable dt = new DataTable();

            /*
            "glass", "pink_glass", "conductor", "frit" };
            "g_id", "pg_id", "c_id", "f_id"};
            */

            //Glass
            query = "SELECT g_id FROM glass";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("g_id", typeof(string));
                dt.Load(reader);

                goldFrontComboBox.ValueMember = "g_id";
                goldFrontComboBox.DisplayMember = "g_id";
                goldFrontComboBox.DataSource = dt;
            }
            reader.Close();

            //Gold Front
            query = "SELECT gf_id FROM gold_front";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("gf_id", typeof(string));
                dt.Load(reader);

                goldFrontComboBox.ValueMember = "gf_id";
                goldFrontComboBox.DisplayMember = "gf_id";
                goldFrontComboBox.DataSource = dt;
            }
            reader.Close();

            //Gold Back
            query = "SELECT gb_id FROM gold_back";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("gb_id", typeof(string));
                dt.Load(reader);

                goldBackComboBox.ValueMember = "gb_id";
                goldBackComboBox.DisplayMember = "gb_id";
                goldBackComboBox.DataSource = dt;
            }
            reader.Close();

            //Prime Matter Diafragm
            query = "SELECT pmd_id FROM prime_matter_diaf";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("pmd_id", typeof(string));
                dt.Load(reader);

                primeDiaComboBox.ValueMember = "pmd_id";
                primeDiaComboBox.DisplayMember = "pmd_id";
                primeDiaComboBox.DataSource = dt;
            }
            reader.Close();

            //Prime Matter Substrate
            query = "SELECT pms_id FROM prime_matter_sub";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("pms_id", typeof(string));
                dt.Load(reader);

                primeSubComboBox.ValueMember = "pms_id";
                primeSubComboBox.DisplayMember = "pms_id";
                primeSubComboBox.DataSource = dt;
            }
            reader.Close();

            //Diafragm Sub
            query = "SELECT ds_id FROM diafragm_sub";
            sc =new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("ds_id", typeof(string));
                dt.Load(reader);
                familyComboBox.ValueMember = "ds_id";
                familyComboBox.DisplayMember = "ds_id";
                familyComboBox.DataSource = dt;
            }
            reader.Close();

            //Substrate Sub
            query = "SELECT ss_id FROM substrate_sub";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                //dt = new DataTable();
                dt.Columns.Add("ss_id", typeof(string));
                dt.Load(reader);
                subSubComboBox.ValueMember = "ss_id";
                subSubComboBox.DisplayMember = "ss_id";
                subSubComboBox.DataSource = dt;
            }
            reader.Close();

            //Family
            query = "SELECT family_name FROM family";
            sc = new MySqlCommand(query, database.connection);
            reader = sc.ExecuteReader();
            if (reader.HasRows) {
                dt = new DataTable();
                dt.Columns.Add("family_name", typeof(string));
                dt.Load(reader);
                familyComboBox.ValueMember = "family_name";
                familyComboBox.DisplayMember = "family_name";
                familyComboBox.DataSource = dt;
            }
            reader.Close();

            database.closeConnection();
        }
    }
}
