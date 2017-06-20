namespace LivePerformance
{
    partial class Hoofdscherm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabVerkiezingPartij = new System.Windows.Forms.TabPage();
            this.lblVerkiezingen = new System.Windows.Forms.Label();
            this.lbVerkiezingPartijen = new System.Windows.Forms.ListBox();
            this.lblPartijen = new System.Windows.Forms.Label();
            this.lbVerkiezingen = new System.Windows.Forms.ListBox();
            this.btnWijzigenPartij = new System.Windows.Forms.Button();
            this.btnNieuwePartij = new System.Windows.Forms.Button();
            this.lbPartijen = new System.Windows.Forms.ListBox();
            this.tabUitslagCoalitie = new System.Windows.Forms.TabPage();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pnlUitslag = new System.Windows.Forms.Panel();
            this.lbUitslagen = new System.Windows.Forms.ListBox();
            this.lblUitslag = new System.Windows.Forms.Label();
            this.btnSelecteerVerkiezing = new System.Windows.Forms.Button();
            this.btnNieuweUitslag = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabVerkiezingPartij.SuspendLayout();
            this.tabUitslagCoalitie.SuspendLayout();
            this.pnlUitslag.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVerkiezingPartij);
            this.tabControl.Controls.Add(this.tabUitslagCoalitie);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1243, 663);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabVerkiezingPartij
            // 
            this.tabVerkiezingPartij.Controls.Add(this.btnSelecteerVerkiezing);
            this.tabVerkiezingPartij.Controls.Add(this.lblVerkiezingen);
            this.tabVerkiezingPartij.Controls.Add(this.lbVerkiezingPartijen);
            this.tabVerkiezingPartij.Controls.Add(this.lblPartijen);
            this.tabVerkiezingPartij.Controls.Add(this.lbVerkiezingen);
            this.tabVerkiezingPartij.Controls.Add(this.btnWijzigenPartij);
            this.tabVerkiezingPartij.Controls.Add(this.btnNieuwePartij);
            this.tabVerkiezingPartij.Controls.Add(this.lbPartijen);
            this.tabVerkiezingPartij.Location = new System.Drawing.Point(4, 22);
            this.tabVerkiezingPartij.Name = "tabVerkiezingPartij";
            this.tabVerkiezingPartij.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerkiezingPartij.Size = new System.Drawing.Size(1235, 637);
            this.tabVerkiezingPartij.TabIndex = 0;
            this.tabVerkiezingPartij.Text = "Partij & Verkiezing";
            this.tabVerkiezingPartij.UseVisualStyleBackColor = true;
            // 
            // lblVerkiezingen
            // 
            this.lblVerkiezingen.AutoSize = true;
            this.lblVerkiezingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblVerkiezingen.Location = new System.Drawing.Point(596, 6);
            this.lblVerkiezingen.Name = "lblVerkiezingen";
            this.lblVerkiezingen.Size = new System.Drawing.Size(137, 25);
            this.lblVerkiezingen.TabIndex = 6;
            this.lblVerkiezingen.Text = "Verkiezingen";
            // 
            // lbVerkiezingPartijen
            // 
            this.lbVerkiezingPartijen.FormattingEnabled = true;
            this.lbVerkiezingPartijen.HorizontalScrollbar = true;
            this.lbVerkiezingPartijen.Location = new System.Drawing.Point(962, 32);
            this.lbVerkiezingPartijen.Name = "lbVerkiezingPartijen";
            this.lbVerkiezingPartijen.Size = new System.Drawing.Size(265, 173);
            this.lbVerkiezingPartijen.TabIndex = 5;
            // 
            // lblPartijen
            // 
            this.lblPartijen.AutoSize = true;
            this.lblPartijen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblPartijen.Location = new System.Drawing.Point(8, 6);
            this.lblPartijen.Name = "lblPartijen";
            this.lblPartijen.Size = new System.Drawing.Size(85, 25);
            this.lblPartijen.TabIndex = 4;
            this.lblPartijen.Text = "Partijen";
            // 
            // lbVerkiezingen
            // 
            this.lbVerkiezingen.FormattingEnabled = true;
            this.lbVerkiezingen.HorizontalScrollbar = true;
            this.lbVerkiezingen.Location = new System.Drawing.Point(601, 32);
            this.lbVerkiezingen.Name = "lbVerkiezingen";
            this.lbVerkiezingen.Size = new System.Drawing.Size(329, 160);
            this.lbVerkiezingen.TabIndex = 3;
            this.lbVerkiezingen.SelectedIndexChanged += new System.EventHandler(this.lbVerkiezingen_SelectedIndexChanged);
            // 
            // btnWijzigenPartij
            // 
            this.btnWijzigenPartij.Location = new System.Drawing.Point(8, 607);
            this.btnWijzigenPartij.Name = "btnWijzigenPartij";
            this.btnWijzigenPartij.Size = new System.Drawing.Size(97, 23);
            this.btnWijzigenPartij.TabIndex = 2;
            this.btnWijzigenPartij.Text = "Partij wijzigen";
            this.btnWijzigenPartij.UseVisualStyleBackColor = true;
            this.btnWijzigenPartij.Click += new System.EventHandler(this.btnWijzigenPartij_Click);
            // 
            // btnNieuwePartij
            // 
            this.btnNieuwePartij.Location = new System.Drawing.Point(8, 578);
            this.btnNieuwePartij.Name = "btnNieuwePartij";
            this.btnNieuwePartij.Size = new System.Drawing.Size(97, 23);
            this.btnNieuwePartij.TabIndex = 1;
            this.btnNieuwePartij.Text = "Nieuwe partij";
            this.btnNieuwePartij.UseVisualStyleBackColor = true;
            this.btnNieuwePartij.Click += new System.EventHandler(this.btnNieuwePartij_Click);
            // 
            // lbPartijen
            // 
            this.lbPartijen.FormattingEnabled = true;
            this.lbPartijen.HorizontalScrollbar = true;
            this.lbPartijen.Location = new System.Drawing.Point(8, 32);
            this.lbPartijen.Name = "lbPartijen";
            this.lbPartijen.Size = new System.Drawing.Size(149, 537);
            this.lbPartijen.TabIndex = 0;
            // 
            // tabUitslagCoalitie
            // 
            this.tabUitslagCoalitie.Controls.Add(this.lblWarning);
            this.tabUitslagCoalitie.Controls.Add(this.pnlUitslag);
            this.tabUitslagCoalitie.Location = new System.Drawing.Point(4, 22);
            this.tabUitslagCoalitie.Name = "tabUitslagCoalitie";
            this.tabUitslagCoalitie.Padding = new System.Windows.Forms.Padding(3);
            this.tabUitslagCoalitie.Size = new System.Drawing.Size(1235, 637);
            this.tabUitslagCoalitie.TabIndex = 1;
            this.tabUitslagCoalitie.Text = "Uitslag & Coalitie";
            this.tabUitslagCoalitie.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblWarning.Location = new System.Drawing.Point(7, 617);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(340, 17);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "Selecteer eerst een verkiezing op de andere pagina.";
            // 
            // pnlUitslag
            // 
            this.pnlUitslag.AutoScroll = true;
            this.pnlUitslag.Controls.Add(this.btnNieuweUitslag);
            this.pnlUitslag.Controls.Add(this.lbUitslagen);
            this.pnlUitslag.Controls.Add(this.lblUitslag);
            this.pnlUitslag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUitslag.Enabled = false;
            this.pnlUitslag.Location = new System.Drawing.Point(3, 3);
            this.pnlUitslag.Name = "pnlUitslag";
            this.pnlUitslag.Size = new System.Drawing.Size(1229, 607);
            this.pnlUitslag.TabIndex = 0;
            // 
            // lbUitslagen
            // 
            this.lbUitslagen.FormattingEnabled = true;
            this.lbUitslagen.HorizontalScrollbar = true;
            this.lbUitslagen.Location = new System.Drawing.Point(7, 39);
            this.lbUitslagen.Name = "lbUitslagen";
            this.lbUitslagen.Size = new System.Drawing.Size(549, 186);
            this.lbUitslagen.TabIndex = 6;
            this.lbUitslagen.SelectedIndexChanged += new System.EventHandler(this.lbUitslagen_SelectedIndexChanged);
            // 
            // lblUitslag
            // 
            this.lblUitslag.AutoSize = true;
            this.lblUitslag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblUitslag.Location = new System.Drawing.Point(0, 0);
            this.lblUitslag.Name = "lblUitslag";
            this.lblUitslag.Size = new System.Drawing.Size(78, 25);
            this.lblUitslag.TabIndex = 5;
            this.lblUitslag.Text = "Uitslag";
            // 
            // btnSelecteerVerkiezing
            // 
            this.btnSelecteerVerkiezing.Location = new System.Drawing.Point(1096, 606);
            this.btnSelecteerVerkiezing.Name = "btnSelecteerVerkiezing";
            this.btnSelecteerVerkiezing.Size = new System.Drawing.Size(133, 23);
            this.btnSelecteerVerkiezing.TabIndex = 7;
            this.btnSelecteerVerkiezing.Text = "Selecteer Verkiezing";
            this.btnSelecteerVerkiezing.UseVisualStyleBackColor = true;
            this.btnSelecteerVerkiezing.Click += new System.EventHandler(this.btnSelecteerVerkiezing_Click);
            // 
            // btnNieuweUitslag
            // 
            this.btnNieuweUitslag.Location = new System.Drawing.Point(339, 323);
            this.btnNieuweUitslag.Name = "btnNieuweUitslag";
            this.btnNieuweUitslag.Size = new System.Drawing.Size(75, 23);
            this.btnNieuweUitslag.TabIndex = 7;
            this.btnNieuweUitslag.Text = "button1";
            this.btnNieuweUitslag.UseVisualStyleBackColor = true;
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 663);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hoofdscherm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hoofdscherm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabVerkiezingPartij.ResumeLayout(false);
            this.tabVerkiezingPartij.PerformLayout();
            this.tabUitslagCoalitie.ResumeLayout(false);
            this.tabUitslagCoalitie.PerformLayout();
            this.pnlUitslag.ResumeLayout(false);
            this.pnlUitslag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVerkiezingPartij;
        private System.Windows.Forms.TabPage tabUitslagCoalitie;
        private System.Windows.Forms.ListBox lbPartijen;
        private System.Windows.Forms.Button btnWijzigenPartij;
        private System.Windows.Forms.Button btnNieuwePartij;
        private System.Windows.Forms.ListBox lbVerkiezingen;
        private System.Windows.Forms.ListBox lbVerkiezingPartijen;
        private System.Windows.Forms.Label lblPartijen;
        private System.Windows.Forms.Label lblVerkiezingen;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Panel pnlUitslag;
        private System.Windows.Forms.ListBox lbUitslagen;
        private System.Windows.Forms.Label lblUitslag;
        private System.Windows.Forms.Button btnSelecteerVerkiezing;
        private System.Windows.Forms.Button btnNieuweUitslag;
    }
}

