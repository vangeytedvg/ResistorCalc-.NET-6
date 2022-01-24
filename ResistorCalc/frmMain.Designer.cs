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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ComboBands = new System.Windows.Forms.ComboBox();
            this.ComboBand_1 = new System.Windows.Forms.ComboBox();
            this.ComboBand_2 = new System.Windows.Forms.ComboBox();
            this.ComboBand_3 = new System.Windows.Forms.ComboBox();
            this.ComboBand_4 = new System.Windows.Forms.ComboBox();
            this.ComboBand_5 = new System.Windows.Forms.ComboBox();
            this.lbl1band = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl2band = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl3band = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl4band = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lbl5band = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBand1 = new System.Windows.Forms.PictureBox();
            this.picBand2 = new System.Windows.Forms.PictureBox();
            this.picBand3 = new System.Windows.Forms.PictureBox();
            this.picBand4 = new System.Windows.Forms.PictureBox();
            this.picBand5 = new System.Windows.Forms.PictureBox();
            this.btnCalculateResult = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOhmValue = new System.Windows.Forms.Label();
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
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(109, 20);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(109, 57);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(136, 20);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Nr of bands on resistor";
            // 
            // ComboBands
            // 
            this.ComboBands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBands.FormattingEnabled = true;
            this.ComboBands.Location = new System.Drawing.Point(251, 57);
            this.ComboBands.Name = "ComboBands";
            this.ComboBands.Size = new System.Drawing.Size(121, 23);
            this.ComboBands.TabIndex = 7;
            this.ComboBands.SelectedIndexChanged += new System.EventHandler(this.ComboBands_SelectedIndexChanged);
            // 
            // ComboBand_1
            // 
            this.ComboBand_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_1.FormattingEnabled = true;
            this.ComboBand_1.Location = new System.Drawing.Point(27, 140);
            this.ComboBand_1.Name = "ComboBand_1";
            this.ComboBand_1.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_1.TabIndex = 8;
            this.ComboBand_1.SelectedIndexChanged += new System.EventHandler(this.ComboBand_1_SelectedIndexChanged);
            // 
            // ComboBand_2
            // 
            this.ComboBand_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_2.FormattingEnabled = true;
            this.ComboBand_2.Location = new System.Drawing.Point(124, 140);
            this.ComboBand_2.Name = "ComboBand_2";
            this.ComboBand_2.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_2.TabIndex = 9;
            this.ComboBand_2.SelectedIndexChanged += new System.EventHandler(this.ComboBand_2_SelectedIndexChanged);
            // 
            // ComboBand_3
            // 
            this.ComboBand_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_3.FormattingEnabled = true;
            this.ComboBand_3.Location = new System.Drawing.Point(221, 140);
            this.ComboBand_3.Name = "ComboBand_3";
            this.ComboBand_3.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_3.TabIndex = 10;
            this.ComboBand_3.SelectedIndexChanged += new System.EventHandler(this.ComboBand_3_SelectedIndexChanged);
            // 
            // ComboBand_4
            // 
            this.ComboBand_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_4.FormattingEnabled = true;
            this.ComboBand_4.Location = new System.Drawing.Point(318, 140);
            this.ComboBand_4.Name = "ComboBand_4";
            this.ComboBand_4.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_4.TabIndex = 12;
            this.ComboBand_4.SelectedIndexChanged += new System.EventHandler(this.ComboBand_4_SelectedIndexChanged);
            // 
            // ComboBand_5
            // 
            this.ComboBand_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBand_5.FormattingEnabled = true;
            this.ComboBand_5.Location = new System.Drawing.Point(415, 140);
            this.ComboBand_5.Name = "ComboBand_5";
            this.ComboBand_5.Size = new System.Drawing.Size(91, 23);
            this.ComboBand_5.TabIndex = 13;
            this.ComboBand_5.SelectedIndexChanged += new System.EventHandler(this.ComboBand_5_SelectedIndexChanged);
            // 
            // lbl1band
            // 
            this.lbl1band.Location = new System.Drawing.Point(27, 114);
            this.lbl1band.Name = "lbl1band";
            this.lbl1band.Palette = this.kryptonPalette1;
            this.lbl1band.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.lbl1band.Size = new System.Drawing.Size(58, 20);
            this.lbl1band.TabIndex = 14;
            this.lbl1band.Values.Text = "1st Band";
            // 
            // lbl2band
            // 
            this.lbl2band.Location = new System.Drawing.Point(125, 114);
            this.lbl2band.Name = "lbl2band";
            this.lbl2band.Size = new System.Drawing.Size(62, 20);
            this.lbl2band.TabIndex = 15;
            this.lbl2band.Values.Text = "2nd Band";
            // 
            // lbl3band
            // 
            this.lbl3band.Location = new System.Drawing.Point(221, 114);
            this.lbl3band.Name = "lbl3band";
            this.lbl3band.Size = new System.Drawing.Size(60, 20);
            this.lbl3band.TabIndex = 16;
            this.lbl3band.Values.Text = "3rd Band";
            // 
            // lbl4band
            // 
            this.lbl4band.Location = new System.Drawing.Point(318, 114);
            this.lbl4band.Name = "lbl4band";
            this.lbl4band.Size = new System.Drawing.Size(59, 20);
            this.lbl4band.TabIndex = 17;
            this.lbl4band.Values.Text = "4th Band";
            // 
            // lbl5band
            // 
            this.lbl5band.Location = new System.Drawing.Point(415, 114);
            this.lbl5band.Name = "lbl5band";
            this.lbl5band.Size = new System.Drawing.Size(59, 20);
            this.lbl5band.TabIndex = 18;
            this.lbl5band.Values.Text = "5th Band";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ResistorCalc.Properties.Resources.resistor;
            this.pictureBox2.Location = new System.Drawing.Point(115, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(298, 71);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // picBand1
            // 
            this.picBand1.Location = new System.Drawing.Point(188, 205);
            this.picBand1.Name = "picBand1";
            this.picBand1.Size = new System.Drawing.Size(16, 59);
            this.picBand1.TabIndex = 20;
            this.picBand1.TabStop = false;
            // 
            // picBand2
            // 
            this.picBand2.Location = new System.Drawing.Point(213, 210);
            this.picBand2.Name = "picBand2";
            this.picBand2.Size = new System.Drawing.Size(14, 49);
            this.picBand2.TabIndex = 21;
            this.picBand2.TabStop = false;
            // 
            // picBand3
            // 
            this.picBand3.Location = new System.Drawing.Point(237, 210);
            this.picBand3.Name = "picBand3";
            this.picBand3.Size = new System.Drawing.Size(14, 49);
            this.picBand3.TabIndex = 22;
            this.picBand3.TabStop = false;
            // 
            // picBand4
            // 
            this.picBand4.Location = new System.Drawing.Point(261, 210);
            this.picBand4.Name = "picBand4";
            this.picBand4.Size = new System.Drawing.Size(14, 49);
            this.picBand4.TabIndex = 23;
            this.picBand4.TabStop = false;
            // 
            // picBand5
            // 
            this.picBand5.Location = new System.Drawing.Point(311, 210);
            this.picBand5.Name = "picBand5";
            this.picBand5.Size = new System.Drawing.Size(14, 49);
            this.picBand5.TabIndex = 24;
            this.picBand5.TabStop = false;
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.AutoSize = true;
            this.btnCalculateResult.Location = new System.Drawing.Point(191, 283);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(149, 38);
            this.btnCalculateResult.TabIndex = 25;
            this.btnCalculateResult.Values.Image = global::ResistorCalc.Properties.Resources.calculator;
            this.btnCalculateResult.Values.Text = "Calculate";
            this.btnCalculateResult.Click += new System.EventHandler(this.btnCalculateResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1034, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // lblOhmValue
            // 
            this.lblOhmValue.AutoSize = true;
            this.lblOhmValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOhmValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblOhmValue.Location = new System.Drawing.Point(115, 172);
            this.lblOhmValue.Name = "lblOhmValue";
            this.lblOhmValue.Size = new System.Drawing.Size(18, 20);
            this.lblOhmValue.TabIndex = 27;
            this.lblOhmValue.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 333);
            this.Controls.Add(this.lblOhmValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculateResult);
            this.Controls.Add(this.picBand5);
            this.Controls.Add(this.picBand4);
            this.Controls.Add(this.picBand3);
            this.Controls.Add(this.picBand2);
            this.Controls.Add(this.picBand1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl5band);
            this.Controls.Add(this.lbl4band);
            this.Controls.Add(this.lbl3band);
            this.Controls.Add(this.lbl2band);
            this.Controls.Add(this.lbl1band);
            this.Controls.Add(this.ComboBand_5);
            this.Controls.Add(this.ComboBand_4);
            this.Controls.Add(this.ComboBand_3);
            this.Controls.Add(this.ComboBand_2);
            this.Controls.Add(this.ComboBand_1);
            this.Controls.Add(this.ComboBands);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 400);
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
        private ComboBox ComboBand_4;
        private ComboBox ComboBand_5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl1band;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl2band;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl3band;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl4band;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl5band;
        private PictureBox pictureBox2;
        private PictureBox picBand1;
        private PictureBox picBand2;
        private PictureBox picBand3;
        private PictureBox picBand4;
        private PictureBox picBand5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCalculateResult;
        private Label label1;
        private Label lblOhmValue;
    }
}