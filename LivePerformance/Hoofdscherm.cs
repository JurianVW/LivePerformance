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
using Repository.Database;
using Repository.Logic;

namespace LivePerformance
{
    public partial class Hoofdscherm : Form
    {
        private Formatie formatie;
        private PartijManager partijManager = new PartijManager(new VerkiezingSQLContext());
        private UitslagManager uitslagManager = new UitslagManager(new VerkiezingSQLContext());
        private VerkiezingManager verkiezingManager = new VerkiezingManager(new VerkiezingSQLContext());

        public Hoofdscherm()
        {
            InitializeComponent();
        }

        //Bij het laden van het hoofdscherm wordt data uit de database gehaald
        private void Hoofdscherm_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        //Deze methode is om alle info zo goed mogelijk up to date te houden vanuit de database. De if statement zit er in om te voorkomen dat hij data ophaalt waar niks mee gebeurd.
        public void RefreshForm()
        {
            if (tabControl.SelectedIndex == 0)
            {
                lbPartijen.Items.Clear();
                lbVerkiezingen.Items.Clear();
                lbVerkiezingPartijen.Items.Clear();
                foreach (Partij p in partijManager.GetAllPartij())
                {
                    lbPartijen.Items.Add(p);
                }
                foreach (Verkiezing v in verkiezingManager.GetAllVerkiezingen())
                {
                    lbVerkiezingen.Items.Add(v);
                }
            }
            else if (tabControl.SelectedIndex == 1 && formatie != null)
            {
                pnlUitslag.Enabled = true;
                lblWarning.Text = "Huidige verkiezing: " + formatie.GekozenVerkiezing;
                lbUitslagen.Items.Clear();

                verkiezingManager.GetVerkiezingsUitslagen(formatie.GekozenVerkiezing);
                foreach (Uitslag u in formatie.GekozenVerkiezing.Uitslagen)
                {
                    lbUitslagen.Items.Add(u);
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnNieuwePartij_Click(object sender, EventArgs e)
        {
            PartijGegevens partijGegevens = new PartijGegevens();

            if (partijGegevens.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    partijManager.SavePartij(new Partij(partijGegevens.naam, partijGegevens.naamVolledig,
                        partijGegevens.lijsttrekker));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            RefreshForm();
        }

        private void btnWijzigenPartij_Click(object sender, EventArgs e)
        {
            if (lbPartijen.SelectedItem != null)
            {
                Partij partij = lbPartijen.SelectedItem as Partij;
                PartijGegevens partijGegevens = new PartijGegevens();
                partijGegevens.SetPartijGegevens(partij.Naam, partij.NaamVolledig, partij.Lijsttrekker);

                if (partijGegevens.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Partij gewijzigdePartij = new Partij(partijGegevens.naam, partijGegevens.naamVolledig,
                            partijGegevens.lijsttrekker);
                        gewijzigdePartij.SetID(partij.ID);
                        partijManager.SavePartij(gewijzigdePartij);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een partij om te wijzigen!");
            }
            RefreshForm();
        }

        private void lbVerkiezingen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbVerkiezingen.SelectedItem != null)
            {
                lbVerkiezingPartijen.Items.Clear();
                Verkiezing verkiezing = lbVerkiezingen.SelectedItem as Verkiezing;
                verkiezingManager.GetVerkiezingPartijen(verkiezing);

                foreach (Partij p in verkiezing.Partijen)
                {
                    lbVerkiezingPartijen.Items.Add(p);
                }
            }
        }

        private void btnSelecteerVerkiezing_Click(object sender, EventArgs e)
        {
            formatie = new Formatie(new VerkiezingSQLContext(), lbVerkiezingen.SelectedItem as Verkiezing);
        }

        private void lbUitslagen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}