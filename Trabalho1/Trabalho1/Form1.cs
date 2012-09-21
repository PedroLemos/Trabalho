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
        public LinkedList<Filme> Filmes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Filmes = new LinkedList<Filme>();
        }

        //Verifica se o filmes ja existe
        private Filme Existente(string Nome)
        {
            foreach (Filme p in Filmes)
                if (p.Nome == Nome)
                    return p;
            return null;
        }

        //Faz a remoção
        private void Remover()
        {
            if (listViewDados.SelectedItems.Count == 0)
                return;

            ListViewItem item = listViewDados.SelectedItems[0];
            Filme p = Existente(item.Text);
            if (p != null)
                Filmes.Remove(p);
            listViewDados.Items.Remove(item);
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

        private void tabPageBusca_Click(object sender, EventArgs e)
        {

        }

        private void buttonCadCadastrar_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();

            item = new ListViewItem(textBoxCadFilme.Text);
        
            ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem();

            subitem = new ListViewItem.ListViewSubItem(item, comboBoxCadGenero.SelectedItem.ToString());
            item.SubItems.Add(subitem);

            subitem = new ListViewItem.ListViewSubItem(item, textBoxCadLocal.Text);
            item.SubItems.Add(subitem);

            subitem = new ListViewItem.ListViewSubItem(item, dateTimePickerCadData.Text);
            item.SubItems.Add(subitem);

            listViewDados.Items.Add(item);
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Remover();
        }


    }
}
