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
    public partial class VerkiezingGegevens : Form
    {
        public string naam;
        public int zetels;
        public int zetelsMeederheid;

        public VerkiezingGegevens()
        {
            InitializeComponent();
        }

        private void btnVerkiezingGegevens_Click(object sender, EventArgs e)
        {
            naam = tbVerkiezingGegevensNaam.Text;
            zetels = Convert.ToInt32(nudVerkiezingGegevensZetels.Value);
            zetelsMeederheid = Convert.ToInt32(nudVerkiezingGegevensZetelsMeerderheid.Value);
        }
    }
}