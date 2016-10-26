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
    public partial class MainForm : Form
    {
        public DBConnect database;

        public MainForm()
        {
            database = new DBConnect();
            InitializeComponent();
            logOffMenuItem.Visible = false;
            addMenuItem.Visible = false;
            removeMenuItem.Visible = false;
        }

        private void addWorkOrder_Click(object sender, EventArgs e)
        {
            AddWOForm workOrder = new AddWOForm();
            workOrder.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signInMenuItem_Click(object sender,  EventArgs e)
        {
            SignInForm signIn = new SignInForm(database);
            signIn.ShowDialog();
            if (DBConnect.getIsEditor() == 1)
            {
                addMenuItem.Visible = true;
                removeMenuItem.Visible = true;
            }
            logOffMenuItem.Visible = true;
            label1.Text = DBConnect.getUserName();
        }



        private void logOffMenuItem_Click(object sender, EventArgs e)
        {
            DBConnect.closeSession();
            addMenuItem.Visible = false;
            removeMenuItem.Visible = false;
            logOffMenuItem.Visible = false;
            label1.Text = "";
        }

        private void addFamilyMenuItem_Click(object sender, EventArgs e)
        {
            AddFamily addFamily = new AddFamily(database);
            addFamily.ShowDialog();
        }

        private void addModelMenuItem_Click(object sender, EventArgs e)
        {
            AddModel addModel = new AddModel(database);
            addModel.ShowDialog();
        }

        private void addPrimeMenuItem_Click(object sender, EventArgs e)
        {
            AddPrimeMatter addPrimeMatter = new AddPrimeMatter(database);
            addPrimeMatter.ShowDialog();
        }

        private void addCompoundMenuItem_Click(object sender, EventArgs e)
        {
            AddCompound addCompound = new AddCompound(database);
            addCompound.ShowDialog();
        }

        private void addEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(database);
            addEmployee.ShowDialog();
        }
    }
}