namespace CSVFormAuto1B
{
    partial class FormHlavni
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNoveAuto = new System.Windows.Forms.Button();
            this.BtnEditujAuto = new System.Windows.Forms.Button();
            this.BtnOdstranAuto = new System.Windows.Forms.Button();
            this.BtnUloz = new System.Windows.Forms.Button();
            this.LBAuta = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnNoveAuto
            // 
            this.BtnNoveAuto.Location = new System.Drawing.Point(73, 52);
            this.BtnNoveAuto.Name = "BtnNoveAuto";
            this.BtnNoveAuto.Size = new System.Drawing.Size(75, 23);
            this.BtnNoveAuto.TabIndex = 0;
            this.BtnNoveAuto.Text = "Nové auto";
            this.BtnNoveAuto.UseVisualStyleBackColor = true;
            this.BtnNoveAuto.Click += new System.EventHandler(this.BtnNoveAuto_Click);
            // 
            // BtnEditujAuto
            // 
            this.BtnEditujAuto.Location = new System.Drawing.Point(73, 93);
            this.BtnEditujAuto.Name = "BtnEditujAuto";
            this.BtnEditujAuto.Size = new System.Drawing.Size(75, 23);
            this.BtnEditujAuto.TabIndex = 1;
            this.BtnEditujAuto.Text = "Edituj Auto";
            this.BtnEditujAuto.UseVisualStyleBackColor = true;
            this.BtnEditujAuto.Click += new System.EventHandler(this.BtnEditujAuto_Click);
            // 
            // BtnOdstranAuto
            // 
            this.BtnOdstranAuto.Location = new System.Drawing.Point(73, 134);
            this.BtnOdstranAuto.Name = "BtnOdstranAuto";
            this.BtnOdstranAuto.Size = new System.Drawing.Size(75, 23);
            this.BtnOdstranAuto.TabIndex = 2;
            this.BtnOdstranAuto.Text = "Odstraň auto";
            this.BtnOdstranAuto.UseVisualStyleBackColor = true;
            // 
            // BtnUloz
            // 
            this.BtnUloz.Location = new System.Drawing.Point(73, 238);
            this.BtnUloz.Name = "BtnUloz";
            this.BtnUloz.Size = new System.Drawing.Size(116, 23);
            this.BtnUloz.TabIndex = 3;
            this.BtnUloz.Text = "Ulož do souboru";
            this.BtnUloz.UseVisualStyleBackColor = true;
            this.BtnUloz.Click += new System.EventHandler(this.BtnUloz_Click);
            // 
            // LBAuta
            // 
            this.LBAuta.FormattingEnabled = true;
            this.LBAuta.Location = new System.Drawing.Point(259, 52);
            this.LBAuta.Name = "LBAuta";
            this.LBAuta.Size = new System.Drawing.Size(153, 160);
            this.LBAuta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seznam aut:";
            // 
            // FormHlavni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBAuta);
            this.Controls.Add(this.BtnUloz);
            this.Controls.Add(this.BtnOdstranAuto);
            this.Controls.Add(this.BtnEditujAuto);
            this.Controls.Add(this.BtnNoveAuto);
            this.Name = "FormHlavni";
            this.Text = "Evidence aut";
            this.Load += new System.EventHandler(this.FormHlavni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNoveAuto;
        private System.Windows.Forms.Button BtnEditujAuto;
        private System.Windows.Forms.Button BtnOdstranAuto;
        private System.Windows.Forms.Button BtnUloz;
        private System.Windows.Forms.ListBox LBAuta;
        private System.Windows.Forms.Label label1;
    }
}

