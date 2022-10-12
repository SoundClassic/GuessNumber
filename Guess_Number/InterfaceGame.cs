using System;
using System.Threading;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class InterfaceGame : Form
    {
        private Random random;// генератор рандомных чисел
        private int number;// задуманное число
        private int level_game;// уровень игры
        private int N;// число вопросов для звания магистр
        private int countQuestion;// счетчик вопросов
        private int min;// минимальная граница интервала
        private int max;// максимальная граница интервала
        private int limit_min;// предел нижней границы интервала
        private int limit_max;// предел верхней границы интервала
        private bool check;// угадал ли пользователь число

        private string question = "";// cтрока, в которой содержится вопрос

        public InterfaceGame()
        {
            InitializeComponent();
            Hint.Text = "Нажмите кнопку " + '"' + "Новая игра" + '"';
            MakeNumber.Enabled = false;// загадать число
            GuessNum.Enabled = false;// отгдать число компьютером
            AskQuestion.Enabled = false;// задать вопрос
            level.Enabled = false;// уровень игры
            Sign.Enabled = false;// знаки сравнения
            for (int i = 0; i < 3; i++)
            {
                level.Items.Add(i + 1);
                Sign.Items.Add(Convert.ToChar('<' + i));
            }
            random = new Random();
            countQuestion = 0;
        }

        private void Generate_Level()
        {
            if(level_game == 1){
                limit_min = 10; limit_max = 20;
            } else if(level_game == 2){
                limit_min = 100; limit_max = 1000;
            } else if(level_game == 3){
                limit_min = 1000; limit_max = 10000;
            }

            min = random.Next(0, limit_min + 1);
            max = random.Next(min, limit_max + 1);
            number = random.Next(min, max + 1);
            N = (int)Math.Log(max - min, 2) + 1;
            if (N == -2147483647)
                N = 1;

            Interval.Text = "[" + min + "; " + max + "]";
            Interval.Update();
            Attempts.Text = N.ToString();
            Attempts.Update();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            Hint.Text = "Выберете режим игры: загадать \nчисло и начать игру либо \nдать компьютеру право игры!";
            MakeNumber.Enabled = true;
            GuessNum.Enabled = true;
            level.Enabled = true;
            Interval.Clear();
            Num.Clear();
            Attempts.Clear();
            ProgressGame.Clear();
            ResultGame.Clear();
            level.Text = default;
            Sign.Enabled = false;
            AskQuestion.Enabled = false;
            Num.Enabled = false;
            question = "";
            countQuestion = 0;
            check = false;
        }

        private void MakeNumber_Click(object sender, EventArgs e)
        {
            if (level.Text == "")
            {
                Hint.Text = "Выберите уровень игры!";
                return;
            }

            level_game = int.Parse(level.Text);
            Generate_Level();

            string str = "Я задумал число в интервале [" + min + "; " + max + "] " +
                "\nЕсли отгадаешь число за " + N + " вопросов - станешь Магистром игры!" +
                "\nОтветом на вопрос может быть только " + '"' + "Да" + '"' + " или " + '"' + "Нет" + '"'; 
            MessageBox.Show(str, "Приветствую!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hint.Text = "Играйте!";
            Sign.Enabled = true;
            AskQuestion.Enabled = true;
            Num.Enabled = true;
            MakeNumber.Enabled = false;
            GuessNum.Enabled = false;
            level.Enabled = false;

        }

        private void AskQuestion_Click(object sender, EventArgs e)
        {
            if(Sign.Text == "")
            {
                Hint.Text = "Выберете знак сравнения!";
                return;
            }
            if(Num.Text == "")
            {
                Hint.Text = "Введите число!";
                return;
            }

            countQuestion++;
            Attempts.Text = (N - countQuestion).ToString();

            char symbol = Convert.ToChar(Sign.Text);
            int num = int.Parse(Num.Text);
            question += countQuestion.ToString() + ". ";
            if (symbol == '<'){

                question += "Число меньше " + num + "? ";
                if (number < num)
                    question += "- Да!";
                else
                    question += "- Нет!";

            } else if(symbol == '='){

                question += "Число равно " + num + "? ";
                if (number == num)
                {
                    question += "- Да!";
                    check = true;
                }
                else
                    question += "- Нет!";

            } else if(symbol == '>'){

                question += "Число больше " + num + "? ";
                if (number > num)
                    question += "- Да!";
                else
                    question += "- Нет!";

            }

            question += "\r\n";
            ProgressGame.Text = question;

            if(check)
            {
                Hint.Text = "Игра окончена! Для продолжения \nнажмите " + '"' + "Новая игра" + '"';
                Sign.Enabled = false;
                AskQuestion.Enabled = false;
                Num.Enabled = false;
                ResultGame.Text = "Поздравляю! Вы Магистр игры!" +
                    "\r\nВаш уровень - " + level_game +
                    "\r\nЧисло вопросов - " + countQuestion;
                return;
            }

            if (countQuestion == N)
            {
                Hint.Text = "Игра окончена! Для продолжения нажмите \n" + '"' + "Новая игра" + '"';
                ResultGame.Text = "Вы не смогли угадать число за " + N + " попыток!" +
                     "\r\nВаш уровень - " + level_game +
                     "\r\nЗагаданое число - " + number;
                Sign.Enabled = false;
                AskQuestion.Enabled = false;
                Num.Enabled = false;
                return;
            }
        }

        /// <summary>
        /// Двоичный поиск для компьютера
        /// </summary>
        /// <param name="array">Исходный массив</param>
        /// <param name="key">Необходимый элемент массива</param>
        /// <returns>Индекс элемента, если эл. не найден, код ошибки</returns>
        public int Binary_Search(int[] array, int key)
        {
            int N = array.Length;
            int begin = 0, end = N - 1, i;
            while (countQuestion != this.N)
            {
                countQuestion++;
                Attempts.Text = (this.N - countQuestion).ToString();
                Attempts.Update();
                i = (begin + end) / 2;
                if (array[i] == key)
                {
                    question += countQuestion.ToString() + ". ";
                    question += "Число равно " + array[i] + "? - Да!";
                    Hint.Text = "Игра окончена! Для продолжения \nнажмите " + '"' + "Новая игра" + '"';
                    Sign.Enabled = false;
                    AskQuestion.Enabled = false;
                    Num.Enabled = false;
                    ResultGame.Text = "Поздравляю! Компьютер отгадал \r\nнеобходимое число!" +
                        "\r\nЕго уровень - " + level_game +
                        "\r\nЧисло вопросов - " + countQuestion;
                    return 0;
                }
                else
                {
                    if (array[i] < key)
                    {
                        begin = i + 1;
                        question += countQuestion.ToString() + ". ";
                        question += "Число больше " + array[i] + "? ";
                        ProgressGame.Text = question;
                        ProgressGame.Update();
                        Thread.Sleep(1000);
                        question += "- Да!";
                        question += "\r\n";
                        ProgressGame.Text = question;
                        ProgressGame.Update();
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        end = i - 1;
                        question += countQuestion.ToString() + ". ";
                        question += "Число меньше " + array[i] + "? ";
                        ProgressGame.Text = question;
                        ProgressGame.Update();
                        Thread.Sleep(1000);
                        question += "- Да!";
                        question += "\r\n";
                        ProgressGame.Text = question;
                        ProgressGame.Update();
                        Thread.Sleep(1000);
                    }
                }
            }
            return -1;
        }

        private void GuessNum_Click(object sender, EventArgs e)
        {
            if (level.Text == "")
            {
                Hint.Text = "Выберите уровень игры!";
                return;
            }

            level_game = int.Parse(level.Text);
            Generate_Level();
            Hint.Text = "Играет компьютер!";
            MakeNumber.Enabled = false;
            GuessNum.Enabled = false;
            level.Enabled = false;
            ProgressGame.Update();

            int[] array = new int[max - min + 1];
            for (int i = min; i <= max; i++)
                array[i - min] = i;

            if (max - min == 0)
            {
                question += countQuestion.ToString() + ". ";
                question += "Число равно " + array[0] + "? - Да!";
                Hint.Text = "Игра окончена! Для продолжения \nнажмите " + '"' + "Новая игра" + '"';
                Sign.Enabled = false;
                AskQuestion.Enabled = false;
                Num.Enabled = false;
                ResultGame.Text = "Поздравляю! Компьютер отгадал \r\nнеобходимое число!" +
                    "\r\nЕго уровень - " + level_game +
                    "\r\nЧисло вопросов - " + 1 +
                    "\r\nЗагаданое число - " + number;
                return;
            }

            if(Binary_Search(array, number) == -1)
            {
                Hint.Text = "Игра окончена! Для продолжения нажмите \n" + '"' + "Новая игра" + '"';
                ResultGame.Text = "Компьютер не смог угадать число за " + N + " попыток!" +
                    "\r\nЗагаданое число - " + number;
                Sign.Enabled = false;
                AskQuestion.Enabled = false;
                Num.Enabled = false;
            }
            ProgressGame.Text = question;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
