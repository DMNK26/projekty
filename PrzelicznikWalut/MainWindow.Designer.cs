namespace PrzelicznikWalut
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBoxUnitType = new System.Windows.Forms.GroupBox();
            this.comboBoxUnitType = new System.Windows.Forms.ComboBox();
            this.groupBoxSourceUnit = new System.Windows.Forms.GroupBox();
            this.comboBoxSourceUnit = new System.Windows.Forms.ComboBox();
            this.groupBoxTargetUnit = new System.Windows.Forms.GroupBox();
            this.comboBoxTargetUnit = new System.Windows.Forms.ComboBox();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.buttonConvertValue = new System.Windows.Forms.Button();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxUnitType.SuspendLayout();
            this.groupBoxSourceUnit.SuspendLayout();
            this.groupBoxTargetUnit.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUnitType
            // 
            this.groupBoxUnitType.Controls.Add(this.comboBoxUnitType);
            this.groupBoxUnitType.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxUnitType.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUnitType.Name = "groupBoxUnitType";
            this.groupBoxUnitType.Size = new System.Drawing.Size(800, 66);
            this.groupBoxUnitType.TabIndex = 0;
            this.groupBoxUnitType.TabStop = false;
            this.groupBoxUnitType.Text = "Rodzaj";
            // 
            // comboBoxUnitType
            // 
            this.comboBoxUnitType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnitType.FormattingEnabled = true;
            this.comboBoxUnitType.Location = new System.Drawing.Point(12, 22);
            this.comboBoxUnitType.Name = "comboBoxUnitType";
            this.comboBoxUnitType.Size = new System.Drawing.Size(782, 23);
            this.comboBoxUnitType.TabIndex = 0;
            this.comboBoxUnitType.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnitType_SelectedIndexChanged);
            // 
            // groupBoxSourceUnit
            // 
            this.groupBoxSourceUnit.Controls.Add(this.comboBoxSourceUnit);
            this.groupBoxSourceUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSourceUnit.Location = new System.Drawing.Point(0, 66);
            this.groupBoxSourceUnit.Name = "groupBoxSourceUnit";
            this.groupBoxSourceUnit.Size = new System.Drawing.Size(800, 66);
            this.groupBoxSourceUnit.TabIndex = 1;
            this.groupBoxSourceUnit.TabStop = false;
            this.groupBoxSourceUnit.Text = "Jednostka źródłowa";
            // 
            // comboBoxSourceUnit
            // 
            this.comboBoxSourceUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSourceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSourceUnit.FormattingEnabled = true;
            this.comboBoxSourceUnit.Location = new System.Drawing.Point(12, 22);
            this.comboBoxSourceUnit.Name = "comboBoxSourceUnit";
            this.comboBoxSourceUnit.Size = new System.Drawing.Size(782, 23);
            this.comboBoxSourceUnit.TabIndex = 0;
            // 
            // groupBoxTargetUnit
            // 
            this.groupBoxTargetUnit.Controls.Add(this.comboBoxTargetUnit);
            this.groupBoxTargetUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTargetUnit.Location = new System.Drawing.Point(0, 132);
            this.groupBoxTargetUnit.Name = "groupBoxTargetUnit";
            this.groupBoxTargetUnit.Size = new System.Drawing.Size(800, 66);
            this.groupBoxTargetUnit.TabIndex = 2;
            this.groupBoxTargetUnit.TabStop = false;
            this.groupBoxTargetUnit.Text = "Jednostka docelowa";
            // 
            // comboBoxTargetUnit
            // 
            this.comboBoxTargetUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTargetUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTargetUnit.FormattingEnabled = true;
            this.comboBoxTargetUnit.Location = new System.Drawing.Point(12, 22);
            this.comboBoxTargetUnit.Name = "comboBoxTargetUnit";
            this.comboBoxTargetUnit.Size = new System.Drawing.Size(782, 23);
            this.comboBoxTargetUnit.TabIndex = 0;
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.buttonConvertValue);
            this.groupBoxValue.Controls.Add(this.numericUpDownValue);
            this.groupBoxValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxValue.Location = new System.Drawing.Point(0, 198);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(800, 100);
            this.groupBoxValue.TabIndex = 3;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Wartość";
            // 
            // buttonConvertValue
            // 
            this.buttonConvertValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConvertValue.Location = new System.Drawing.Point(530, 16);
            this.buttonConvertValue.Name = "buttonConvertValue";
            this.buttonConvertValue.Size = new System.Drawing.Size(164, 78);
            this.buttonConvertValue.TabIndex = 1;
            this.buttonConvertValue.Text = "Przelicz";
            this.buttonConvertValue.UseVisualStyleBackColor = true;
            this.buttonConvertValue.Click += new System.EventHandler(this.buttonConvertValue_Click);
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownValue.Location = new System.Drawing.Point(12, 40);
            this.numericUpDownValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(292, 32);
            this.numericUpDownValue.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelResult);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult.Location = new System.Drawing.Point(0, 298);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(800, 197);
            this.groupBoxResult.TabIndex = 4;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Wynik";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(304, 73);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 45);
            this.labelResult.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxValue);
            this.Controls.Add(this.groupBoxTargetUnit);
            this.Controls.Add(this.groupBoxSourceUnit);
            this.Controls.Add(this.groupBoxUnitType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Fortnite";
            this.groupBoxUnitType.ResumeLayout(false);
            this.groupBoxSourceUnit.ResumeLayout(false);
            this.groupBoxTargetUnit.ResumeLayout(false);
            this.groupBoxValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxUnitType;
        private GroupBox groupBoxSourceUnit;
        private GroupBox groupBoxTargetUnit;
        private GroupBox groupBoxValue;
        private GroupBox groupBoxResult;
        private ComboBox comboBoxUnitType;
        private ComboBox comboBoxSourceUnit;
        private ComboBox comboBoxTargetUnit;
        private Button buttonConvertValue;
        private NumericUpDown numericUpDownValue;
        private Label labelResult;
    }
}