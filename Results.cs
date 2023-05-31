using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTraining
{
    class Results
    {

        private int resultTime;
        private int resultSymbols;
        private int resultMistakes;
        private int resultPercentage;
        private double resultSpeed;
        private string resultLevel;
        private char resultMark;

        public int getResultTime() { return resultTime; }
        public int getResultSymbols() { return resultSymbols; }
        public int getResultMistakes() { return resultMistakes; }
        public int getResultPercentage() { return resultPercentage; }
        public double getResultSpeed() { return resultSpeed; }
        public string getResultLevel() { return resultLevel; }
        public char getResultMark() { return resultMark; }

        public void setResultTime(int newResultTime) { this.resultTime = newResultTime; }
        public void setResultSymbols(int newResultSymbols) { this.resultSymbols = newResultSymbols; }
        public void setResultMistakes(int newResultMistakes) { this.resultMistakes = newResultMistakes; }
        public void setResultPercentage(int newResultPercentage) { this.resultPercentage = newResultPercentage; }
        public void setResultSpeed(double newResultSpeed) { this.resultSpeed = newResultSpeed; }
        public void setResultLevel(string newResultLevel) { this.resultLevel = newResultLevel; }
        public void setResultMark(char newResultMark) { this.resultMark = newResultMark; }
        public Results()
        {
            toDefault();
            this.resultLevel = "Лёгкий";
        }

        public void toDefault()
        {
            this.resultTime = 0;
            this.resultSymbols = 0;
            this.resultMistakes = 0;
            this.resultPercentage = 0;
            this.resultSpeed = 0;           
            this.resultMark = '0';
        }

        public void onFinish(int time, int symbols, int mistakes, double speed, string level)
        {
            this.resultTime = time;
            this.resultSymbols = symbols;
            this.resultMistakes = mistakes;
            this.resultSpeed = speed;
            this.resultLevel = level;
            if (mistakes == 0)
            {
                this.resultPercentage = 100;
            } else
            {
                this.resultPercentage = (int)Math.Round(((((double)symbols)-(double)mistakes)/(double)symbols)*100);
            }
            if (level == "Лёгкий")
            {
                if (this.resultPercentage < 10)
                {
                    this.resultMark = '2';
                } 

                if (this.resultPercentage >= 10 && this.resultPercentage < 25)
                {
                    this.resultMark = '3';
                }

                if (this.resultPercentage >= 25 && this.resultPercentage < 50)
                {
                    this.resultMark = '4';
                }

                if (this.resultPercentage >= 50)
                {
                    this.resultMark = '5';
                }
            }

            if (level == "Средний")
            {
                if (this.resultPercentage < 20)
                {
                    this.resultMark = '2';
                }

                if (this.resultPercentage >= 20 && this.resultPercentage < 40)
                {
                    this.resultMark = '3';
                }

                if (this.resultPercentage >= 40 && this.resultPercentage < 75)
                {
                    this.resultMark = '4';
                }

                if (this.resultPercentage >= 75)
                {
                    this.resultMark = '5';
                }
            }

            if (level == "Сложный")
            {
                if (this.resultPercentage < 30)
                {
                    this.resultMark = '2';
                }

                if (this.resultPercentage >= 30 && this.resultPercentage < 60)
                {
                    this.resultMark = '3';
                }

                if (this.resultPercentage >= 60 && this.resultPercentage < 90)
                {
                    this.resultMark = '4';
                }

                if (this.resultPercentage >= 90)
                {
                    this.resultMark = '5';
                }
            }



        }

        

    }
}
