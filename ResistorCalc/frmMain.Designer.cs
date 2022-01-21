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
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBand1 = new System.Windows.Forms.PictureBox();
            this.picBand2 = new System.Windows.Forms.PictureBox();
            this.picBand3 = new System.Windows.Forms.PictureBox();
            this.picBand4 = new System.Windows.Forms.PictureBox();
            this.picBand5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand5)).BeginInit();
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
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(27, 167);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(58, 20);
            this.kryptonLabel3.TabIndex = 14;
            this.kryptonLabel3.Values.Text = "1st Band";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(125, 167);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(62, 20);
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "2nd Band";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(221, 167);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel5.TabIndex = 16;
            this.kryptonLabel5.Values.Text = "3rd Band";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(318, 167);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel6.TabIndex = 17;
            this.kryptonLabel6.Values.Text = "4th Band";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(415, 167);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(59, 20);
            this.kryptonLabel7.TabIndex = 18;
            this.kryptonLabel7.Values.Text = "5th Band";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ResistorCalc.Properties.Resources.resistor;
            this.pictureBox2.Location = new System.Drawing.Point(115, 238);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 71);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // picBand1
            // 
            this.picBand1.Location = new System.Drawing.Point(188, 244);
            this.picBand1.Name = "picBand1";
            this.picBand1.Size = new System.Drawing.Size(16, 59);
            this.picBand1.TabIndex = 20;
            this.picBand1.TabStop = false;
            // 
            // picBand2
            // 
            this.picBand2.Location = new System.Drawing.Point(213, 249);
            this.picBand2.Name = "picBand2";
            this.picBand2.Size = new System.Drawing.Size(14, 49);
            this.picBand2.TabIndex = 21;
            this.picBand2.TabStop = false;
            // 
            // picBand3
            // 
            this.picBand3.Location = new System.Drawing.Point(237, 249);
            this.picBand3.Name = "picBand3";
            this.picBand3.Size = new System.Drawing.Size(14, 49);
            this.picBand3.TabIndex = 22;
            this.picBand3.TabStop = false;
            // 
            // picBand4
            // 
            this.picBand4.Location = new System.Drawing.Point(261, 249);
            this.picBand4.Name = "picBand4";
            this.picBand4.Size = new System.Drawing.Size(14, 49);
            this.picBand4.TabIndex = 23;
            this.picBand4.TabStop = false;
            // 
            // picBand5
            // 
            this.picBand5.Location = new System.Drawing.Point(311, 249);
            this.picBand5.Name = "picBand5";
            this.picBand5.Size = new System.Drawing.Size(14, 49);
            this.picBand5.TabIndex = 24;
            this.picBand5.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 333);
            this.Controls.Add(this.picBand5);
            this.Controls.Add(this.picBand4);
            this.Controls.Add(this.picBand3);
            this.Controls.Add(this.picBand2);
            this.Controls.Add(this.picBand1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBand5)).EndInit();
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
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private PictureBox pictureBox2;
        private PictureBox picBand1;
        private PictureBox picBand2;
        private PictureBox picBand3;
        private PictureBox picBand4;
        private PictureBox picBand5;
    }
}