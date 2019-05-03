using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Maintenance
{
    public partial class FormProductMaintenance : Form
    {
        public FormProductMaintenance()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
