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
    public partial class AddPrimeMatter : Form
    {
        DBConnect database;

        public AddPrimeMatter(DBConnect db)
        {
            InitializeComponent();
            database = db;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            String primeMatter = primeMatterTxt.Text.ToString();
            if (substrateRadBtn.Checked)
            {
                //prime_matter_sub
                String query = "INSERT INTO prime_matter_sub VALUES ('" + primeMatter + "');";
                database.insert(query);
            }
            else
            {
                //prime_matter_diaf
                if (diafragmRadBtn.Checked)
                {
                    String query = "INSERT INTO prime_matter_diaf VALUES ('" + primeMatter + "');";
                    database.insert(query);
                }
                //none
                else
                    MessageBox.Show("Selecciona un tipo de materia prima");
            }

            this.Close();
        }
    }
}
