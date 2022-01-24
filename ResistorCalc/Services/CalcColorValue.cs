using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorCalc.Services {

    public class MultiPSymbol {
        public float Multiplier { get; set; }
        public string Symbol { get; set; }
    }

    /// <summary>
    /// Class containing static conversion functions
    /// </summary>
    internal static class CalcColorValue {

        /// <summary>
        /// Static function to convert colors to resistance values
        /// </summary>
        /// <param name="color">Multiplier Color</param>
        /// <returns>Multiplication value</returns>
        public static MultiPSymbol Multiplier(Color color) {
            MultiPSymbol mp = new MultiPSymbol();
            mp.Multiplier = 0.0f;
            mp.Symbol = "";
            if (color == Color.Black) {
                mp.Multiplier = 1;
                mp.Symbol = "Ω";
            } else if (color == Color.Brown) {                
                mp.Multiplier = 10;
                mp.Symbol = "Ω";
            } else if (color == Color.Red) {                
                mp.Multiplier = 100;
                mp.Symbol = "Ω";
            } else if (color == Color.Orange) {                
                mp.Multiplier = 1;
                mp.Symbol = "k Ω";
            } else if (color == Color.Yellow) {
                mp.Multiplier = 10;
                mp.Symbol = "k Ω";
            } else if (color == Color.Green) {                
                mp.Multiplier = 100;
                mp.Symbol = "k Ω";
            } else if (color == Color.Blue) {                
                mp.Multiplier = 1;
                mp.Symbol = "M Ω";
            } else if (color == Color.Violet) {                
                mp.Multiplier = 10;
                mp.Symbol = "M Ω";
            } else if (color == Color.Gray) {                
                mp.Multiplier = 100;
                mp.Symbol = "M Ω";
            } else if (color == Color.White) {
                mp.Multiplier = 1;
                mp.Symbol = "G Ω";
            } else if (color == Color.Gold) {                
                mp.Multiplier = 0.1f;
                mp.Symbol = "Ω";
            } else if (color == Color.Silver) {
                mp.Multiplier = 0.01f; ;
                mp.Symbol = "Ω";
            }
            return mp;
        }        

        /// <summary>
        /// Determine the tolerance for a given color
        /// </summary>
        /// <param name="color">Color value</param>
        /// <returns>Tolerance string</returns>
        public static string Tolerance(Color color) {
            string tolerance = "";
            if (color == Color.Black) {
                tolerance = "";
            } else if (color == Color.Brown) {
                tolerance = "± 1%(F)";
            } else if (color == Color.Red) {
                tolerance = "± 2% (G)";
            } else if (color == Color.Orange) {
                tolerance = "± 0.05% (W)";
            } else if (color == Color.Yellow) {
                tolerance = "± 0.02% (P)";
            } else if (color == Color.Green) {
                tolerance = "± 0.5% (D)";
            } else if (color == Color.Blue) {
                tolerance = "± 0.25% (C)";
            } else if (color == Color.Violet) {
                tolerance = "± 0.1% (B)";
            } else if (color == Color.Gray) {
                tolerance = "± 0.01% (L)";
            } else if (color == Color.White) {
                tolerance = "";
            } else if (color == Color.Gold) {
                tolerance = "± 5% (J)";
            } else if (color == Color.Silver) {
                tolerance = "± 10% (K)";
            }
            return tolerance;
        }
    }
}
