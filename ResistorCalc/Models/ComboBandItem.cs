using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorCalc.Models {
    /// <summary>
    /// Combobox custom item
    /// </summary>
    internal class ComboBandItem {
        public ComboBandItem(int value, string text) {
            Value = value;
            Text = text;
        }
        public int Value { get; set; }
        public string? Text { get; set; }

        public override string ToString() {
            return Text;
        }
    }
}
