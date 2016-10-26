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
    public partial class AddCompound : Form
    {
        DBConnect database;

        public AddCompound(DBConnect db)
        {
            database = db;
            InitializeComponent();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            String compoundType = "";
            if (goldBackRadBtn.Checked)
            {
                compoundType = "gold_back";
            }
            if (goldFrontRadBtn.Checked)
            {
                compoundType = "gold_Front";
            }
            if (glassRadBtn.Checked)
            {
                compoundType = "glass";
            }
            if (pinkGlassRadBtn.Checked)
            {
                compoundType = "pink_glass";
            }
            if (conductorRadBtn.Checked)
            {
                compoundType = "conductor";
            }
            if (fritRadBtn.Checked)
            {
                compoundType = "frit";
            }
            String query = "INSERT INTO " + compoundType + " VALUES ('" + compoundTxt.Text.ToString() + "');";
            database.insert(query);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
