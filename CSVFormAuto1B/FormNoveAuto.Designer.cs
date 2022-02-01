namespace CSVFormAuto1B
{
    partial class FormNoveAuto
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
            this.TxtNazev = new System.Windows.Forms.TextBox();
            this.TxtCena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPridejAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNazev
            // 
            this.TxtNazev.Location = new System.Drawing.Point(131, 54);
            this.TxtNazev.Name = "TxtNazev";
            this.TxtNazev.Size = new System.Drawing.Size(100, 20);
            this.TxtNazev.TabIndex = 0;
            // 
            // TxtCena
            // 
            this.TxtCena.Location = new System.Drawing.Point(131, 89);
            this.TxtCena.Name = "TxtCena";
            this.TxtCena.Size = new System.Drawing.Size(100, 20);
            this.TxtCena.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Název";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cena";
            // 
            // BtnPridejAuto
            // 
            this.BtnPridejAuto.Location = new System.Drawing.Point(138, 143);
            this.BtnPridejAuto.Name = "BtnPridejAuto";
            this.BtnPridejAuto.Size = new System.Drawing.Size(93, 23);
            this.BtnPridejAuto.TabIndex = 4;
            this.BtnPridejAuto.Text = "Přidej auto";
            this.BtnPridejAuto.UseVisualStyleBackColor = true;
            this.BtnPridejAuto.Click += new System.EventHandler(this.BtnPridejAuto_Click);
            // 
            // FormNoveAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 193);
            this.Controls.Add(this.BtnPridejAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCena);
            this.Controls.Add(this.TxtNazev);
            this.Name = "FormNoveAuto";
            this.Text = "Nové auto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNazev;
        private System.Windows.Forms.TextBox TxtCena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPridejAuto;
    }
}