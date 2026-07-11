using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace multiply
{
    public partial class Form2 : Form
    {
        static int a, b, c = 0, ans = 0, score = 0, que = 0;
        int time = 1200, mm = 0, ss = 0;
        Random r = new Random();

        public Form2()
        {
            InitializeComponent();
        }
        public void newQuestion()
        {
            if (que < 20)
            {
                que++;
                label2.Text = "Question : " + que;
                a = r.Next(1, 10);
                b = r.Next(1, 10);
                label3.Text = a.ToString();
                label4.Text = b.ToString();
                c = a * b;
                //   MessageBox.Show("c is : "+c);
            }
            else
            {

                que++;
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                c = 15951;// random
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            newQuestion();
            button1.Text = "Restart";
            score = 0;
            que = 1;
            label2.Text = "Q.1";
            label9.Text = score.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ans = Convert.ToInt32(textBox1.Text);


            if (que <= 20)
            {
                //  MessageBox.Show("ans is : " + ans +"and c is "+c);
                //  MessageBox.Show("c is : " + c);

                if (c == ans)
                {
                    MessageBox.Show("Yesssss,,,,,Correct Answer!!!");
                    score++;
                }
                else
                {
                    MessageBox.Show("Ohhhhhh,,,,,Wrong Answer!!!");
                }

                label9.Text = score.ToString();

                newQuestion();


                textBox1.Text = "0";

            }
            else
            {
                MessageBox.Show("Quiz End.... Click on Restart");

            }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            mm = time / 60;
            ss = time % 60;
            label7.Text = mm + " : " + ss;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
