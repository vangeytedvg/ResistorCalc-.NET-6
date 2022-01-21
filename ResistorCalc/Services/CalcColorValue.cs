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
        /// <param name="color"></param>
        /// <returns></returns>
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
    }
}
