namespace LivePerformance
{
    partial class UitslagGegevens
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
            this.btnUitslagGegevens = new System.Windows.Forms.Button();
            this.tbUitslagGegevensNaam = new System.Windows.Forms.TextBox();
            this.lblUitslagGegevensNaam = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblUitslagGegevensDatum = new System.Windows.Forms.Label();
            this.cbPartijen = new System.Windows.Forms.ComboBox();
            this.lblPartij = new System.Windows.Forms.Label();
            this.pnlUitslag = new System.Windows.Forms.Panel();
            this.lblUitslag = new System.Windows.Forms.Label();
            this.nudUitslagStemmen = new System.Windows.Forms.NumericUpDown();
            this.btnBevestigStemmen = new System.Windows.Forms.Button();
            this.lblStemmen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUitslagStemmen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUitslagGegevens
            // 
            this.btnUitslagGegevens.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUitslagGegevens.Location = new System.Drawing.Point(15, 470);
            this.btnUitslagGegevens.Name = "btnUitslagGegevens";
            this.btnUitslagGegevens.Size = new System.Drawing.Size(75, 23);
            this.btnUitslagGegevens.TabIndex = 7;
            this.btnUitslagGegevens.Text = "Opslaan";
            this.btnUitslagGegevens.UseVisualStyleBackColor = true;
            this.btnUitslagGegevens.Click += new System.EventHandler(this.btnUitslagGegevens_Click);
            // 
            // tbUitslagGegevensNaam
            // 
            this.tbUitslagGegevensNaam.Location = new System.Drawing.Point(59, 6);
            this.tbUitslagGegevensNaam.Name = "tbUitslagGegevensNaam";
            this.tbUitslagGegevensNaam.Size = new System.Drawing.Size(348, 20);
            this.tbUitslagGegevensNaam.TabIndex = 8;
            // 
            // lblUitslagGegevensNaam
            // 
            this.lblUitslagGegevensNaam.AutoSize = true;
            this.lblUitslagGegevensNaam.Location = new System.Drawing.Point(12, 9);
            this.lblUitslagGegevensNaam.Name = "lblUitslagGegevensNaam";
            this.lblUitslagGegevensNaam.Size = new System.Drawing.Size(41, 13);
            this.lblUitslagGegevensNaam.TabIndex = 9;
            this.lblUitslagGegevensNaam.Text = "Naam: ";
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd-MM-yyyy";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(59, 32);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(109, 20);
            this.dtpDatum.TabIndex = 10;
            this.dtpDatum.Value = new System.DateTime(2017, 6, 21, 0, 0, 0, 0);
            // 
            // lblUitslagGegevensDatum
            // 
            this.lblUitslagGegevensDatum.AutoSize = true;
            this.lblUitslagGegevensDatum.Location = new System.Drawing.Point(12, 36);
            this.lblUitslagGegevensDatum.Name = "lblUitslagGegevensDatum";
            this.lblUitslagGegevensDatum.Size = new System.Drawing.Size(41, 13);
            this.lblUitslagGegevensDatum.TabIndex = 11;
            this.lblUitslagGegevensDatum.Text = "Datum:";
            // 
            // cbPartijen
            // 
            this.cbPartijen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartijen.FormattingEnabled = true;
            this.cbPartijen.Location = new System.Drawing.Point(75, 113);
            this.cbPartijen.Name = "cbPartijen";
            this.cbPartijen.Size = new System.Drawing.Size(188, 21);
            this.cbPartijen.TabIndex = 12;
            this.cbPartijen.SelectedIndexChanged += new System.EventHandler(this.cbPartijen_SelectedIndexChanged);
            // 
            // lblPartij
            // 
            this.lblPartij.AutoSize = true;
            this.lblPartij.Location = new System.Drawing.Point(12, 116);
            this.lblPartij.Name = "lblPartij";
            this.lblPartij.Size = new System.Drawing.Size(33, 13);
            this.lblPartij.TabIndex = 13;
            this.lblPartij.Text = "Partij:";
            // 
            // pnlUitslag
            // 
            this.pnlUitslag.Location = new System.Drawing.Point(496, 34);
            this.pnlUitslag.Name = "pnlUitslag";
            this.pnlUitslag.Size = new System.Drawing.Size(497, 461);
            this.pnlUitslag.TabIndex = 14;
            // 
            // lblUitslag
            // 
            this.lblUitslag.AutoSize = true;
            this.lblUitslag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblUitslag.Location = new System.Drawing.Point(491, 6);
            this.lblUitslag.Name = "lblUitslag";
            this.lblUitslag.Size = new System.Drawing.Size(84, 25);
            this.lblUitslag.TabIndex = 15;
            this.lblUitslag.Text = "Uitslag:";
            // 
            // nudUitslagStemmen
            // 
            this.nudUitslagStemmen.Location = new System.Drawing.Point(75, 154);
            this.nudUitslagStemmen.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudUitslagStemmen.Name = "nudUitslagStemmen";
            this.nudUitslagStemmen.Size = new System.Drawing.Size(120, 20);
            this.nudUitslagStemmen.TabIndex = 16;
            // 
            // btnBevestigStemmen
            // 
            this.btnBevestigStemmen.Location = new System.Drawing.Point(75, 193);
            this.btnBevestigStemmen.Name = "btnBevestigStemmen";
            this.btnBevestigStemmen.Size = new System.Drawing.Size(120, 23);
            this.btnBevestigStemmen.TabIndex = 17;
            this.btnBevestigStemmen.Text = "Bevestig stemmen";
            this.btnBevestigStemmen.UseVisualStyleBackColor = true;
            this.btnBevestigStemmen.Click += new System.EventHandler(this.btnBevestigStemmen_Click);
            // 
            // lblStemmen
            // 
            this.lblStemmen.AutoSize = true;
            this.lblStemmen.Location = new System.Drawing.Point(12, 156);
            this.lblStemmen.Name = "lblStemmen";
            this.lblStemmen.Size = new System.Drawing.Size(57, 13);
            this.lblStemmen.TabIndex = 18;
            this.lblStemmen.Text = "Stemmen: ";
            // 
            // UitslagGegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 505);
            this.Controls.Add(this.lblStemmen);
            this.Controls.Add(this.btnBevestigStemmen);
            this.Controls.Add(this.nudUitslagStemmen);
            this.Controls.Add(this.lblUitslag);
            this.Controls.Add(this.pnlUitslag);
            this.Controls.Add(this.lblPartij);
            this.Controls.Add(this.cbPartijen);
            this.Controls.Add(this.lblUitslagGegevensDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblUitslagGegevensNaam);
            this.Controls.Add(this.tbUitslagGegevensNaam);
            this.Controls.Add(this.btnUitslagGegevens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UitslagGegevens";
            this.Text = "Uitslag";
            ((System.ComponentModel.ISupportInitialize)(this.nudUitslagStemmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUitslagGegevens;
        private System.Windows.Forms.TextBox tbUitslagGegevensNaam;
        private System.Windows.Forms.Label lblUitslagGegevensNaam;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblUitslagGegevensDatum;
        private System.Windows.Forms.ComboBox cbPartijen;
        private System.Windows.Forms.Label lblPartij;
        private System.Windows.Forms.Panel pnlUitslag;
        private System.Windows.Forms.Label lblUitslag;
        private System.Windows.Forms.NumericUpDown nudUitslagStemmen;
        private System.Windows.Forms.Button btnBevestigStemmen;
        private System.Windows.Forms.Label lblStemmen;
    }
}