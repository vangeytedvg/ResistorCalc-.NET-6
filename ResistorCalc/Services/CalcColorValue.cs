using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorCalc.Services {

    /// <summary>
    /// Class containing static conversion functions
    /// </summary>
    internal static class CalcColorValue {

        /// <summary>
        /// Static function to convert colors to resistance values
        /// </summary>
        /// <param name="color">Multiplier Color</param>
        /// <returns>Multiplication value</returns>
        public static float Multiplier(Color color) {
            float multiplyBy = 0;
            if (color == Color.Black) {
                multiplyBy = 1;
            } else if (color == Color.Brown) {
                multiplyBy = 10;
            } else if (color == Color.Red) {
                multiplyBy = 100;
            } else if (color == Color.Orange) {
                multiplyBy = 1000;
            } else if (color == Color.Yellow) {
                multiplyBy = 10000;
            } else if (color == Color.Green) {
                multiplyBy = 100000;
            } else if (color == Color.Blue) {
                multiplyBy = 1000000;
            } else if (color == Color.Violet) {
                multiplyBy = 10000000;
            } else if (color == Color.Gray) {
                multiplyBy = 100000000;
            } else if (color == Color.White) {
                multiplyBy = 1000000000;
            } else if (color == Color.Gold) {
                multiplyBy = 0.1f;
            } else if (color == Color.Silver) {
                multiplyBy = 0.01f;
            }
            return multiplyBy;
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
                tolerance = "+/- 1%(F)";
            } else if (color == Color.Red) {
                tolerance = "+/- 2% (G)";
            } else if (color == Color.Orange) {
                tolerance = "+/- 0.05% (W)";
            } else if (color == Color.Yellow) {
                tolerance = "+/- 0.02% (P)";
            } else if (color == Color.Green) {
                tolerance = "+/- 0.5% (D)";
            } else if (color == Color.Blue) {
                tolerance = "+/- 0.25% (C)";
            } else if (color == Color.Violet) {
                tolerance = "+/- 0.1% (B)";
            } else if (color == Color.Gray) {
                tolerance = "+/- 0.01% (L)";
            } else if (color == Color.White) {
                tolerance = "";
            } else if (color == Color.Gold) {
                tolerance = "+/- 5% (J)";
            } else if (color == Color.Silver) {
                tolerance = "+/- 10% (K)";
            }
            return tolerance;
        }
    }
}
