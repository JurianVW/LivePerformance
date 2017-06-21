namespace LivePerformance
{
    partial class VerkiezingGegevens
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
            this.lblVerkiezingGegevensZetelsMeerderheid = new System.Windows.Forms.Label();
            this.lblVerkiezingGegevensZetels = new System.Windows.Forms.Label();
            this.lblVerkiezingGegevensNaam = new System.Windows.Forms.Label();
            this.tbVerkiezingGegevensNaam = new System.Windows.Forms.TextBox();
            this.nudVerkiezingGegevensZetels = new System.Windows.Forms.NumericUpDown();
            this.nudVerkiezingGegevensZetelsMeerderheid = new System.Windows.Forms.NumericUpDown();
            this.btnVerkiezingGegevens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerkiezingGegevensZetels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerkiezingGegevensZetelsMeerderheid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerkiezingGegevensZetelsMeerderheid
            // 
            this.lblVerkiezingGegevensZetelsMeerderheid.AutoSize = true;
            this.lblVerkiezingGegevensZetelsMeerderheid.Location = new System.Drawing.Point(12, 79);
            this.lblVerkiezingGegevensZetelsMeerderheid.Name = "lblVerkiezingGegevensZetelsMeerderheid";
            this.lblVerkiezingGegevensZetelsMeerderheid.Size = new System.Drawing.Size(109, 13);
            this.lblVerkiezingGegevensZetelsMeerderheid.TabIndex = 10;
            this.lblVerkiezingGegevensZetelsMeerderheid.Text = "Meerderheid bij zetels";
            // 
            // lblVerkiezingGegevensZetels
            // 
            this.lblVerkiezingGegevensZetels.AutoSize = true;
            this.lblVerkiezingGegevensZetels.Location = new System.Drawing.Point(12, 45);
            this.lblVerkiezingGegevensZetels.Name = "lblVerkiezingGegevensZetels";
            this.lblVerkiezingGegevensZetels.Size = new System.Drawing.Size(36, 13);
            this.lblVerkiezingGegevensZetels.TabIndex = 9;
            this.lblVerkiezingGegevensZetels.Text = "Zetels";
            // 
            // lblVerkiezingGegevensNaam
            // 
            this.lblVerkiezingGegevensNaam.AutoSize = true;
            this.lblVerkiezingGegevensNaam.Location = new System.Drawing.Point(12, 15);
            this.lblVerkiezingGegevensNaam.Name = "lblVerkiezingGegevensNaam";
            this.lblVerkiezingGegevensNaam.Size = new System.Drawing.Size(41, 13);
            this.lblVerkiezingGegevensNaam.TabIndex = 7;
            this.lblVerkiezingGegevensNaam.Text = "Naam: ";
            // 
            // tbVerkiezingGegevensNaam
            // 
            this.tbVerkiezingGegevensNaam.Location = new System.Drawing.Point(130, 12);
            this.tbVerkiezingGegevensNaam.Name = "tbVerkiezingGegevensNaam";
            this.tbVerkiezingGegevensNaam.Size = new System.Drawing.Size(293, 20);
            this.tbVerkiezingGegevensNaam.TabIndex = 6;
            // 
            // nudVerkiezingGegevensZetels
            // 
            this.nudVerkiezingGegevensZetels.Location = new System.Drawing.Point(130, 45);
            this.nudVerkiezingGegevensZetels.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudVerkiezingGegevensZetels.Name = "nudVerkiezingGegevensZetels";
            this.nudVerkiezingGegevensZetels.Size = new System.Drawing.Size(120, 20);
            this.nudVerkiezingGegevensZetels.TabIndex = 11;
            // 
            // nudVerkiezingGegevensZetelsMeerderheid
            // 
            this.nudVerkiezingGegevensZetelsMeerderheid.Location = new System.Drawing.Point(130, 77);
            this.nudVerkiezingGegevensZetelsMeerderheid.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudVerkiezingGegevensZetelsMeerderheid.Name = "nudVerkiezingGegevensZetelsMeerderheid";
            this.nudVerkiezingGegevensZetelsMeerderheid.Size = new System.Drawing.Size(120, 20);
            this.nudVerkiezingGegevensZetelsMeerderheid.TabIndex = 12;
            // 
            // btnVerkiezingGegevens
            // 
            this.btnVerkiezingGegevens.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnVerkiezingGegevens.Location = new System.Drawing.Point(348, 79);
            this.btnVerkiezingGegevens.Name = "btnVerkiezingGegevens";
            this.btnVerkiezingGegevens.Size = new System.Drawing.Size(75, 23);
            this.btnVerkiezingGegevens.TabIndex = 13;
            this.btnVerkiezingGegevens.Text = "Bevestigen";
            this.btnVerkiezingGegevens.UseVisualStyleBackColor = true;
            this.btnVerkiezingGegevens.Click += new System.EventHandler(this.btnVerkiezingGegevens_Click);
            // 
            // VerkiezingGegevens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 124);
            this.Controls.Add(this.btnVerkiezingGegevens);
            this.Controls.Add(this.nudVerkiezingGegevensZetelsMeerderheid);
            this.Controls.Add(this.nudVerkiezingGegevensZetels);
            this.Controls.Add(this.lblVerkiezingGegevensZetelsMeerderheid);
            this.Controls.Add(this.lblVerkiezingGegevensZetels);
            this.Controls.Add(this.lblVerkiezingGegevensNaam);
            this.Controls.Add(this.tbVerkiezingGegevensNaam);
            this.Name = "VerkiezingGegevens";
            this.Text = "VerkiezingGegevens";
            ((System.ComponentModel.ISupportInitialize)(this.nudVerkiezingGegevensZetels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVerkiezingGegevensZetelsMeerderheid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVerkiezingGegevensZetelsMeerderheid;
        private System.Windows.Forms.Label lblVerkiezingGegevensZetels;
        private System.Windows.Forms.Label lblVerkiezingGegevensNaam;
        private System.Windows.Forms.TextBox tbVerkiezingGegevensNaam;
        private System.Windows.Forms.NumericUpDown nudVerkiezingGegevensZetels;
        private System.Windows.Forms.NumericUpDown nudVerkiezingGegevensZetelsMeerderheid;
        private System.Windows.Forms.Button btnVerkiezingGegevens;
    }
}