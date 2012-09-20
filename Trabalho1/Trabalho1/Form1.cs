using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxBuscaNome_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuscaNome.Checked == true)
            {
                textBoxBuscaNome.Enabled = true;
            }
            else
            {
                textBoxBuscaNome.Enabled = false;
            }
        }

        private void checkBoxBuscaGenero_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuscaGenero.Checked == true)
            {
                comboBoxBuscaGenero.Enabled = true;
            }
            else
            {
                comboBoxBuscaGenero.Enabled = false;
            }
        }

        private void checkBoxBuscaLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuscaLocal.Checked == true)
            {
                textBoxBuscaLocal.Enabled = true;
            }
            else
            {
                textBoxBuscaLocal.Enabled = false;
            }
        }

        private void checkBoxBuscaData_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuscaData.Checked == true)
            {
                dateTimePickerBuscaData1.Enabled = true;
                dateTimePickerBuscaData2.Enabled = true;
            }
            else
            {
                dateTimePickerBuscaData1.Enabled = false;
                dateTimePickerBuscaData2.Enabled = false;
            }
        }
    }
}
