using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labTrainerAccount
{
    public partial class Form1 : Form
    {
        private Games g;
        public Form1()
        {
            InitializeComponent();

            g = new Games();
            g.Change += Ebent_Change;
            g.DoReset();

            // Обработка кликов на кнопки. Запускаем метод DoAnswer класса Game. Подаём на вход
            // int значение ответа
            answer1.Click += (sender, e) => g.DoAnswer(Int32.Parse(answer1.Text));
            answer2.Click += (sender, e) => g.DoAnswer(Int32.Parse(answer2.Text));
            answer3.Click += (sender, e) => g.DoAnswer(Int32.Parse(answer3.Text));
            answer4.Click += (sender, e) => g.DoAnswer(Int32.Parse(answer4.Text));
            answer5.Click += (sender, e) => g.DoAnswer(Int32.Parse(answer5.Text));
            //lvlUp.Click += (sender, e) => g.ChangeHard(100);
            //lvlDown.Click += (sender, e) => g.ChangeHard(20);
            goodLabel.Text = String.Format(g.CountCorrect.ToString());
            badLabel.Text = String.Format(g.CountBad.ToString());
            timer1.Start();
            
            
        }

        private void Ebent_Change(object sender, EventArgs e)
        {
            //
            goodLabel.Text = String.Format(g.CountCorrect.ToString());
            badLabel.Text = String.Format(g.CountBad.ToString());
            primer.Text = g.CodeText;
            answer1.Text = g.answer1.ToString();
            answer2.Text = g.answer2.ToString();
            answer3.Text = g.answer3.ToString();
            answer4.Text = g.answer4.ToString();
            answer5.Text = g.answer5.ToString();
        }
        public int timer = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = timer.ToString();
            timer -= 1;
            if (timer == 0)
            {
                MessageBox.Show("Конец. Правильных ответов" + goodLabel.Text + ". Не правильных " + badLabel.Text);
                this.Close();
            }
        }

        private void lvlDown_Click(object sender, EventArgs e)
        {
            g.ChangeHard(20);
            lvlDown.BackColor = Color.GreenYellow;
            lvlUp.BackColor = Color.Gainsboro;
        }

        private void lvlUp_Click(object sender, EventArgs e)
        {
            g.ChangeHard(100);
            lvlDown.BackColor = Color.Gainsboro;
            lvlUp.BackColor = Color.GreenYellow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
