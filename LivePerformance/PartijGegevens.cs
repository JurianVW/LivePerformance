using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivePerformance
{
    public partial class PartijGegevens : Form
    {
        public string naam;
        public string naamVolledig;
        public string lijsttrekker;

        public PartijGegevens()
        {
            InitializeComponent();
        }

        private void btnPartijGegevens_Click(object sender, EventArgs e)
        {
            naam = tbPartijGegevensNaam.Text;
            naamVolledig = tbPartijGegevensNaamVolledig.Text;
            lijsttrekker = tbPartijGegevensLijsttrekker.Text;
        }

        public void SetPartijGegevens(string naam, string naamVolledig, string lijsttrekker)
        {
            tbPartijGegevensNaam.Text = naam;
            tbPartijGegevensNaamVolledig.Text = naamVolledig;
            tbPartijGegevensLijsttrekker.Text = lijsttrekker;
        }
    }
}