using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorCalc {
    internal static class CalcColorValue {
        public static int ConvertColorToValue(Color color) {
            int digit = 0;
            if (color == Color.Black) {
                digit = 1;
            } else if (color == Color.Brown) {
                digit = 10;
            } else if (color == Color.Red) {
                digit = 100;
            } else if (color == Color.Orange) {
                digit = 1000;
            } else if (color == Color.Yellow) {
                digit = 10000;
            } else if (color == Color.Green) {
                digit = 100000;
            } else if (color == Color.Blue) {
                digit = 1000000;
            } else if (color == Color.Violet) {
                digit = 10000000;
            } else if (color == Color.Gray) {
                digit = 100000000;
            } else if (color == Color.Gray) {
                digit = 1000000000;
            }
            return digit;
        }
    }
}
