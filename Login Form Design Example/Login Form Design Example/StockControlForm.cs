using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form_Design_Example
{
    public partial class StockControlForm : MaterialForm
    {
        public StockControlForm()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                lblFileName.Text = openFileDialog.FileName;
                //Do whatever you want
                //openFileDialog1.FileName .....
            }
        }
    }
}
