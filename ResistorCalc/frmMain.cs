using ComponentFactory.Krypton.Toolkit;
using ResistorCalc.Models;
using ResistorCalc.Services;
using System.Drawing.Text;

namespace ResistorCalc {
    public partial class frmMain : KryptonForm {

        /// <summary>
        /// Resistor type enumeration
        /// </summary>
        enum ResistorType : int {
            Band3 = 3,
            Band4 = 4,
            Band5 = 5,            
        }

        private int CalcMode { get; set; }

        // Constant for the margins of the color squares in the combo boxes
        private const int MarginWidth = 2;
        private const int MarginHeight = 2;

        public frmMain() {
            InitializeComponent();
        }

        private void ClearBand(ComboBox cbo) {
            cbo.Items.Clear();
        }

        /// <summary>
        /// Normal color bands
        /// </summary>
        /// <param name="cbo"></param>
        private void NormalColorBands(ComboBox cbo) {
            Color[] colors = new Color[10];
            colors[0] = Color.Black;
            colors[1] = Color.Brown;
            colors[2] = Color.Red;
            colors[3] = Color.Orange;
            colors[4] = Color.Yellow;
            colors[5] = Color.Green;
            colors[6] = Color.Blue;
            colors[7] = Color.Violet;
            colors[8] = Color.Gray;
            colors[9] = Color.White;
            DisplayColorSamples(cbo, colors);
        }

        private void MultiplierColorBands(ComboBox cbo) {
            // Multiplier band
            Color[] multiPlierColors = new Color[12];
            multiPlierColors[0] = Color.Black;
            multiPlierColors[1] = Color.Brown;
            multiPlierColors[2] = Color.Red;
            multiPlierColors[3] = Color.Orange;
            multiPlierColors[4] = Color.Yellow;
            multiPlierColors[5] = Color.Green;
            multiPlierColors[6] = Color.Blue;
            multiPlierColors[7] = Color.Violet;
            multiPlierColors[8] = Color.Gray;
            multiPlierColors[9] = Color.White;
            multiPlierColors[10] = Color.Gold;
            multiPlierColors[11] = Color.Silver;
            DisplayColorSamples(cbo, multiPlierColors);
        }

        private void ToleranceColorBands(ComboBox cbo) {
            Color[] toleranceColors = new Color[11];
            toleranceColors[0] = Color.Black;
            toleranceColors[1] = Color.Brown;
            toleranceColors[2] = Color.Red;
            toleranceColors[3] = Color.Orange;
            toleranceColors[4] = Color.Yellow;
            toleranceColors[5] = Color.Green;
            toleranceColors[6] = Color.Blue;
            toleranceColors[7] = Color.Violet;
            toleranceColors[8] = Color.Gray;
            toleranceColors[9] = Color.Gold;
            toleranceColors[10] = Color.Silver;
            DisplayColorSamples(cbo, toleranceColors);
        }

        /// <summary>
        /// Setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e) {
            // Band count determinator
            ComboBands.Items.Add(new ComboBandItem(3, "3 Band"));
            ComboBands.Items.Add(new ComboBandItem(4, "4 Band"));
            ComboBands.Items.Add(new ComboBandItem(5, "5 Band"));                       
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e) {

        }

        /// <summary>
        /// Set up the ComboBox to display color samples and their names.
        /// </summary>
        /// <param name="cbo"></param>
        /// <param name="colors"></param>       
        private void DisplayColorSamples(ComboBox cbo, Color[] colors) {

            cbo.DrawItem -= cboColorSample_DrawItem;

            // Make the ComboBox owner-drawn.
            cbo.DrawMode = DrawMode.OwnerDrawFixed;

            // Add the colors to the ComboBox's items.
            cbo.Items.Clear();
            foreach (Color color in colors) cbo.Items.Add(color);

            // Subscribe to the DrawItem event.
            cbo.DrawItem += cboColorSample_DrawItem;
        }

