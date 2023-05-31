using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTraining
{
    public partial class Form1 : Form
    {
        Options options = new Options();
        Stats stats = new Stats();
        Results results = new Results();

        
        public Form1()
        {   
            InitializeComponent();
            levelBox.Text = "Лёгкий";
            textSelection.Text = "text1";
        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            string message = "Добро пожаловать в клавиатурный тренажёр\n\nЭта программа" +
                " предназачена для проверки и тренировки скорости набора текста на клавиатуре." +
                "\n\nСправка:\n\nКнопка 'Справка' выводит данное окно.\n" +
                "Кнопка 'Начать' запускает тренажёр.\n" +
                "Кнопка 'Стоп' останавливает тренажёр и сбрасывает статистику без" +
                " сохранения результатов.\n" +
                "Кнопка 'Сохранить результаты' позволяет сохранить результаты " +
                "выполения упражнения в текстовый файл," +
                " упражнение было выполнено до конца.\n\n" +
                "В разделе 'Настройки' есть опции 'Уровень' и 'Выбор текста'\n" +
                "Опция 'Уровень' позволяет выбрать уровень сложности, который" +
                " влияет на то, как определённый процент ошибок повлияет на оценку.\n" +
                "Опция 'Выбор текста' позволяет выбрать какой текст для набора" +
                " будет выводится на экран.";
            string caption = "Справка";
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, button);
        }

        private void optionChanged(object sender, EventArgs e)
        {
            options.onChange(levelBox.Text,textSelection.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stats.setCurrentTime(stats.getCurrentTime()+1);
            timeLabel.Text = Convert.ToString(stats.getCurrentTime()) + " сек";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            saveResultsButton.Enabled = false;
            stopButton.Enabled = true;
            timeLabel.Text = "0 сек";
            timer1.Start();
            stats.onStart(textSelection.Text,levelBox.Text);
            levelLabel.Text = levelBox.Text;
            mistakesLabel.Text = "0";
            speedLabel.Text = "0";
            StreamReader sr = new StreamReader("Strings" + "\\" + stats.getCurrentText() + ".txt");
            textPanel.Text = sr.ReadLine();

            results.toDefault();
            resultTimeLabel.Text = "-";
            resultSymbolsLabel.Text = "-";
            resultMistakesLabel.Text = "-";
            resultPercentageLabel.Text = "-";
            resultSpeedLabel.Text = "-";
            resultLevelLabel.Text = "-";
            resultMarkLabel.Text = "-";

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopButton.Enabled = false;
            stats.toDefault();
            timeLabel.Text = "-";
            levelLabel.Text = "-";
            mistakesLabel.Text = "-";
            speedLabel.Text= "-";
            startButton.Enabled = true;
            textPanel.Text = "";

        }

        private void saveResultsButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Вы действительно хотите сохранить результаты?",
                "Сохранение результатов", MessageBoxButtons.YesNo);

            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                string path = @"Results\"+ Convert.ToString((DateTime.Now.ToString("dddd, dd MMMM yyyy")) +".txt") ;
                StreamWriter writer = new StreamWriter(path,false);
                writer.WriteLine("Время: " + Convert.ToString(results.getResultTime())+" сек");
                writer.WriteLine("Символов введено: " + Convert.ToString(results.getResultSymbols()));
                writer.WriteLine("Ошибки: " + Convert.ToString(results.getResultMistakes()));
                writer.WriteLine("Процент правильных символов: " + Convert.ToString(results.getResultPercentage())+"%");
                writer.WriteLine("Скорость набора символов: " + Convert.ToString(results.getResultSpeed())+" симв/мин");
                writer.WriteLine("Уровень: " + Convert.ToString(results.getResultLevel()));
                writer.WriteLine("Оценка: " + Convert.ToString(results.getResultMark()));
                writer.Close();
            }
        }        
        
        private void formKeyDown(object sender, KeyEventArgs e)
        {
            if (stats.getIsStarted() == true)
            {
                if (stats.returnSymbol(e.KeyValue) != textPanel.Text[0])
                {
                    stats.setCurrentMistakes(stats.getCurrentMistakes() + 1);
                    mistakesLabel.Text = Convert.ToString(stats.getCurrentMistakes());
                }
                textPanel.Text = textPanel.Text.Remove(0, 1);
                stats.setCurrentSymbols(stats.getCurrentSymbols() + 1);
                try {
                    stats.setCurrentSpeed(Math.Round(((double)stats.getCurrentSymbols() / stats.getCurrentTime()) * 60));
                    Console.WriteLine(stats.getCurrentSymbols() / stats.getCurrentTime());
                }
                catch { 
                }                
                speedLabel.Text = stats.getCurrentSpeed() + " симв/мин";

                if (textPanel.Text.Length == 0)
                {
                    timer1.Stop();
                    results.onFinish(stats.getCurrentTime(),stats.getCurrentSymbols(),
                        stats.getCurrentMistakes(),stats.getCurrentSpeed(),stats.getCurrentLevel());
                    stats.toDefault();
                    saveResultsButton.Enabled = true;
                    stopButton.Enabled = false;
                    timeLabel.Text = "-";
                    levelLabel.Text = "-";
                    mistakesLabel.Text = "-";
                    speedLabel.Text = "-";
                    startButton.Enabled = true;

                    resultTimeLabel.Text = Convert.ToString(results.getResultTime()) +" сек";
                    resultSymbolsLabel.Text = Convert.ToString(results.getResultSymbols());
                    resultMistakesLabel.Text = Convert.ToString(results.getResultMistakes());
                    resultPercentageLabel.Text = Convert.ToString(results.getResultPercentage())+"%";
                    resultSpeedLabel.Text = Convert.ToString(results.getResultSpeed())+ " симв/мин";
                    resultLevelLabel.Text = Convert.ToString(results.getResultLevel());
                    resultMarkLabel.Text = Convert.ToString(results.getResultMark());

                    MessageBox.Show("Упражнение окончено","Конец строки");

                }


            }
        }

    }
}
