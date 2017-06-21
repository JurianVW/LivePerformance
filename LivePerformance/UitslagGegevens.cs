using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Repository.Logic;

namespace LivePerformance
{
    public partial class UitslagGegevens : Form
    {
        public string naam;
        public DateTime datum;
        public List<Partij> partijen;
        private Formatie formatie;

        public List<Label> labels = new List<Label>();

        public UitslagGegevens(List<Partij> nieuwePartijen, Formatie formatie)
        {
            InitializeComponent();
            dtpDatum.Value = DateTime.Today;
            this.partijen = nieuwePartijen;
            this.formatie = formatie;

            foreach (Partij p in partijen)
            {
                cbPartijen.Items.Add(p);
            }
            if (cbPartijen.Items.Count > 0)
            {
                cbPartijen.SelectedIndex = 0;
            }

            for (int i = 0; i < partijen.Count; i++)
            {
                Label label = new Label();

                label.Location = new Point(10, 10 + (i * 15));
                label.Text = partijen[i].ShowUitslagDetails();
                label.Name = "lblPartij" + i;
                label.AutoSize = true;
                label.Parent = pnlUitslag;

                pnlUitslag.Controls.Add(label);

                labels.Add(label);
            }
        }

        public void RefreshForm()
        {
            for (int i = 0; i < partijen.Count; i++)
            {
                Label label = labels[i];
                label.Text = partijen[i].ShowUitslagDetails();
            }
        }

        public void BerekenUitslag()
        {
            if (cbPartijen.SelectedItem != null)
            {
                foreach (Partij p in partijen)
                {
                    if (p == cbPartijen.SelectedItem as Partij)
                    {
                        p.SetStemmen(Convert.ToInt32(nudUitslagStemmen.Value));
                    }
                }
                formatie.BerekenUitslag(partijen);
                RefreshForm();
            }
        }

        private void btnUitslagGegevens_Click(object sender, EventArgs e)
        {
            naam = tbUitslagGegevensNaam.Text;
            datum = dtpDatum.Value;
            BerekenUitslag();
        }

        public void SetUitslagGegevens(string naam, DateTime datum)
        {
            tbUitslagGegevensNaam.Text = naam;
            dtpDatum.Value = datum;
        }

        private void btnBevestigStemmen_Click(object sender, EventArgs e)
        {
            BerekenUitslag();
        }

        private void cbPartijen_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudUitslagStemmen.Value = (cbPartijen.SelectedItem as Partij).Stemmen;
        }
    }
}