using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        Double diff = 0;
        ArrayList r1 = new ArrayList();
        double score = 0;
        Random rand = new Random();
        Stopwatch stopWatch = new Stopwatch();
        Stopwatch totalTime = new Stopwatch();
        int timeInt = 0;
        Boolean isReset = false;
        
        


        public Form1()
        {

            InitializeComponent();
         
            label5.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
            win.Visible = false;
            lose.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isReset == true)
            {
                button1.BackColor = Color.Gray;
                button1.Text = "Click Here";
                isReset = false;
            }
            else
            {
                stopWatch.Stop();
                int elapsed = stopWatch.Elapsed.Seconds;

                diff = elapsed - timeInt; // diff between num of seconds and actual click
                r1.Add(diff);
                int elapsedTimeTemp = elapsed;
                if (diff < 0)
                {


                    button1.BackColor = Color.Red;
                    button1.Text = "Too fast!";
                    isReset = true;


                }
                else
                {
                    button1.BackColor = Color.Green;
                    button1.Text = "Good job!";

                    isReset = true;
                    score++;


                }
                totalTime.Stop();
                if (totalTime.Elapsed.Minutes >= 1)
                {
                    button1.Visible = false;
                    label6.Text = "Final Score: " + score.ToString();
                    label5.Visible = false;
                    label6.Visible = true;
                    if (score >= (25 / timeInt))
                    {
                        win.Visible = true;
                        pictureBox2.Visible = true;
                    }
                    else
                    {
                        lose.Visible = true;
                        pictureBox1.Visible = true;
                    }
                }
                else
                {
                    label5.Text = "Score: " + score.ToString();
                    stopWatch.Restart();
                }
                totalTime.Start();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            label5.Visible = true;
            timeInt = rand.Next(1, 4);
            stopWatch.Start();
            totalTime.Start();
            button2.Visible = false;
            intro.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IntroBody_Click(object sender, EventArgs e)
        {

        }

        private void intro_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button1.Text = "Too fast!";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button1.Text = "Click Here";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button1.Text = "Good Job!";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button1.Text = "Click Here";
            stopWatch.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}