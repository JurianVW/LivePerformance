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
            this.btnPartijVerkiezingToevoegen = new System.Windows.Forms.Button();
            this.lblVerkiezingPartij = new System.Windows.Forms.Label();
            this.lblGeselecteerdeVerkiezing1 = new System.Windows.Forms.Label();
            this.lblVerkiezingen = new System.Windows.Forms.Label();
            this.lbVerkiezingPartijen = new System.Windows.Forms.ListBox();
            this.lblPartijen = new System.Windows.Forms.Label();
            this.lbVerkiezingen = new System.Windows.Forms.ListBox();
            this.btnWijzigenPartij = new System.Windows.Forms.Button();
            this.btnNieuwePartij = new System.Windows.Forms.Button();
            this.lbPartijen = new System.Windows.Forms.ListBox();
            this.tabUitslagCoalitie = new System.Windows.Forms.TabPage();
            this.lblGeselecteerdeVerkiezing2 = new System.Windows.Forms.Label();
            this.pnlUitslag = new System.Windows.Forms.Panel();
            this.btnBewerkUitslag = new System.Windows.Forms.Button();
            this.lblPermier = new System.Windows.Forms.Label();
            this.btnBerekenCoalitie = new System.Windows.Forms.Button();
            this.lblKamermeerderheid2 = new System.Windows.Forms.Label();
            this.lblKamermeerderheid1 = new System.Windows.Forms.Label();
            this.lblTotaalZetelsSelectie2 = new System.Windows.Forms.Label();
            this.lblTotaalZetelsSelectie1 = new System.Windows.Forms.Label();
            this.lblMeerderheidZetels2 = new System.Windows.Forms.Label();
            this.lblMeerderheidZetels1 = new System.Windows.Forms.Label();
            this.lblTotaalZetels2 = new System.Windows.Forms.Label();
            this.lblTotaalZetels1 = new System.Windows.Forms.Label();
            this.lblCoalitie = new System.Windows.Forms.Label();
            this.lbCoalitiePartijen = new System.Windows.Forms.ListBox();
            this.btnNieuweUitslag = new System.Windows.Forms.Button();
            this.lbUitslagen = new System.Windows.Forms.ListBox();
            this.lblUitslag = new System.Windows.Forms.Label();
            this.btnNieuweVerkiezing = new System.Windows.Forms.Button();
            this.btnExporteerCoalitie = new System.Windows.Forms.Button();
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
            this.tabControl.Size = new System.Drawing.Size(886, 663);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabVerkiezingPartij
            // 
            this.tabVerkiezingPartij.Controls.Add(this.btnNieuweVerkiezing);
            this.tabVerkiezingPartij.Controls.Add(this.btnPartijVerkiezingToevoegen);
            this.tabVerkiezingPartij.Controls.Add(this.lblVerkiezingPartij);
            this.tabVerkiezingPartij.Controls.Add(this.lblGeselecteerdeVerkiezing1);
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
            this.tabVerkiezingPartij.Size = new System.Drawing.Size(878, 637);
            this.tabVerkiezingPartij.TabIndex = 0;
            this.tabVerkiezingPartij.Text = "Partij & Verkiezing";
            this.tabVerkiezingPartij.UseVisualStyleBackColor = true;
            // 
            // btnPartijVerkiezingToevoegen
            // 
            this.btnPartijVerkiezingToevoegen.Location = new System.Drawing.Point(403, 573);
            this.btnPartijVerkiezingToevoegen.Name = "btnPartijVerkiezingToevoegen";
            this.btnPartijVerkiezingToevoegen.Size = new System.Drawing.Size(329, 23);
            this.btnPartijVerkiezingToevoegen.TabIndex = 10;
            this.btnPartijVerkiezingToevoegen.Text = "Geselecteerde partij toevoegen aan verkiezing";
            this.btnPartijVerkiezingToevoegen.UseVisualStyleBackColor = true;
            this.btnPartijVerkiezingToevoegen.Click += new System.EventHandler(this.btnPartijVerkiezingToevoegen_Click);
            // 
            // lblVerkiezingPartij
            // 
            this.lblVerkiezingPartij.AutoSize = true;
            this.lblVerkiezingPartij.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblVerkiezingPartij.Location = new System.Drawing.Point(398, 340);
            this.lblVerkiezingPartij.Name = "lblVerkiezingPartij";
            this.lblVerkiezingPartij.Size = new System.Drawing.Size(217, 25);
            this.lblVerkiezingPartij.TabIndex = 9;
            this.lblVerkiezingPartij.Text = "Partijen bij verkiezing";
            // 
            // lblGeselecteerdeVerkiezing1
            // 
            this.lblGeselecteerdeVerkiezing1.AutoSize = true;
            this.lblGeselecteerdeVerkiezing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGeselecteerdeVerkiezing1.Location = new System.Drawing.Point(8, 615);
            this.lblGeselecteerdeVerkiezing1.Name = "lblGeselecteerdeVerkiezing1";
            this.lblGeselecteerdeVerkiezing1.Size = new System.Drawing.Size(0, 17);
            this.lblGeselecteerdeVerkiezing1.TabIndex = 8;
            // 
            // lblVerkiezingen
            // 
            this.lblVerkiezingen.AutoSize = true;
            this.lblVerkiezingen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblVerkiezingen.Location = new System.Drawing.Point(398, 6);
            this.lblVerkiezingen.Name = "lblVerkiezingen";
            this.lblVerkiezingen.Size = new System.Drawing.Size(137, 25);
            this.lblVerkiezingen.TabIndex = 6;
            this.lblVerkiezingen.Text = "Verkiezingen";
            // 
            // lbVerkiezingPartijen
            // 
            this.lbVerkiezingPartijen.FormattingEnabled = true;
            this.lbVerkiezingPartijen.HorizontalScrollbar = true;
            this.lbVerkiezingPartijen.Location = new System.Drawing.Point(403, 368);
            this.lbVerkiezingPartijen.Name = "lbVerkiezingPartijen";
            this.lbVerkiezingPartijen.Size = new System.Drawing.Size(329, 199);
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
            this.lbVerkiezingen.Location = new System.Drawing.Point(403, 34);
            this.lbVerkiezingen.Name = "lbVerkiezingen";
            this.lbVerkiezingen.Size = new System.Drawing.Size(329, 303);
            this.lbVerkiezingen.TabIndex = 3;
            this.lbVerkiezingen.SelectedIndexChanged += new System.EventHandler(this.lbVerkiezingen_SelectedIndexChanged);
            // 
            // btnWijzigenPartij
            // 
            this.btnWijzigenPartij.Location = new System.Drawing.Point(163, 72);
            this.btnWijzigenPartij.Name = "btnWijzigenPartij";
            this.btnWijzigenPartij.Size = new System.Drawing.Size(97, 23);
            this.btnWijzigenPartij.TabIndex = 2;
            this.btnWijzigenPartij.Text = "Partij wijzigen";
            this.btnWijzigenPartij.UseVisualStyleBackColor = true;
            this.btnWijzigenPartij.Click += new System.EventHandler(this.btnWijzigenPartij_Click);
            // 
            // btnNieuwePartij
            // 
            this.btnNieuwePartij.Location = new System.Drawing.Point(163, 32);
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
            this.lbPartijen.Size = new System.Drawing.Size(149, 563);
            this.lbPartijen.TabIndex = 0;
            // 
            // tabUitslagCoalitie
            // 
            this.tabUitslagCoalitie.Controls.Add(this.lblGeselecteerdeVerkiezing2);
            this.tabUitslagCoalitie.Controls.Add(this.pnlUitslag);
            this.tabUitslagCoalitie.Location = new System.Drawing.Point(4, 22);
            this.tabUitslagCoalitie.Name = "tabUitslagCoalitie";
            this.tabUitslagCoalitie.Padding = new System.Windows.Forms.Padding(3);
            this.tabUitslagCoalitie.Size = new System.Drawing.Size(878, 637);
            this.tabUitslagCoalitie.TabIndex = 1;
            this.tabUitslagCoalitie.Text = "Uitslag & Coalitie";
            this.tabUitslagCoalitie.UseVisualStyleBackColor = true;
            // 
            // lblGeselecteerdeVerkiezing2
            // 
            this.lblGeselecteerdeVerkiezing2.AutoSize = true;
            this.lblGeselecteerdeVerkiezing2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblGeselecteerdeVerkiezing2.Location = new System.Drawing.Point(7, 617);
            this.lblGeselecteerdeVerkiezing2.Name = "lblGeselecteerdeVerkiezing2";
            this.lblGeselecteerdeVerkiezing2.Size = new System.Drawing.Size(0, 17);
            this.lblGeselecteerdeVerkiezing2.TabIndex = 1;
            // 
            // pnlUitslag
            // 
            this.pnlUitslag.AutoScroll = true;
            this.pnlUitslag.Controls.Add(this.btnExporteerCoalitie);
            this.pnlUitslag.Controls.Add(this.btnBewerkUitslag);
            this.pnlUitslag.Controls.Add(this.lblPermier);
            this.pnlUitslag.Controls.Add(this.btnBerekenCoalitie);
            this.pnlUitslag.Controls.Add(this.lblKamermeerderheid2);
            this.pnlUitslag.Controls.Add(this.lblKamermeerderheid1);
            this.pnlUitslag.Controls.Add(this.lblTotaalZetelsSelectie2);
            this.pnlUitslag.Controls.Add(this.lblTotaalZetelsSelectie1);
            this.pnlUitslag.Controls.Add(this.lblMeerderheidZetels2);
            this.pnlUitslag.Controls.Add(this.lblMeerderheidZetels1);
            this.pnlUitslag.Controls.Add(this.lblTotaalZetels2);
            this.pnlUitslag.Controls.Add(this.lblTotaalZetels1);
            this.pnlUitslag.Controls.Add(this.lblCoalitie);
            this.pnlUitslag.Controls.Add(this.lbCoalitiePartijen);
            this.pnlUitslag.Controls.Add(this.btnNieuweUitslag);
            this.pnlUitslag.Controls.Add(this.lbUitslagen);
            this.pnlUitslag.Controls.Add(this.lblUitslag);
            this.pnlUitslag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUitslag.Enabled = false;
            this.pnlUitslag.Location = new System.Drawing.Point(3, 3);
            this.pnlUitslag.Name = "pnlUitslag";
            this.pnlUitslag.Size = new System.Drawing.Size(872, 607);
            this.pnlUitslag.TabIndex = 0;
            // 
            // btnBewerkUitslag
            // 
            this.btnBewerkUitslag.Location = new System.Drawing.Point(106, 231);
            this.btnBewerkUitslag.Name = "btnBewerkUitslag";
            this.btnBewerkUitslag.Size = new System.Drawing.Size(93, 23);
            this.btnBewerkUitslag.TabIndex = 20;
            this.btnBewerkUitslag.Text = "Bewerk uitslag";
            this.btnBewerkUitslag.UseVisualStyleBackColor = true;
            this.btnBewerkUitslag.Click += new System.EventHandler(this.btnBewerkUitslag_Click);
            // 
            // lblPermier
            // 
            this.lblPermier.AutoSize = true;
            this.lblPermier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblPermier.Location = new System.Drawing.Point(476, 196);
            this.lblPermier.Name = "lblPermier";
            this.lblPermier.Size = new System.Drawing.Size(65, 17);
            this.lblPermier.TabIndex = 19;
            this.lblPermier.Text = "Permier: ";
            // 
            // btnBerekenCoalitie
            // 
            this.btnBerekenCoalitie.Location = new System.Drawing.Point(479, 566);
            this.btnBerekenCoalitie.Name = "btnBerekenCoalitie";
            this.btnBerekenCoalitie.Size = new System.Drawing.Size(75, 23);
            this.btnBerekenCoalitie.TabIndex = 18;
            this.btnBerekenCoalitie.Text = "Check!";
            this.btnBerekenCoalitie.UseVisualStyleBackColor = true;
            this.btnBerekenCoalitie.Click += new System.EventHandler(this.btnBerekenCoalitie_Click);
            // 
            // lblKamermeerderheid2
            // 
            this.lblKamermeerderheid2.AutoSize = true;
            this.lblKamermeerderheid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblKamermeerderheid2.Location = new System.Drawing.Point(711, 157);
            this.lblKamermeerderheid2.Name = "lblKamermeerderheid2";
            this.lblKamermeerderheid2.Size = new System.Drawing.Size(34, 17);
            this.lblKamermeerderheid2.TabIndex = 17;
            this.lblKamermeerderheid2.Text = "Nee";
            // 
            // lblKamermeerderheid1
            // 
            this.lblKamermeerderheid1.AutoSize = true;
            this.lblKamermeerderheid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblKamermeerderheid1.Location = new System.Drawing.Point(476, 157);
            this.lblKamermeerderheid1.Name = "lblKamermeerderheid1";
            this.lblKamermeerderheid1.Size = new System.Drawing.Size(141, 17);
            this.lblKamermeerderheid1.TabIndex = 16;
            this.lblKamermeerderheid1.Text = "Kamermeerderheid?:";
            // 
            // lblTotaalZetelsSelectie2
            // 
            this.lblTotaalZetelsSelectie2.AutoSize = true;
            this.lblTotaalZetelsSelectie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotaalZetelsSelectie2.Location = new System.Drawing.Point(711, 115);
            this.lblTotaalZetelsSelectie2.Name = "lblTotaalZetelsSelectie2";
            this.lblTotaalZetelsSelectie2.Size = new System.Drawing.Size(16, 17);
            this.lblTotaalZetelsSelectie2.TabIndex = 15;
            this.lblTotaalZetelsSelectie2.Text = "0";
            // 
            // lblTotaalZetelsSelectie1
            // 
            this.lblTotaalZetelsSelectie1.AutoSize = true;
            this.lblTotaalZetelsSelectie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotaalZetelsSelectie1.Location = new System.Drawing.Point(476, 115);
            this.lblTotaalZetelsSelectie1.Name = "lblTotaalZetelsSelectie1";
            this.lblTotaalZetelsSelectie1.Size = new System.Drawing.Size(188, 17);
            this.lblTotaalZetelsSelectie1.TabIndex = 14;
            this.lblTotaalZetelsSelectie1.Text = "Totaal aantal zetels selectie:";
            // 
            // lblMeerderheidZetels2
            // 
            this.lblMeerderheidZetels2.AutoSize = true;
            this.lblMeerderheidZetels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMeerderheidZetels2.Location = new System.Drawing.Point(711, 76);
            this.lblMeerderheidZetels2.Name = "lblMeerderheidZetels2";
            this.lblMeerderheidZetels2.Size = new System.Drawing.Size(24, 17);
            this.lblMeerderheidZetels2.TabIndex = 13;
            this.lblMeerderheidZetels2.Text = "76";
            // 
            // lblMeerderheidZetels1
            // 
            this.lblMeerderheidZetels1.AutoSize = true;
            this.lblMeerderheidZetels1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblMeerderheidZetels1.Location = new System.Drawing.Point(476, 76);
            this.lblMeerderheidZetels1.Name = "lblMeerderheidZetels1";
            this.lblMeerderheidZetels1.Size = new System.Drawing.Size(198, 17);
            this.lblMeerderheidZetels1.TabIndex = 12;
            this.lblMeerderheidZetels1.Text = "Meerderheid bij aantal zetels: ";
            // 
            // lblTotaalZetels2
            // 
            this.lblTotaalZetels2.AutoSize = true;
            this.lblTotaalZetels2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotaalZetels2.Location = new System.Drawing.Point(711, 40);
            this.lblTotaalZetels2.Name = "lblTotaalZetels2";
            this.lblTotaalZetels2.Size = new System.Drawing.Size(32, 17);
            this.lblTotaalZetels2.TabIndex = 11;
            this.lblTotaalZetels2.Text = "150";
            // 
            // lblTotaalZetels1
            // 
            this.lblTotaalZetels1.AutoSize = true;
            this.lblTotaalZetels1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblTotaalZetels1.Location = new System.Drawing.Point(476, 40);
            this.lblTotaalZetels1.Name = "lblTotaalZetels1";
            this.lblTotaalZetels1.Size = new System.Drawing.Size(172, 17);
            this.lblTotaalZetels1.TabIndex = 10;
            this.lblTotaalZetels1.Text = "Totaal te verdelen zetels: ";
            // 
            // lblCoalitie
            // 
            this.lblCoalitie.AutoSize = true;
            this.lblCoalitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblCoalitie.Location = new System.Drawing.Point(474, 1);
            this.lblCoalitie.Name = "lblCoalitie";
            this.lblCoalitie.Size = new System.Drawing.Size(147, 25);
            this.lblCoalitie.TabIndex = 9;
            this.lblCoalitie.Text = "Coalitie check";
            // 
            // lbCoalitiePartijen
            // 
            this.lbCoalitiePartijen.FormattingEnabled = true;
            this.lbCoalitiePartijen.Location = new System.Drawing.Point(479, 231);
            this.lbCoalitiePartijen.Name = "lbCoalitiePartijen";
            this.lbCoalitiePartijen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbCoalitiePartijen.Size = new System.Drawing.Size(338, 329);
            this.lbCoalitiePartijen.TabIndex = 8;
            // 
            // btnNieuweUitslag
            // 
            this.btnNieuweUitslag.Location = new System.Drawing.Point(7, 231);
            this.btnNieuweUitslag.Name = "btnNieuweUitslag";
            this.btnNieuweUitslag.Size = new System.Drawing.Size(93, 23);
            this.btnNieuweUitslag.TabIndex = 7;
            this.btnNieuweUitslag.Text = "Nieuwe uitslag";
            this.btnNieuweUitslag.UseVisualStyleBackColor = true;
            this.btnNieuweUitslag.Click += new System.EventHandler(this.btnNieuweUitslag_Click);
            // 
            // lbUitslagen
            // 
            this.lbUitslagen.FormattingEnabled = true;
            this.lbUitslagen.HorizontalScrollbar = true;
            this.lbUitslagen.Location = new System.Drawing.Point(7, 31);
            this.lbUitslagen.Name = "lbUitslagen";
            this.lbUitslagen.Size = new System.Drawing.Size(431, 186);
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
            // btnNieuweVerkiezing
            // 
            this.btnNieuweVerkiezing.Location = new System.Drawing.Point(738, 34);
            this.btnNieuweVerkiezing.Name = "btnNieuweVerkiezing";
            this.btnNieuweVerkiezing.Size = new System.Drawing.Size(112, 23);
            this.btnNieuweVerkiezing.TabIndex = 11;
            this.btnNieuweVerkiezing.Text = "Nieuwe verkiezing";
            this.btnNieuweVerkiezing.UseVisualStyleBackColor = true;
            this.btnNieuweVerkiezing.Click += new System.EventHandler(this.btnNieuweVerkiezing_Click);
            // 
            // btnExporteerCoalitie
            // 
            this.btnExporteerCoalitie.Location = new System.Drawing.Point(720, 566);
            this.btnExporteerCoalitie.Name = "btnExporteerCoalitie";
            this.btnExporteerCoalitie.Size = new System.Drawing.Size(97, 23);
            this.btnExporteerCoalitie.TabIndex = 21;
            this.btnExporteerCoalitie.Text = "Exporteer";
            this.btnExporteerCoalitie.UseVisualStyleBackColor = true;
            this.btnExporteerCoalitie.Click += new System.EventHandler(this.btnExporteerCoalitie_Click);
            // 
            // Hoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 663);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Hoofdscherm";
            this.Text = "Live Performance";
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
        private System.Windows.Forms.Label lblGeselecteerdeVerkiezing2;
        private System.Windows.Forms.Panel pnlUitslag;
        private System.Windows.Forms.ListBox lbUitslagen;
        private System.Windows.Forms.Label lblUitslag;
        private System.Windows.Forms.Button btnNieuweUitslag;
        private System.Windows.Forms.Label lblTotaalZetelsSelectie2;
        private System.Windows.Forms.Label lblTotaalZetelsSelectie1;
        private System.Windows.Forms.Label lblMeerderheidZetels2;
        private System.Windows.Forms.Label lblMeerderheidZetels1;
        private System.Windows.Forms.Label lblTotaalZetels2;
        private System.Windows.Forms.Label lblTotaalZetels1;
        private System.Windows.Forms.Label lblCoalitie;
        private System.Windows.Forms.ListBox lbCoalitiePartijen;
        private System.Windows.Forms.Label lblKamermeerderheid2;
        private System.Windows.Forms.Label lblKamermeerderheid1;
        private System.Windows.Forms.Label lblGeselecteerdeVerkiezing1;
        private System.Windows.Forms.Button btnBerekenCoalitie;
        private System.Windows.Forms.Label lblPermier;
        private System.Windows.Forms.Button btnBewerkUitslag;
        private System.Windows.Forms.Button btnPartijVerkiezingToevoegen;
        private System.Windows.Forms.Label lblVerkiezingPartij;
        private System.Windows.Forms.Button btnNieuweVerkiezing;
        private System.Windows.Forms.Button btnExporteerCoalitie;
    }
}

