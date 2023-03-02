using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223lab
{
    public partial class FormMain : Form
    {
        public FormMain(string loggedInUsername)
        {
            InitializeComponent();
        }

       
        private void main_Load(object sender, EventArgs e)
        {
            MySQLConnection.CheckConnection();
        }
    }
}
