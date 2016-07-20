using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Engine.UI.Character_Creation
{
    public partial class Create : Form
    {
       

        public Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Class = textBox2.Text;
            int Level = int.Parse(textBox3.Text);
            string Race = textBox4.Text;
            int Str = int.Parse(textBox5.Text);
            int Dex = int.Parse(textBox6.Text);
            int Con = int.Parse(textBox7.Text);
            int Int = int.Parse(textBox8.Text);
            int Wis = int.Parse(textBox9.Text);
            int Cha = int.Parse(textBox10.Text);

            Console.WriteLine(Name);
            Console.WriteLine(Class);
            Console.WriteLine(Level);
            Console.WriteLine(Race);
            Console.WriteLine(Str);
            Console.WriteLine(Dex);
            Console.WriteLine(Con);
            Console.WriteLine(Int);
            Console.WriteLine(Wis);
            Console.WriteLine(Cha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    
    }
}
