using ComponentFactory.Krypton.Toolkit;
using ResistorCalc.Models;
using System.Drawing.Text;

namespace ResistorCalc {
    public partial class frmMain : KryptonForm {

        private const int MarginWidth = 4;
        private const int MarginHeight = 4;

        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            // Band count determinator
            ComboBands.Items.Add(new ComboBandItem(3, "3 Band"));
            ComboBands.Items.Add(new ComboBandItem(4, "4 Band"));
            ComboBands.Items.Add(new ComboBandItem(5, "5 Band"));
            ComboBands.Items.Add(new ComboBandItem(6, "6 Band"));

            // Colors for normal bands
            Color[] colors = new Color[9];
            colors[0] = Color.Black;
            colors[1] = Color.Brown;
            colors[2] = Color.Red;
            colors[3] = Color.Orange;
            colors[4] = Color.Yellow;
            colors[5] = Color.Green;
            colors[6] = Color.Blue;
            colors[7] = Color.Violet;
            colors[8] = Color.Gray;
            colors[8] = Color.White;

            // Tolerance %
            Color[] toleranceColors = new Color[2];
            toleranceColors[0] = Color.Gold;
            toleranceColors[1] = Color.Silver;




            // Set the combos
            DisplayColorSamples(this.ComboBand_1, colors);
            DisplayColorSamples(this.ComboBand_2, colors);
            DisplayColorSamples(this.ComboBand_3, colors);            
            DisplayColorSamples(this.ComboBand_Tolerance, toleranceColors);
            DisplayColorSamples(this.ComboBand_ColorCof, colors);
            
        }

        private void kryptonPalette1_PalettePaint(object sender, PaletteLayoutEventArgs e) {

        }

        // Set up the ComboBox to display color samples and their names.
        private void DisplayColorSamples(ComboBox cbo, Color[] colors) {
            // Make the ComboBox owner-drawn.
            cbo.DrawMode = DrawMode.OwnerDrawFixed;

            // Add the colors to the ComboBox's items.
            cbo.Items.Clear();
            foreach (Color color in colors) cbo.Items.Add(color);

            // Subscribe to the DrawItem event.
            cbo.DrawItem += cboColorSample_DrawItem;
        }


        // Draw a ComboBox item that is displaying a color sample
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
            ComboBox cbo = sender as ComboBox;
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
                    e.Graphics.DrawString(color.Name, font,
                        Brushes.Black, x, y, sf);
                }
            }

            // Draw the focus rectangle if appropriate.
            e.DrawFocusRectangle();
        }

    }
}