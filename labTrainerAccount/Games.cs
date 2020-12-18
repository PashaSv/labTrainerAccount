using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTrainerAccount
{
    class Games
    {
        public int CountCorrect { get; protected set; }
        public int CountBad { get; protected set; }
        // Храним переменную, от которой зависит верный ответ
        public int RightAnswer { get; protected set; }
        // Верный ответ
        public int AnswerCorrect { get; protected set; }
        // Ответы для каждой кнопки
        public int answer1 { get; protected set; }
        public int answer2 { get; protected set; }
        public int answer3 { get; protected set; }
        public int answer4 { get; protected set; }
        public int answer5 { get; protected set; }
        // Текст задачи
        public string CodeText { get; protected set; }

        public event EventHandler Change;

        public void DoReset()
        {
            CountCorrect = 0;
            CountBad = 0;
            DoCountinue();
        }
        // Верхняя граница рандома
        public int a = 20; 
        // Изменяем сложность
        public void ChangeHard(int value)
        {
            a = value;
        }

        public void DoCountinue()
        {
            // Рандомим 1 и 2 значения
            Random rnd = new Random();
            int xValue1 = rnd.Next(a);
            int xValue2 = rnd.Next(a);
            int xMinus = rnd.Next(10);
            AnswerCorrect = xValue1 + xValue2 + xMinus;
            CodeText = String.Format("{0} + {1} = ?-{2}", xValue1, xValue2, xMinus);
            // Рандомим ответы
            answer1 = rnd.Next(a*2);
            answer2 = rnd.Next(a);
            answer3 = rnd.Next(a*2);
            answer4 = rnd.Next(a);
            answer5 = rnd.Next(a*2);
            // В зависимости от счётчика RightAnswer изменяем кнопку на правильный ответ
            RightAnswer++;
            if (RightAnswer == 6)
                RightAnswer = 1;

            if (RightAnswer == 1)
                answer1 = AnswerCorrect;
            else if (RightAnswer == 2)
                answer2 = AnswerCorrect;
            else if (RightAnswer == 3)
                answer3 = AnswerCorrect;
            else if (RightAnswer == 4)
                answer4 = AnswerCorrect;
            else if (RightAnswer == 5)
                answer5 = AnswerCorrect;
            

            
            Change?.Invoke(this, EventArgs.Empty);
        }

        public void DoAnswer(int v)
        {

            if (v == AnswerCorrect)
            {
                CountCorrect++;
                DoCountinue();
                //return "Всё верно";

            }
            else
            {
                CountBad++;
                DoCountinue();
                //return "Косяк. Правильный ответ не тот, что ты выбрал:(";
            }
            
        }
    }
}
