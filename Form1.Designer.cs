namespace KeyboardTraining
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.infoButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.textSelection = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.speedLabel = new System.Windows.Forms.Label();
            this.mistakesLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.stopButton = new System.Windows.Forms.Button();
            this.resultMarkLabel = new System.Windows.Forms.Label();
            this.resultLevelLabel = new System.Windows.Forms.Label();
            this.resultSpeedLabel = new System.Windows.Forms.Label();
            this.resultPercentageLabel = new System.Windows.Forms.Label();
            this.resultMistakesLabel = new System.Windows.Forms.Label();
            this.resultSymbolsLabel = new System.Windows.Forms.Label();
            this.resultTimeLabel = new System.Windows.Forms.Label();
            this.saveResultsButton = new System.Windows.Forms.Button();
            this.markLabel = new System.Windows.Forms.Label();
            this.resultLevel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textPanel = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Transparent;
            this.menuPanel.Controls.Add(this.infoButton);
            this.menuPanel.Controls.Add(this.startButton);
            this.menuPanel.Controls.Add(this.textSelection);
            this.menuPanel.Controls.Add(this.label9);
            this.menuPanel.Controls.Add(this.levelBox);
            this.menuPanel.Controls.Add(this.label8);
            this.menuPanel.Controls.Add(this.label7);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.ForeColor = System.Drawing.Color.Indigo;
            this.menuPanel.Location = new System.Drawing.Point(9, 9);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(244, 543);
            this.menuPanel.TabIndex = 0;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.ForeColor = System.Drawing.Color.Indigo;
            this.infoButton.Location = new System.Drawing.Point(6, 270);
            this.infoButton.Margin = new System.Windows.Forms.Padding(2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(109, 26);
            this.infoButton.TabIndex = 12;
            this.infoButton.TabStop = false;
            this.infoButton.Text = "Справка";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(7, 479);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(224, 54);
            this.startButton.TabIndex = 7;
            this.startButton.TabStop = false;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textSelection
            // 
            this.textSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textSelection.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSelection.ForeColor = System.Drawing.Color.Indigo;
            this.textSelection.FormattingEnabled = true;
            this.textSelection.Items.AddRange(new object[] {
            "text1",
            "text2",
            "text3",
            "text4"});
            this.textSelection.Location = new System.Drawing.Point(7, 241);
            this.textSelection.Margin = new System.Windows.Forms.Padding(2);
            this.textSelection.Name = "textSelection";
            this.textSelection.Size = new System.Drawing.Size(140, 25);
            this.textSelection.TabIndex = 6;
            this.textSelection.TabStop = false;
            this.textSelection.SelectedValueChanged += new System.EventHandler(this.optionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(3, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Выбор текста:";
            // 
            // levelBox
            // 
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.ForeColor = System.Drawing.Color.Indigo;
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "Лёгкий",
            "Средний",
            "Сложный"});
            this.levelBox.Location = new System.Drawing.Point(7, 194);
            this.levelBox.Margin = new System.Windows.Forms.Padding(2);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(140, 25);
            this.levelBox.TabIndex = 4;
            this.levelBox.TabStop = false;
            this.levelBox.SelectedValueChanged += new System.EventHandler(this.optionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(2, 169);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Уровень:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(2, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Настройки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(2, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клавиатурный тренажёр";
            // 
            // statsPanel
            // 
            this.statsPanel.BackColor = System.Drawing.Color.Transparent;
            this.statsPanel.Controls.Add(this.speedLabel);
            this.statsPanel.Controls.Add(this.mistakesLabel);
            this.statsPanel.Controls.Add(this.levelLabel);
            this.statsPanel.Controls.Add(this.timeLabel);
            this.statsPanel.Controls.Add(this.label6);
            this.statsPanel.Controls.Add(this.label5);
            this.statsPanel.Controls.Add(this.label4);
            this.statsPanel.Controls.Add(this.label3);
            this.statsPanel.Controls.Add(this.label2);
            this.statsPanel.Location = new System.Drawing.Point(258, 10);
            this.statsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(584, 135);
            this.statsPanel.TabIndex = 1;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.ForeColor = System.Drawing.Color.Indigo;
            this.speedLabel.Location = new System.Drawing.Point(208, 92);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(14, 19);
            this.speedLabel.TabIndex = 9;
            this.speedLabel.Text = "-";
            // 
            // mistakesLabel
            // 
            this.mistakesLabel.AutoSize = true;
            this.mistakesLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mistakesLabel.ForeColor = System.Drawing.Color.Red;
            this.mistakesLabel.Location = new System.Drawing.Point(71, 72);
            this.mistakesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mistakesLabel.Name = "mistakesLabel";
            this.mistakesLabel.Size = new System.Drawing.Size(14, 19);
            this.mistakesLabel.TabIndex = 8;
            this.mistakesLabel.Text = "-";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelLabel.ForeColor = System.Drawing.Color.Indigo;
            this.levelLabel.Location = new System.Drawing.Point(71, 53);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(14, 19);
            this.levelLabel.TabIndex = 7;
            this.levelLabel.Text = "-";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.timeLabel.Location = new System.Drawing.Point(60, 33);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(14, 19);
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Скорость набора символов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ошибки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(2, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Уровень:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(2, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Статистика";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Controls.Add(this.stopButton);
            this.mainPanel.Controls.Add(this.resultMarkLabel);
            this.mainPanel.Controls.Add(this.resultLevelLabel);
            this.mainPanel.Controls.Add(this.resultSpeedLabel);
            this.mainPanel.Controls.Add(this.resultPercentageLabel);
            this.mainPanel.Controls.Add(this.resultMistakesLabel);
            this.mainPanel.Controls.Add(this.resultSymbolsLabel);
            this.mainPanel.Controls.Add(this.resultTimeLabel);
            this.mainPanel.Controls.Add(this.saveResultsButton);
            this.mainPanel.Controls.Add(this.markLabel);
            this.mainPanel.Controls.Add(this.resultLevel);
            this.mainPanel.Controls.Add(this.label16);
            this.mainPanel.Controls.Add(this.label15);
            this.mainPanel.Controls.Add(this.label14);
            this.mainPanel.Controls.Add(this.label13);
            this.mainPanel.Controls.Add(this.label12);
            this.mainPanel.Controls.Add(this.label11);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.textPanel);
            this.mainPanel.Location = new System.Drawing.Point(258, 150);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(584, 402);
            this.mainPanel.TabIndex = 2;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.Transparent;
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.Color.Indigo;
            this.stopButton.Location = new System.Drawing.Point(441, 319);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(128, 34);
            this.stopButton.TabIndex = 19;
            this.stopButton.TabStop = false;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resultMarkLabel
            // 
            this.resultMarkLabel.AutoSize = true;
            this.resultMarkLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultMarkLabel.ForeColor = System.Drawing.Color.Indigo;
            this.resultMarkLabel.Location = new System.Drawing.Point(76, 366);
            this.resultMarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultMarkLabel.Name = "resultMarkLabel";
            this.resultMarkLabel.Size = new System.Drawing.Size(14, 19);
            this.resultMarkLabel.TabIndex = 18;
            this.resultMarkLabel.Text = "-";
            // 
            // resultLevelLabel
            // 
            this.resultLevelLabel.AutoSize = true;
            this.resultLevelLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLevelLabel.ForeColor = System.Drawing.Color.Indigo;
            this.resultLevelLabel.Location = new System.Drawing.Point(80, 346);
            this.resultLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLevelLabel.Name = "resultLevelLabel";
            this.resultLevelLabel.Size = new System.Drawing.Size(14, 19);
            this.resultLevelLabel.TabIndex = 17;
            this.resultLevelLabel.Text = "-";
            // 
            // resultSpeedLabel
            // 
            this.resultSpeedLabel.AutoSize = true;
            this.resultSpeedLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultSpeedLabel.ForeColor = System.Drawing.Color.Indigo;
            this.resultSpeedLabel.Location = new System.Drawing.Point(221, 327);
            this.resultSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultSpeedLabel.Name = "resultSpeedLabel";
            this.resultSpeedLabel.Size = new System.Drawing.Size(14, 19);
            this.resultSpeedLabel.TabIndex = 16;
            this.resultSpeedLabel.Text = "-";
            // 
            // resultPercentageLabel
            // 
            this.resultPercentageLabel.AutoSize = true;
            this.resultPercentageLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultPercentageLabel.ForeColor = System.Drawing.Color.Indigo;
            this.resultPercentageLabel.Location = new System.Drawing.Point(251, 307);
            this.resultPercentageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultPercentageLabel.Name = "resultPercentageLabel";
            this.resultPercentageLabel.Size = new System.Drawing.Size(14, 19);
            this.resultPercentageLabel.TabIndex = 15;
            this.resultPercentageLabel.Text = "-";
            // 
            // resultMistakesLabel
            // 
            this.resultMistakesLabel.AutoSize = true;
            this.resultMistakesLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultMistakesLabel.ForeColor = System.Drawing.Color.Red;
            this.resultMistakesLabel.Location = new System.Drawing.Point(82, 288);
            this.resultMistakesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultMistakesLabel.Name = "resultMistakesLabel";
            this.resultMistakesLabel.Size = new System.Drawing.Size(14, 19);
            this.resultMistakesLabel.TabIndex = 14;
            this.resultMistakesLabel.Text = "-";
            // 
            // resultSymbolsLabel
            // 
            this.resultSymbolsLabel.AutoSize = true;
            this.resultSymbolsLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultSymbolsLabel.ForeColor = System.Drawing.Color.Indigo;
            this.resultSymbolsLabel.Location = new System.Drawing.Point(156, 268);
            this.resultSymbolsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultSymbolsLabel.Name = "resultSymbolsLabel";
            this.resultSymbolsLabel.Size = new System.Drawing.Size(14, 19);
            this.resultSymbolsLabel.TabIndex = 13;
            this.resultSymbolsLabel.Text = "-";
            // 
            // resultTimeLabel
            // 
            this.resultTimeLabel.AutoSize = true;
            this.resultTimeLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultTimeLabel.ForeColor = System.Drawing.Color.Indigo;
            this.resultTimeLabel.Location = new System.Drawing.Point(71, 249);
            this.resultTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultTimeLabel.Name = "resultTimeLabel";
            this.resultTimeLabel.Size = new System.Drawing.Size(14, 19);
            this.resultTimeLabel.TabIndex = 12;
            this.resultTimeLabel.Text = "-";
            // 
            // saveResultsButton
            // 
            this.saveResultsButton.BackColor = System.Drawing.Color.Transparent;
            this.saveResultsButton.Enabled = false;
            this.saveResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResultsButton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveResultsButton.ForeColor = System.Drawing.Color.Indigo;
            this.saveResultsButton.Location = new System.Drawing.Point(370, 358);
            this.saveResultsButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveResultsButton.Name = "saveResultsButton";
            this.saveResultsButton.Size = new System.Drawing.Size(199, 34);
            this.saveResultsButton.TabIndex = 11;
            this.saveResultsButton.TabStop = false;
            this.saveResultsButton.Text = "Сохранить результаты";
            this.saveResultsButton.UseVisualStyleBackColor = false;
            this.saveResultsButton.Click += new System.EventHandler(this.saveResultsButton_Click);
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markLabel.ForeColor = System.Drawing.Color.Indigo;
            this.markLabel.Location = new System.Drawing.Point(10, 366);
            this.markLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(66, 19);
            this.markLabel.TabIndex = 10;
            this.markLabel.Text = "Оценка:";
            // 
            // resultLevel
            // 
            this.resultLevel.AutoSize = true;
            this.resultLevel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLevel.ForeColor = System.Drawing.Color.Indigo;
            this.resultLevel.Location = new System.Drawing.Point(10, 346);
            this.resultLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLevel.Name = "resultLevel";
            this.resultLevel.Size = new System.Drawing.Size(70, 19);
            this.resultLevel.TabIndex = 9;
            this.resultLevel.Text = "Уровень:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Indigo;
            this.label16.Location = new System.Drawing.Point(10, 327);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(208, 19);
            this.label16.TabIndex = 8;
            this.label16.Text = "Скорость набора символов:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Indigo;
            this.label15.Location = new System.Drawing.Point(10, 307);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 19);
            this.label15.TabIndex = 7;
            this.label15.Text = "Процент правильных символов:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Indigo;
            this.label14.Location = new System.Drawing.Point(10, 268);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 19);
            this.label14.TabIndex = 6;
            this.label14.Text = "Символов введено:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Indigo;
            this.label13.Location = new System.Drawing.Point(10, 288);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Ошибки:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Indigo;
            this.label12.Location = new System.Drawing.Point(10, 249);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Время:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(10, 226);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "Результаты";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(10, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Текст";
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textPanel.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPanel.ForeColor = System.Drawing.Color.Indigo;
            this.textPanel.Location = new System.Drawing.Point(9, 41);
            this.textPanel.Margin = new System.Windows.Forms.Padding(2);
            this.textPanel.Name = "textPanel";
            this.textPanel.ReadOnly = true;
            this.textPanel.Size = new System.Drawing.Size(561, 53);
            this.textPanel.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImage = global::KeyboardTraining.Properties.Resources._10_20211222_143549;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 561);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "KeyboardTraining";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formKeyDown);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label mistakesLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox textSelection;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox textPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label resultLevel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button saveResultsButton;
        private System.Windows.Forms.Label resultMarkLabel;
        private System.Windows.Forms.Label resultLevelLabel;
        private System.Windows.Forms.Label resultSpeedLabel;
        private System.Windows.Forms.Label resultPercentageLabel;
        private System.Windows.Forms.Label resultMistakesLabel;
        private System.Windows.Forms.Label resultSymbolsLabel;
        private System.Windows.Forms.Label resultTimeLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer1;
    }
}