        /// <summary>
        /// Draw a ComboBox item that is displaying a color sample
        /// </summary>         
        private void cboColorSample_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index < 0) return;

            // Clear the background appropriately.
            e.DrawBackground();

            // Draw the color sample.
            int hgt = e.Bounds.Height - 2 * MarginHeight;
            Rectangle rect = new Rectangle(
                e.Bounds.X + MarginWidth,
                e.Bounds.Y + MarginHeight,
                hgt, hgt);
            ComboBox cbo = (ComboBox)sender;
            Color color = (Color)cbo.Items[e.Index];
            using (SolidBrush brush = new SolidBrush(color)) {
                e.Graphics.FillRectangle(brush, rect);
            }

            // Outline the sample in black.
            e.Graphics.DrawRectangle(Pens.Black, rect);

            // Draw the color's name to the right.
            using (Font font = new Font(cbo.Font.FontFamily,
                cbo.Font.Size * 0.90f, FontStyle.Bold)) {
                using (StringFormat sf = new StringFormat()) {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    int x = hgt + 2 * MarginWidth;
                    int y = e.Bounds.Y + e.Bounds.Height / 2;
                    e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    // Added +2 to 'x' here to give a little more space between
                    // the colored square and the text. DVG
                    e.Graphics.DrawString(color.Name, font, Brushes.Black, x+2, y, sf);
                }
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

        private void ComboBand_1_SelectedIndexChanged(object sender, EventArgs e) {
            Color k = (Color)ComboBand_1.SelectedItem;
            picBand1.BackColor = k;
        }

        private void ComboBand_2_SelectedIndexChanged(object sender, EventArgs e) {
            Color k = (Color)ComboBand_2.SelectedItem;
            picBand2.BackColor = k;
        }

        private void ComboBand_3_SelectedIndexChanged(object sender, EventArgs e) {
            Color k = (Color)ComboBand_3.SelectedItem;
            picBand3.BackColor = k;
        }

        private void ComboBand_4_SelectedIndexChanged(object sender, EventArgs e) {
            Color k = (Color)ComboBand_4.SelectedItem;
            if (CalcMode == 4) {
                picBand5.BackColor = k;
            } else if (CalcMode == 5) {
                picBand4.BackColor = k;
            }
        }

        private void ComboBand_5_SelectedIndexChanged(object sender, EventArgs e) {
            Color k = (Color)ComboBand_5.SelectedItem;
            picBand5.BackColor = k;
        }

        /// <summary>
        /// User selects a resistor type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBands_SelectedIndexChanged(object sender, EventArgs e) {
            // Reset band colors
            picBand1.BackColor = Color.White;
            picBand2.BackColor = Color.White;
            picBand3.BackColor = Color.White;
            picBand4.BackColor = Color.White;
            picBand5.BackColor = Color.White;            
            ComboBandItem b = (ComboBandItem)ComboBands.SelectedItem;
            switch (b.Value) {
                case (int)ResistorType.Band3:
                    CalcMode = (int)ResistorType.Band3;    // Calculation modes
                    Prepare3Bands();
                    break;
                case (int)ResistorType.Band4:
                    CalcMode = (int)ResistorType.Band4;
                    Prepare4Bands();
                    break;
                case (int)ResistorType.Band5:
                    CalcMode = (int)ResistorType.Band5;
                    Prepare5Bands();
                    break;
            }
        }

        /// <summary>
        /// 5 bands resistor
        /// </summary>
        private void Prepare5Bands() {
            // Bands activation/deactivation            
            ComboBand_3.Enabled = true;
            ComboBand_4.Enabled = true;
            ComboBand_5.Enabled = true;
            // Adapt labels
            lbl3band.Text = "3d band";
            lbl4band.Text = "Mulitplier";
            lbl5band.Text = "Tolerance";
            // Set band colors
            ClearBand(ComboBand_4);
            ClearBand(ComboBand_5);
            NormalColorBands(ComboBand_1);
            NormalColorBands(ComboBand_2);
            NormalColorBands(ComboBand_3);
            MultiplierColorBands(ComboBand_4);
            ToleranceColorBands(ComboBand_5);
        }

        /// <summary>
        /// 4 bands resistor settings
        /// </summary>
        private void Prepare4Bands() {
            // Bands activation/deactivation            
            ComboBand_3.Enabled = true;
            ComboBand_4.Enabled = true;
            ComboBand_5.Enabled = false;
            // Adapt labels
            lbl3band.Text = "Multiplier";
            lbl4band.Text = "Tolerance";
            lbl5band.Text = "Not used";
            // Set band colors
            ClearBand(ComboBand_4);
            ClearBand(ComboBand_5);

            NormalColorBands(ComboBand_1);
            NormalColorBands(ComboBand_2);
            MultiplierColorBands(ComboBand_3);
            ToleranceColorBands(ComboBand_4);
        }

        /// <summary>
        /// 3 Bands resistor layout
        /// </summary>
        private void Prepare3Bands() {      
            // Disable unused bands
            ComboBand_4.Enabled = false;
            ComboBand_5.Enabled = false;
            // Adapt labels
            lbl3band.Text = "Multiplier";
            lbl4band.Text = "Not used";
            lbl5band.Text = "Not used";
            // Set the bands
            NormalColorBands(ComboBand_1);
            NormalColorBands(ComboBand_2);
            MultiplierColorBands(ComboBand_3);
            ClearBand(ComboBand_4);
            ClearBand(ComboBand_5);
        }

        private void btnCalculateResult_Click(object sender, EventArgs e) {
            int value = 0;
            switch(CalcMode) {
                case 3:
                    // 3 Color resistor
                    CalculateThreeBandResistor();
                    break;
                case 4:
                    CalculateFourBandResistor();
                    // 4 Color resistor
                    break;                    
                case 5:
                    // 5 Color resistor
                    CalculateFiveBandResistor();
                    break;
            }
        }

        /// <summary>
        /// 5 band resistor calculation
        /// </summary>
        private void CalculateFiveBandResistor() {
            int b1 = ComboBand_1.SelectedIndex;
            int b2 = ComboBand_2.SelectedIndex;
            int b3 = ComboBand_3.SelectedIndex;
            string cv = b1.ToString() + b2.ToString() + b2.ToString();

            MultiPSymbol multiply = CalcColorValue.Multiplier((Color)ComboBand_4.SelectedItem);
            float resist = multiply.Multiplier * Int32.Parse(cv);
            //resist = resist / multiply.Multiplier;                            
            lblOhmValue.Text = resist.ToString() + " " + multiply.Symbol + " " + CalcColorValue.Tolerance((Color)ComboBand_5.SelectedItem); ;
        }

        /// <summary>
        /// 4 band resistor calculation
        /// </summary>
        private void CalculateFourBandResistor() {
            int b1 = ComboBand_1.SelectedIndex;
            int b2 = ComboBand_2.SelectedIndex;
            string cv = b1.ToString() + b2.ToString();

            MultiPSymbol multiply = CalcColorValue.Multiplier((Color)ComboBand_3.SelectedItem);
            float resist = multiply.Multiplier * Int32.Parse(cv);
            //resist = resist / multiply.Multiplier;                            
            lblOhmValue.Text = resist.ToString() + " " + multiply.Symbol + " " + CalcColorValue.Tolerance((Color)ComboBand_4.SelectedItem); 
        }

        /// <summary>
        /// 3 band resitor calculation
        /// </summary>
        private void CalculateThreeBandResistor() {
            int b1 = ComboBand_1.SelectedIndex;
            int b2 = ComboBand_2.SelectedIndex;
            string cv = b1.ToString() + b2.ToString();
            
            MultiPSymbol multiply = CalcColorValue.Multiplier((Color)ComboBand_3.SelectedItem);
            float resist = multiply.Multiplier * Int32.Parse(cv);
            //resist = resist / multiply.Multiplier;                            
            lblOhmValue.Text = resist.ToString() + " " + multiply.Symbol;
        }
    }
}