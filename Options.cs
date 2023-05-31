using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardTraining
{
    class Options
    {
        private string levelOption;
        private string textOption;
        public string getLevelOption()
        {
            return this.levelOption;
        }

        public string getTextOption()
        {
            return this.textOption;
        }

        public void setLevelOption(string newLevelOption)
        {
            this.levelOption = newLevelOption;
        }

        public void setTextOption(string newTextOption)
        {
            this.textOption = newTextOption;
        }

        public Options()
        {
            this.levelOption = "Лёгкий";
            this.textOption = "text1";
        }

        public void onChange(string newLevelOption, string newTextOption)
        {
            this.levelOption = newLevelOption;
            this.textOption = newTextOption;
        }
    }
}
