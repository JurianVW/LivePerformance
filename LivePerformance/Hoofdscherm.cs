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
        private UitslagManager uitslagManager;
        private VerkiezingManager verkiezingManager;

        public Hoofdscherm()
        {
            InitializeComponent();
        }

        private void Hoofdscherm_Load(object sender, EventArgs e)
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

        public void RefreshForm()
        {
            lbPartijen.Items.Clear();
            foreach (Partij p in partijManager.GetAllPartij())
            {
                lbPartijen.Items.Add(p);
            }
        }
    }
}