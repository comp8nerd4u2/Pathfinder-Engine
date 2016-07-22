using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
        //"Create"    
        private void button1_Click(object sender, EventArgs e)
        {
            //Create character object
            CharacterObject chara = new CharacterObject();

            chara.Name = textBox1.Text;
            chara.Class = textBox2.Text;
            chara.Level = int.Parse(textBox3.Text);
            chara.Race = textBox4.Text;
            chara.Str = int.Parse(textBox5.Text);
            chara.Dex = int.Parse(textBox6.Text);
            chara.Con = int.Parse(textBox7.Text);
            chara.Int = int.Parse(textBox8.Text);
            chara.Wis = int.Parse(textBox9.Text);
            chara.Cha = int.Parse(textBox10.Text);

            //Opens a file and serializes the object into it 
            XmlSerializer writer = new XmlSerializer(typeof(CharacterObject));

            
            var userPath = @"..\..\Characters\" + chara.Name + ".xml";
            //Console.WriteLine(userPath);
            FileStream file = File.Create(userPath);

            writer.Serialize(file, chara);
            file.Close(); 

            this.Close();

            //Empties obj.
            chara = null;

        }
        //"Close"
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

        [Serializable()]
        public class CharacterObject
        {
            public string Name;
            public string Class;
            public int Level;
            public string Race;
            public int Str;
            public int Dex;
            public int Con;
            public int Int;
            public int Wis;
            public int Cha;

        }

       }
    }
