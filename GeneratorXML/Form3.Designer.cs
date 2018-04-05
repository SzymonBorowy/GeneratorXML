namespace GeneratorXML
{
    partial class Form3
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
            this.tbSeparator = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSciezka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenruj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSeparator
            // 
            this.tbSeparator.Location = new System.Drawing.Point(94, 38);
            this.tbSeparator.Name = "tbSeparator";
            this.tbSeparator.Size = new System.Drawing.Size(185, 20);
            this.tbSeparator.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Separator";
            // 
            // tbSciezka
            // 
            this.tbSciezka.Location = new System.Drawing.Point(94, 12);
            this.tbSciezka.Name = "tbSciezka";
            this.tbSciezka.Size = new System.Drawing.Size(185, 20);
            this.tbSciezka.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scieżka Input";
            // 
            // buttonGenruj
            // 
            this.buttonGenruj.Location = new System.Drawing.Point(204, 64);
            this.buttonGenruj.Name = "buttonGenruj";
            this.buttonGenruj.Size = new System.Drawing.Size(75, 23);
            this.buttonGenruj.TabIndex = 9;
            this.buttonGenruj.Text = "Generuj";
            this.buttonGenruj.UseVisualStyleBackColor = true;
            this.buttonGenruj.Click += new System.EventHandler(this.buttonGenruj_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 262);
            this.Controls.Add(this.buttonGenruj);
            this.Controls.Add(this.tbSeparator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSciezka);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSeparator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSciezka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGenruj;
    }
}