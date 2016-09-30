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

        private void iniciarSesiónToolStripMenuItem_Click(object sender,  EventArgs e)
        {
            SignInForm signIn = new SignInForm(database);
            signIn.ShowDialog();
            if (DBConnect.getIsEditor() == 1)
            {
                addMenuItem.Visible = true;
                removeMenuItem.Visible = true;
                logOffMenuItem.Visible = true;
                label1.Text = DBConnect.getUserName();
            }
            //database = new DBConnect();
            
            //List<string>[] list = new List<string>[2];
            //list = database.Select();
            //label1.Text = list[0].ElementAt(0);
        }
        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void familiaToolStripMenuItem_Click1(object sender, EventArgs e)
        {

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
            
        }
    }
}