namespace Pesel
{
    partial class OknoGlowne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OknoGlowne));
            this.textBoxPesel = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelNapisPesel = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxPesel
            // 
            this.textBoxPesel.BackColor = System.Drawing.Color.Gold;
            this.textBoxPesel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesel.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPesel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxPesel.Location = new System.Drawing.Point(12, 12);
            this.textBoxPesel.Name = "textBoxPesel";
            this.textBoxPesel.Size = new System.Drawing.Size(158, 22);
            this.textBoxPesel.TabIndex = 0;
            this.textBoxPesel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPesel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPesel_KeyDown);
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.Gold;
            this.buttonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEnter.Location = new System.Drawing.Point(198, 12);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(78, 23);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelNapisPesel
            // 
            this.labelNapisPesel.AutoSize = true;
            this.labelNapisPesel.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNapisPesel.ForeColor = System.Drawing.Color.White;
            this.labelNapisPesel.Location = new System.Drawing.Point(12, 64);
            this.labelNapisPesel.Name = "labelNapisPesel";
            this.labelNapisPesel.Size = new System.Drawing.Size(111, 15);
            this.labelNapisPesel.TabIndex = 3;
            this.labelNapisPesel.Text = "Podany PESEL:";
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlec.ForeColor = System.Drawing.Color.White;
            this.labelPlec.Location = new System.Drawing.Point(12, 86);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(39, 15);
            this.labelPlec.TabIndex = 5;
            this.labelPlec.Text = "Płeć";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Liberation Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelData.ForeColor = System.Drawing.Color.White;
            this.labelData.Location = new System.Drawing.Point(12, 108);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(127, 15);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data urodzenia:";
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(293, 175);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelPlec);
            this.Controls.Add(this.labelNapisPesel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxPesel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OknoGlowne";
            this.Text = "Pesel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPesel;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelNapisPesel;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelData;
    }
}

