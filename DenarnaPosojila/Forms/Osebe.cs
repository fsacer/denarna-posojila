using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace DenarnaPosojila.Forms
{
    public partial class Osebe : Form
    {
        public Osebe()
        {
            InitializeComponent();
        }
        private void Osebe_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'posojilaDataSet.Oseba' table. You can move, or remove it, as needed.
                this.osebaTableAdapter.Fill(this.posojilaDataSet.Oseba);
            }
            catch 
            {
                DBHandle.DBError();
            }
            var slovarKrajev = new Dictionary<Object, String>();
            slovarKrajev.Add(DBNull.Value, "ni določen");
            foreach (var row in DBHandle.db.Posta.OrderBy(p=>p.PostnaStevilka))
            {
                slovarKrajev.Add(row.PostnaStevilka.ToString(), row.PostnaStevilka + " " + row.Kraj);
            }
            
            var val = "Value";
            var key = "Key";
            dataGridViewTextBoxColumn5.DataSource = new BindingSource(slovarKrajev, null);
            dataGridViewTextBoxColumn5.DisplayMember = val;
            dataGridViewTextBoxColumn5.ValueMember = key;
        }

        private void Valute_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void osebaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.osebaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.posojilaDataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Napaka pri shranjevanju. " + ex.Message, "Napaka baze", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillByImeToolStripButton_Click(object sender, EventArgs e)
        {
            var ime = imeToolStripTextBox.Text.Trim() == "" ? "" : imeToolStripTextBox.Text + "%";
            var priimek = priimekToolStripTextBox.Text.Trim() == "" ? "" : priimekToolStripTextBox.Text + "%";
            try
            {
                this.osebaTableAdapter.FillByIme(this.posojilaDataSet.Oseba, ime, priimek);
            }
            catch
            {
                DBHandle.DBError();
            }

        }

        private void toolStripButtonShowAll_Click(object sender, EventArgs e)
        {
            Osebe_Load(sender, e);
        }

        private void imeToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            fillByImeToolStripButton.PerformClick();
        }

        private void priimekToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            fillByImeToolStripButton.PerformClick();
        }

        private void Osebe_Shown(object sender, EventArgs e)
        {
            imeToolStripTextBox.Focus();
        }
    }
}
