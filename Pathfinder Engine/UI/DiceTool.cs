using Pathfinder_Engine.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Engine.UI {
    public partial class DiceTool : Form {
        Dice dice;

        public DiceTool() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void DiceTool_Load(object sender, EventArgs e) {
            dice = new Dice((int)sidesOption.Value, Dice.Round.UP);
            roundOption.SelectedItem = "UP";
        }

        private void rollButton_Click(object sender, EventArgs e) {
            int result = dice.Roll();
            resultDisplay.Text = result.ToString();
        }

        private void sidesOption_ValueChanged(object sender, EventArgs e) {
            dice.Sides = (int)sidesOption.Value;
        }

        private void roundOption_SelectedIndexChanged(object sender, EventArgs e) {
            if (roundOption.SelectedItem.Equals("UP"))
                dice.RoundingBehaviour = Dice.Round.UP;
            else
                dice.RoundingBehaviour = Dice.Round.DOWN;
        }
    }
}
