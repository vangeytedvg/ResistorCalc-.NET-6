namespace ResistorCalc {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ComboBands = new System.Windows.Forms.ComboBox();
            this.ComboBand_1 = new System.Windows.Forms.ComboBox();
            this.ComboBand_2 = new System.Windows.Forms.ComboBox();
            this.ComboBand_3 = new System.Windows.Forms.ComboBox();
            this.ComboBand_Tolerance = new System.Windows.Forms.ComboBox();
            this.ComboBand_ColorCof = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kryptonPalette1;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.kryptonPalette1.PalettePaint += new System.EventHandler<ComponentFactory.Krypton.Toolkit.PaletteLayoutEventArgs>(this.kryptonPalette1_PalettePaint);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(125, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Palette = this.kryptonPalette1;
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonLabel1.Size = new System.Drawing.Size(152, 29);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "OHM Calculator";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ResistorCalc.Properties.Resources.ohm;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(125, 49);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(136, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Nr of bands on resistor";
            // 
            // ComboBands
            // 
            this.ComboBands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBands.FormattingEnabled = true;
            this.ComboBands.Location = new System.Drawing.Point(267, 49);
            this.ComboBands.Name = "ComboBands";
            this.ComboBands.Size = new System.Drawing.Size(121, 23);
            this.ComboBands.TabIndex = 7;
            // 
            // ComboBand_1
            // 
            this.ComboBand_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_1.FormattingEnabled = true;
            this.ComboBand_1.Location = new System.Drawing.Point(27, 193);
            this.ComboBand_1.Name = "ComboBand_1";
            this.ComboBand_1.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_1.TabIndex = 8;
            // 
            // ComboBand_2
            // 
            this.ComboBand_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_2.FormattingEnabled = true;
            this.ComboBand_2.Location = new System.Drawing.Point(124, 193);
            this.ComboBand_2.Name = "ComboBand_2";
            this.ComboBand_2.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_2.TabIndex = 9;
            // 
            // ComboBand_3
            // 
            this.ComboBand_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_3.FormattingEnabled = true;
            this.ComboBand_3.Location = new System.Drawing.Point(221, 193);
            this.ComboBand_3.Name = "ComboBand_3";
            this.ComboBand_3.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_3.TabIndex = 10;
            // 
            // ComboBand_Tolerance
            // 
            this.ComboBand_Tolerance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_Tolerance.FormattingEnabled = true;
            this.ComboBand_Tolerance.Location = new System.Drawing.Point(318, 193);
            this.ComboBand_Tolerance.Name = "ComboBand_Tolerance";
            this.ComboBand_Tolerance.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_Tolerance.TabIndex = 12;
            // 
            // ComboBand_ColorCof
            // 
            this.ComboBand_ColorCof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_ColorCof.FormattingEnabled = true;
            this.ComboBand_ColorCof.Location = new System.Drawing.Point(415, 193);
            this.ComboBand_ColorCof.Name = "ComboBand_ColorCof";
            this.ComboBand_ColorCof.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_ColorCof.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 472);
            this.Controls.Add(this.ComboBand_ColorCof);
            this.Controls.Add(this.ComboBand_Tolerance);
            this.Controls.Add(this.ComboBand_3);
            this.Controls.Add(this.ComboBand_2);
            this.Controls.Add(this.ComboBand_1);
            this.Controls.Add(this.ComboBands);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Resistor Value Calculator";
            this.TextExtra = "DenkaTech Software";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComboBox ComboBands;
        private ComboBox ComboBand_1;
        private ComboBox ComboBand_2;
        private ComboBox ComboBand_3;
        private ComboBox ComboBand_Tolerance;
        private ComboBox ComboBand_ColorCof;
    }
}