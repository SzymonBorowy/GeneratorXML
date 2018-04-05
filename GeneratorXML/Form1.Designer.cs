namespace GeneratorXML
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPWW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNaglowek = new System.Windows.Forms.TextBox();
            this.tbWezel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbPola = new System.Windows.Forms.RichTextBox();
            this.buttonWWZP = new System.Windows.Forms.Button();
            this.tbSciezka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPWW
            // 
            this.buttonPWW.Location = new System.Drawing.Point(73, 211);
            this.buttonPWW.Name = "buttonPWW";
            this.buttonPWW.Size = new System.Drawing.Size(75, 56);
            this.buttonPWW.TabIndex = 0;
            this.buttonPWW.Text = "Podaj własne wartości";
            this.buttonPWW.UseVisualStyleBackColor = true;
            this.buttonPWW.Click += new System.EventHandler(this.buttonPWW_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nagłówek";
            // 
            // tbNaglowek
            // 
            this.tbNaglowek.Location = new System.Drawing.Point(73, 38);
            this.tbNaglowek.Name = "tbNaglowek";
            this.tbNaglowek.Size = new System.Drawing.Size(185, 20);
            this.tbNaglowek.TabIndex = 2;
            this.tbNaglowek.Text = "Pola";
            // 
            // tbWezel
            // 
            this.tbWezel.Location = new System.Drawing.Point(73, 64);
            this.tbWezel.Name = "tbWezel";
            this.tbWezel.Size = new System.Drawing.Size(185, 20);
            this.tbWezel.TabIndex = 4;
            this.tbWezel.Text = "Pole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Węzeł";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pola";
            // 
            // rtbPola
            // 
            this.rtbPola.Location = new System.Drawing.Point(73, 90);
            this.rtbPola.Name = "rtbPola";
            this.rtbPola.Size = new System.Drawing.Size(185, 115);
            this.rtbPola.TabIndex = 7;
            this.rtbPola.Text = "nazwa\nnumer\ncena\nczynsz1\nczynsz2\nczynsz3\nczynsz4\nczynsz5\nczynsz6\ncenaBudynku\nwłaś" +
    "ciciel";
            // 
            // buttonWWZP
            // 
            this.buttonWWZP.Location = new System.Drawing.Point(154, 211);
            this.buttonWWZP.Name = "buttonWWZP";
            this.buttonWWZP.Size = new System.Drawing.Size(75, 56);
            this.buttonWWZP.TabIndex = 8;
            this.buttonWWZP.Text = "Wczytaj wartości z pliku";
            this.buttonWWZP.UseVisualStyleBackColor = true;
            this.buttonWWZP.Click += new System.EventHandler(this.buttonWWZP_Click);
            // 
            // tbSciezka
            // 
            this.tbSciezka.Location = new System.Drawing.Point(73, 12);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.Size = new System.Drawing.Size(185, 20);
            this.tbSciezka.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Scieżka";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 391);
            this.Controls.Add(this.tbSciezka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWWZP);
            this.Controls.Add(this.rtbPola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbWezel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNaglowek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPWW);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPWW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaglowek;
        private System.Windows.Forms.TextBox tbWezel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbPola;
        private System.Windows.Forms.Button buttonWWZP;
        private System.Windows.Forms.TextBox tbSciezka;
        private System.Windows.Forms.Label label4;
    }
}

