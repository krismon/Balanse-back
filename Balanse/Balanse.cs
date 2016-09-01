using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balanse
{
    public partial class Form_Balanse : Form
    {
        public Form_Balanse()
        {
            InitializeComponent();
        }

        private void S_But_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_LogIn login = new Form_LogIn();
            login.Close();
            

        }
    }
}
