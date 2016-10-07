using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AddFamily : Form
    {
        DBConnect database;

        public AddFamily(DBConnect db)
        {
            InitializeComponent();
            database = db;
        }

        //Inserting a new Family*****************************************************************
        private void addBtn_Click(object sender, EventArgs e)
        {
            String family = familyTxt.Text.ToString();
            String query = "INSERT INTO family VALUES ('" + family + "');";

            database.insert(query);
        }
    }
}
