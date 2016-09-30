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
    public partial class SignInForm : Form
    {
        private DBConnect database;
        public SignInForm(DBConnect db)
        {
            InitializeComponent();
            database = db;
            Console.WriteLine(database.getConnection());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            database.closeConnection();
            Console.WriteLine(database.getConnection());
            this.Close();
        }

        public void btn_signIn_Click(object sender, EventArgs e)
        {
            String user, password;
            //database.openConnection();
            user = txt_user.Text.ToString();
            password = txt_password.Text.ToString();
            database.selectEmployee(user, password);
            
            //database.closeConnection();
            this.Close();
        }
    }
}