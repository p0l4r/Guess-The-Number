using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int randomNumber;
        int score;
        bool flag = false;
        int inputNumber;

        private void label1_Click(object sender, EventArgs e)
        {
     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputNumber = int.Parse(textBox1.Text);
            if (inputNumber <= 0)
            {
                label1.Text = "Choose between 1-100!";
                label2.Text = "Score: " + (score).ToString();
            }
            else
            {
                if ((inputNumber > randomNumber) && (score > 0))
                {
                    score -= 10;
                    label1.Text = "Too High!!";
                    label2.Text = "Score: " + (score).ToString();
                }
                else if ((inputNumber < randomNumber) && (score > 0))
                {
                    score -= 10;
                    label1.Text = "Too Low!";
                    label2.Text = "Score: " + (score).ToString();
                }
                else if ((inputNumber == randomNumber) && (score > 0))
                {
                    label1.Text = "Correct Guess!";
                    label2.Text = "Score: " + (score).ToString();
                }
                else
                {
                    label1.Text = "You Loose!";
                    label2.Text = "Score: " + (score).ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 100);
            score = 100;
            flag = false;
            textBox1.Text = "";
            if (flag == false)
            {
                label1.Text = "Guess Any Number From 1-100!  ";
                label2.Text = "Score: 100";
            }
            else
            {
                label1.Text = (randomNumber).ToString();
                flag = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 100);
            score = 100;
            if (flag == false)
            {
                label1.Text = "Guess Any Number From 1-100!  ";
                label2.Text = "Score: 100";
            }
            else
            {
                label1.Text = (randomNumber).ToString();
                flag = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }
    }
}
