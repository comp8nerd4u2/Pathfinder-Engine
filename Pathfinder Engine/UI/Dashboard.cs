using Pathfinder_Engine.UI.Character_Creation;
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
    public partial class Dashboard : Form {
        public Dashboard() {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void PathfinderEngineDashboard_Load(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void Dashboard_Load(object sender, EventArgs e) {
            outputLevelOption.SelectedItem = "Debug";
        }

        private void diceToolStripMenuItem_Click(object sender, EventArgs e) {
            UIGateway.SpawnDiceTool();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form2 = new Create();
            form2.Show();
        }
    }
}
