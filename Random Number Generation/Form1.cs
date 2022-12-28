using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Generation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            LCG lcg = new LCG(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text),
                                                                    int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            lcg.GenerateSequence();
            label7.Text = lcg.cycleLen.ToString();
            List<RandomNumber> randomNumberList = new List<RandomNumber>();
            for (int i = 0; i < int.Parse(textBox5.Text); i++)
            {
                RandomNumber randomNumber = new RandomNumber(lcg.sequence[i]);
                randomNumberList.Add(randomNumber);
            }
           
            dataGridView1.DataSource = randomNumberList;


        }
         
    }
    public class RandomNumber
    {


        public int randomNumber { get; set; }
        public RandomNumber(int randomNum)
        {
            randomNumber = randomNum;
        }
      
  
    }
}
