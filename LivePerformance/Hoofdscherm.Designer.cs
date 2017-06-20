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
            this.lbPartijen = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnNieuwePartij = new System.Windows.Forms.Button();
            this.btnWijzigenPartij = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabVerkiezingPartij.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabVerkiezingPartij);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1243, 663);
            this.tabControl.TabIndex = 3;
            // 
            // tabVerkiezingPartij
            // 
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
            // lbPartijen
            // 
            this.lbPartijen.FormattingEnabled = true;
            this.lbPartijen.Location = new System.Drawing.Point(8, 6);
            this.lbPartijen.Name = "lbPartijen";
            this.lbPartijen.Size = new System.Drawing.Size(149, 563);
            this.lbPartijen.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabVerkiezingPartij;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbPartijen;
        private System.Windows.Forms.Button btnWijzigenPartij;
        private System.Windows.Forms.Button btnNieuwePartij;
    }
}

