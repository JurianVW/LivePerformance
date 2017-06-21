namespace LivePerformance
{
    partial class PartijGegevens
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
            this.lblPartijGegevensNaamVolledig = new System.Windows.Forms.Label();
            this.tbPartijGegevensNaamVolledig = new System.Windows.Forms.TextBox();
            this.lblPartijGegevensNaam = new System.Windows.Forms.Label();
            this.tbPartijGegevensNaam = new System.Windows.Forms.TextBox();
            this.lblPartijGegevensLijsttrekker = new System.Windows.Forms.Label();
            this.tbPartijGegevensLijsttrekker = new System.Windows.Forms.TextBox();
            this.btnPartijGegevens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPartijGegevensNaamVolledig
            // 
            this.lblPartijGegevensNaamVolledig.AutoSize = true;
            this.lblPartijGegevensNaamVolledig.Location = new System.Drawing.Point(12, 43);
            this.lblPartijGegevensNaamVolledig.Name = "lblPartijGegevensNaamVolledig";
            this.lblPartijGegevensNaamVolledig.Size = new System.Drawing.Size(86, 13);
            this.lblPartijGegevensNaamVolledig.TabIndex = 3;
            this.lblPartijGegevensNaamVolledig.Text = "Naam (volledig): ";
            // 
            // tbPartijGegevensNaamVolledig
            // 
            this.tbPartijGegevensNaamVolledig.Location = new System.Drawing.Point(104, 40);
            this.tbPartijGegevensNaamVolledig.Name = "tbPartijGegevensNaamVolledig";
            this.tbPartijGegevensNaamVolledig.Size = new System.Drawing.Size(293, 20);
            this.tbPartijGegevensNaamVolledig.TabIndex = 2;
            // 
            // lblPartijGegevensNaam
            // 
            this.lblPartijGegevensNaam.AutoSize = true;
            this.lblPartijGegevensNaam.Location = new System.Drawing.Point(12, 13);
            this.lblPartijGegevensNaam.Name = "lblPartijGegevensNaam";
            this.lblPartijGegevensNaam.Size = new System.Drawing.Size(41, 13);
            this.lblPartijGegevensNaam.TabIndex = 1;
            this.lblPartijGegevensNaam.Text = "Naam: ";
            // 
            // tbPartijGegevensNaam
            // 
            this.tbPartijGegevensNaam.Location = new System.Drawing.Point(104, 10);
            this.tbPartijGegevensNaam.Name = "tbPartijGegevensNaam";
            this.tbPartijGegevensNaam.Size = new System.Drawing.Size(293, 20);
            this.tbPartijGegevensNaam.TabIndex = 0;
            // 
            // lblPartijGegevensLijsttrekker
            // 
            this.lblPartijGegevensLijsttrekker.AutoSize = true;
            this.lblPartijGegevensLijsttrekker.Location = new System.Drawing.Point(12, 77);
            this.lblPartijGegevensLijsttrekker.Name = "lblPartijGegevensLijsttrekker";
            this.lblPartijGegevensLijsttrekker.Size = new System.Drawing.Size(64, 13);
            this.lblPartijGegevensLijsttrekker.TabIndex = 4;
            this.lblPartijGegevensLijsttrekker.Text = "Lijsttrekker: ";
            // 
            // tbPartijGegevensLijsttrekker
            // 
            this.tbPartijGegevensLijsttrekker.Location = new System.Drawing.Point(104, 74);
            this.tbPartijGegevensLijsttrekker.Name = "tbPartijGegevensLijsttrekker";
            this.tbPartijGegevensLijsttrekker.Size = new System.Drawing.Size(293, 20);
            this.tbPartijGegevensLijsttrekker.TabIndex = 5;
            // 
            // btnPartijGegevens
            // 
            this.btnPartijGegevens.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPartijGegevens.Location = new System.Drawing.Point(322, 109);
            this.btnPartijGegevens.Name = "btnPartijGegevens";
            this.btnPartijGegevens.Size = new System.Drawing.Size(75, 23);
            this.btnPartijGegevens.TabIndex = 6;
            this.btnPartijGegevens.Text = "Bevestigen";
            this.btnPartijGegevens.UseVisualStyleBackColor = true;
            this.btnPartijGegevens.Click += new System.EventHandler(this.btnPartijGegevens_Click);
            // 
            // PartijGegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 140);
            this.Controls.Add(this.btnPartijGegevens);
            this.Controls.Add(this.tbPartijGegevensLijsttrekker);
            this.Controls.Add(this.lblPartijGegevensLijsttrekker);
            this.Controls.Add(this.tbPartijGegevensNaamVolledig);
            this.Controls.Add(this.lblPartijGegevensNaamVolledig);
            this.Controls.Add(this.lblPartijGegevensNaam);
            this.Controls.Add(this.tbPartijGegevensNaam);
            this.Name = "PartijGegevens";
            this.Text = "Partij";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPartijGegevensNaamVolledig;
        private System.Windows.Forms.TextBox tbPartijGegevensNaamVolledig;
        private System.Windows.Forms.Label lblPartijGegevensNaam;
        private System.Windows.Forms.TextBox tbPartijGegevensNaam;
        private System.Windows.Forms.Label lblPartijGegevensLijsttrekker;
        private System.Windows.Forms.TextBox tbPartijGegevensLijsttrekker;
        private System.Windows.Forms.Button btnPartijGegevens;
    }
}