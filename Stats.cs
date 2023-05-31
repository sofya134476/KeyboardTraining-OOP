using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTraining
{
    class Stats
    {
        private bool isStarted;
        private int currentTime;
        private string currentLevel;
        private int currentMistakes;
        private double currentSpeed;
        private string currentText;
        private int currentSymbols;


        public bool getIsStarted() { return isStarted; }
        public int getCurrentTime() { return currentTime; }
        public string getCurrentLevel() { return currentLevel; }
        public int getCurrentMistakes() { return currentMistakes; }
        public double getCurrentSpeed() { return currentSpeed; }
        public string getCurrentText() { return currentText; }
        public int getCurrentSymbols() { return currentSymbols; }

        public void setIsStarted(bool newIsStarted) { this.isStarted = newIsStarted; }
        public void setCurrentTime(int newCurrentTime) { this.currentTime = newCurrentTime; }
        public void setCurrentLevel(string newCurrentLevel) { this.currentLevel = newCurrentLevel; }
        public void setCurrentMistakes(int newCurrentMistakes) { this.currentMistakes = newCurrentMistakes; }
        public void setCurrentSpeed(double newCurrentSpeed) { this.currentSpeed = newCurrentSpeed; }
        public void setCurrentText(string newCurrentText) { this.currentText = newCurrentText; }
        public void setCurrentSymbols(int newCurrentSymbols) { this.currentSymbols = newCurrentSymbols; }

        public Stats()
        {
            this.currentLevel = "Лёгкий";
            this.currentText = "text1";
            toDefault();
        }
        public void toDefault()
        {
            this.isStarted = false;
            this.currentTime = 0;
            this.currentMistakes = 0;
            this.currentSpeed = 0;
            this.currentSymbols= 0;
        }

        public void onStart(string text, string level)
        {
            this.isStarted = true;
            this.currentText = text;
            this.currentLevel = level;
        }

        public char returnSymbol(int charNum)
        {
            switch (charNum)
            {
                case 192: return 'ё';
                case 49: return '1';
                case 50: return '2';
                case 51: return '3';
                case 52: return '4';
                case 53: return '5';
                case 54: return '6';
                case 55: return '7';
                case 56: return '8';
                case 57: return '9';
                case 48: return '0';
                case 81: return 'й';
                case 87: return 'ц';
                case 69: return 'у';
                case 82: return 'к';
                case 84: return 'е';
                case 89: return 'н';
                case 85: return 'г';
                case 73: return 'ш';
                case 79: return 'щ';
                case 80: return 'з';
                case 219: return 'х';
                case 221: return 'ъ';
                case 65: return 'ф';
                case 83: return 'ы';
                case 68: return 'в';
                case 70: return 'а';
                case 71: return 'п';
                case 72: return 'р';
                case 74: return 'о';
                case 75: return 'л';
                case 76: return 'д';
                case 186: return 'ж';
                case 222: return 'э';
                case 90: return 'я';
                case 88: return 'ч';
                case 67: return 'с';
                case 86: return 'м';
                case 66: return 'и';
                case 78: return 'т';
                case 77: return 'ь';
                case 188: return 'б';
                case 190: return 'ю';
                case 191: return '.';
                case 32: return ' ';

            }
            return ' ';
        }
    }
}
