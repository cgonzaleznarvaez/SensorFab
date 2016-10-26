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
    public partial class AddEmployee : Form
    {
        DBConnect database;

        public AddEmployee(DBConnect db)
        {
            database = db;
            InitializeComponent();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            String employeeNo = idTxt.Text;
            String employeeName = nameTxt.Text;
            String password = "null";
            String isEditor = "0";
            if (yesRadBtn.Checked)
            {
                password = passTxt.Text;
                isEditor = "1";
            }
            String query = "INSERT INTO employee VALUES ('" + employeeNo + "', '" + employeeName + "', '" + password + "', '" + isEditor + "')";
            database.insert(query);
            this.Close();
        }

        private void yesRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            passLabel.Visible = true;
            passTxt.Visible = true;
        }

        private void noRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            passLabel.Visible = false;
            passTxt.Visible = false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
