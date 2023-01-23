
namespace Uczniowie
{
    partial class OknoDodajKlase
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
            this.labelKlasa = new System.Windows.Forms.Label();
            this.textBoxKlasa = new System.Windows.Forms.TextBox();
            this.buttonDodajKlasa = new System.Windows.Forms.Button();
            this.buttonAnulujKlasa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKlasa
            // 
            this.labelKlasa.AutoSize = true;
            this.labelKlasa.Location = new System.Drawing.Point(44, 52);
            this.labelKlasa.Name = "labelKlasa";
            this.labelKlasa.Size = new System.Drawing.Size(67, 15);
            this.labelKlasa.TabIndex = 0;
            this.labelKlasa.Text = "Wpisz klase";
            // 
            // textBoxKlasa
            // 
            this.textBoxKlasa.Location = new System.Drawing.Point(44, 82);
            this.textBoxKlasa.Name = "textBoxKlasa";
            this.textBoxKlasa.Size = new System.Drawing.Size(293, 23);
            this.textBoxKlasa.TabIndex = 1;
            // 
            // buttonDodajKlasa
            // 
            this.buttonDodajKlasa.Location = new System.Drawing.Point(44, 135);
            this.buttonDodajKlasa.Name = "buttonDodajKlasa";
            this.buttonDodajKlasa.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajKlasa.TabIndex = 2;
            this.buttonDodajKlasa.Text = "Dodaj";
            this.buttonDodajKlasa.UseVisualStyleBackColor = true;
            this.buttonDodajKlasa.Click += new System.EventHandler(this.buttonDodajKlasa_Click);
            // 
            // buttonAnulujKlasa
            // 
            this.buttonAnulujKlasa.Location = new System.Drawing.Point(262, 135);
            this.buttonAnulujKlasa.Name = "buttonAnulujKlasa";
            this.buttonAnulujKlasa.Size = new System.Drawing.Size(75, 23);
            this.buttonAnulujKlasa.TabIndex = 3;
            this.buttonAnulujKlasa.Text = "Anuluj";
            this.buttonAnulujKlasa.UseVisualStyleBackColor = true;
            this.buttonAnulujKlasa.Click += new System.EventHandler(this.buttonAnulujKlasa_Click);
            // 
            // OknoDodajKlase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(395, 226);
            this.Controls.Add(this.buttonAnulujKlasa);
            this.Controls.Add(this.buttonDodajKlasa);
            this.Controls.Add(this.textBoxKlasa);
            this.Controls.Add(this.labelKlasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(411, 265);
            this.MinimumSize = new System.Drawing.Size(411, 265);
            this.Name = "OknoDodajKlase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj klase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKlasa;
        private System.Windows.Forms.TextBox textBoxKlasa;
        private System.Windows.Forms.Button buttonDodajKlasa;
        private System.Windows.Forms.Button buttonAnulujKlasa;
    }
}