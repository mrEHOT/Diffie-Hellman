namespace Diffie_Hellman
{
    partial class mainForm
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
            this.workModeLabel = new System.Windows.Forms.Label();
            this.manualRadioButton = new System.Windows.Forms.RadioButton();
            this.autoRadioButton = new System.Windows.Forms.RadioButton();
            this.inputParametersLabel = new System.Windows.Forms.Label();
            this.pPrimeTextBox = new System.Windows.Forms.TextBox();
            this.pPrimeLabel = new System.Windows.Forms.Label();
            this.privateNumberALabel = new System.Windows.Forms.Label();
            this.privateNumberATextBox = new System.Windows.Forms.TextBox();
            this.privateNumberBLabel = new System.Windows.Forms.Label();
            this.privateNumberBTextBox = new System.Windows.Forms.TextBox();
            this.gNumberLabel = new System.Windows.Forms.Label();
            this.gNumberTextBox = new System.Windows.Forms.TextBox();
            this.qNumberLabel = new System.Windows.Forms.Label();
            this.qNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.userALabel = new System.Windows.Forms.Label();
            this.userBLabel = new System.Windows.Forms.Label();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.publicKeyATextBox = new System.Windows.Forms.TextBox();
            this.publicKeyBTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyBTextBox = new System.Windows.Forms.TextBox();
            this.privateKeyATextBox = new System.Windows.Forms.TextBox();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyCheckLabel = new System.Windows.Forms.Label();
            this.privateKeyCheckTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workModeLabel
            // 
            this.workModeLabel.AutoSize = true;
            this.workModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workModeLabel.Location = new System.Drawing.Point(12, 9);
            this.workModeLabel.Name = "workModeLabel";
            this.workModeLabel.Size = new System.Drawing.Size(297, 18);
            this.workModeLabel.TabIndex = 27;
            this.workModeLabel.Text = "Выберите режим работы алгоритма:";
            // 
            // manualRadioButton
            // 
            this.manualRadioButton.AutoSize = true;
            this.manualRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manualRadioButton.Location = new System.Drawing.Point(236, 39);
            this.manualRadioButton.Name = "manualRadioButton";
            this.manualRadioButton.Size = new System.Drawing.Size(201, 22);
            this.manualRadioButton.TabIndex = 29;
            this.manualRadioButton.TabStop = true;
            this.manualRadioButton.Text = "Ручной ввод параметров";
            this.manualRadioButton.UseVisualStyleBackColor = true;
            this.manualRadioButton.CheckedChanged += new System.EventHandler(this.manualRadioButton_CheckedChanged);
            // 
            // autoRadioButton
            // 
            this.autoRadioButton.AutoSize = true;
            this.autoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoRadioButton.Location = new System.Drawing.Point(15, 39);
            this.autoRadioButton.Name = "autoRadioButton";
            this.autoRadioButton.Size = new System.Drawing.Size(215, 22);
            this.autoRadioButton.TabIndex = 28;
            this.autoRadioButton.TabStop = true;
            this.autoRadioButton.Text = "Автоматическая генерация";
            this.autoRadioButton.UseVisualStyleBackColor = true;
            this.autoRadioButton.CheckedChanged += new System.EventHandler(this.autoRadioButton_CheckedChanged);
            // 
            // inputParametersLabel
            // 
            this.inputParametersLabel.AutoSize = true;
            this.inputParametersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputParametersLabel.Location = new System.Drawing.Point(12, 74);
            this.inputParametersLabel.Name = "inputParametersLabel";
            this.inputParametersLabel.Size = new System.Drawing.Size(173, 18);
            this.inputParametersLabel.TabIndex = 30;
            this.inputParametersLabel.Text = "Входные параметры:";
            // 
            // pPrimeTextBox
            // 
            this.pPrimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pPrimeTextBox.Location = new System.Drawing.Point(290, 104);
            this.pPrimeTextBox.Name = "pPrimeTextBox";
            this.pPrimeTextBox.ReadOnly = true;
            this.pPrimeTextBox.Size = new System.Drawing.Size(467, 22);
            this.pPrimeTextBox.TabIndex = 31;
            // 
            // pPrimeLabel
            // 
            this.pPrimeLabel.AutoSize = true;
            this.pPrimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pPrimeLabel.Location = new System.Drawing.Point(12, 107);
            this.pPrimeLabel.Name = "pPrimeLabel";
            this.pPrimeLabel.Size = new System.Drawing.Size(135, 16);
            this.pPrimeLabel.TabIndex = 33;
            this.pPrimeLabel.Text = "Простое число p:";
            // 
            // privateNumberALabel
            // 
            this.privateNumberALabel.AutoSize = true;
            this.privateNumberALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateNumberALabel.Location = new System.Drawing.Point(12, 221);
            this.privateNumberALabel.Name = "privateNumberALabel";
            this.privateNumberALabel.Size = new System.Drawing.Size(269, 16);
            this.privateNumberALabel.TabIndex = 35;
            this.privateNumberALabel.Text = "Секретное число абонената A (Xa):";
            // 
            // privateNumberATextBox
            // 
            this.privateNumberATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateNumberATextBox.Location = new System.Drawing.Point(290, 218);
            this.privateNumberATextBox.Name = "privateNumberATextBox";
            this.privateNumberATextBox.ReadOnly = true;
            this.privateNumberATextBox.Size = new System.Drawing.Size(467, 22);
            this.privateNumberATextBox.TabIndex = 34;
            // 
            // privateNumberBLabel
            // 
            this.privateNumberBLabel.AutoSize = true;
            this.privateNumberBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateNumberBLabel.Location = new System.Drawing.Point(12, 260);
            this.privateNumberBLabel.Name = "privateNumberBLabel";
            this.privateNumberBLabel.Size = new System.Drawing.Size(269, 16);
            this.privateNumberBLabel.TabIndex = 37;
            this.privateNumberBLabel.Text = "Секретное число абонената B (Xb):";
            // 
            // privateNumberBTextBox
            // 
            this.privateNumberBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateNumberBTextBox.Location = new System.Drawing.Point(290, 257);
            this.privateNumberBTextBox.Name = "privateNumberBTextBox";
            this.privateNumberBTextBox.ReadOnly = true;
            this.privateNumberBTextBox.Size = new System.Drawing.Size(467, 22);
            this.privateNumberBTextBox.TabIndex = 36;
            // 
            // gNumberLabel
            // 
            this.gNumberLabel.AutoSize = true;
            this.gNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gNumberLabel.Location = new System.Drawing.Point(12, 184);
            this.gNumberLabel.Name = "gNumberLabel";
            this.gNumberLabel.Size = new System.Drawing.Size(69, 16);
            this.gNumberLabel.TabIndex = 41;
            this.gNumberLabel.Text = "Число g:";
            // 
            // gNumberTextBox
            // 
            this.gNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gNumberTextBox.Location = new System.Drawing.Point(290, 181);
            this.gNumberTextBox.Name = "gNumberTextBox";
            this.gNumberTextBox.ReadOnly = true;
            this.gNumberTextBox.Size = new System.Drawing.Size(467, 22);
            this.gNumberTextBox.TabIndex = 40;
            // 
            // qNumberLabel
            // 
            this.qNumberLabel.AutoSize = true;
            this.qNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qNumberLabel.Location = new System.Drawing.Point(12, 145);
            this.qNumberLabel.Name = "qNumberLabel";
            this.qNumberLabel.Size = new System.Drawing.Size(69, 16);
            this.qNumberLabel.TabIndex = 39;
            this.qNumberLabel.Text = "Число q:";
            // 
            // qNumberTextBox
            // 
            this.qNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qNumberTextBox.Location = new System.Drawing.Point(290, 142);
            this.qNumberTextBox.Name = "qNumberTextBox";
            this.qNumberTextBox.ReadOnly = true;
            this.qNumberTextBox.Size = new System.Drawing.Size(467, 22);
            this.qNumberTextBox.TabIndex = 38;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsLabel.Location = new System.Drawing.Point(12, 308);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(257, 18);
            this.resultsLabel.TabIndex = 42;
            this.resultsLabel.Text = "Результаты работы алгоритма:";
            // 
            // userALabel
            // 
            this.userALabel.AutoSize = true;
            this.userALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userALabel.Location = new System.Drawing.Point(251, 341);
            this.userALabel.Name = "userALabel";
            this.userALabel.Size = new System.Drawing.Size(84, 16);
            this.userALabel.TabIndex = 43;
            this.userALabel.Text = "Абонент A";
            // 
            // userBLabel
            // 
            this.userBLabel.AutoSize = true;
            this.userBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userBLabel.Location = new System.Drawing.Point(573, 341);
            this.userBLabel.Name = "userBLabel";
            this.userBLabel.Size = new System.Drawing.Size(84, 16);
            this.userBLabel.TabIndex = 44;
            this.userBLabel.Text = "Абонент B";
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyLabel.Location = new System.Drawing.Point(12, 393);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(134, 16);
            this.publicKeyLabel.TabIndex = 45;
            this.publicKeyLabel.Text = "Открытые ключи:";
            // 
            // publicKeyATextBox
            // 
            this.publicKeyATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyATextBox.Location = new System.Drawing.Point(152, 390);
            this.publicKeyATextBox.Name = "publicKeyATextBox";
            this.publicKeyATextBox.ReadOnly = true;
            this.publicKeyATextBox.Size = new System.Drawing.Size(285, 22);
            this.publicKeyATextBox.TabIndex = 46;
            // 
            // publicKeyBTextBox
            // 
            this.publicKeyBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publicKeyBTextBox.Location = new System.Drawing.Point(472, 390);
            this.publicKeyBTextBox.Name = "publicKeyBTextBox";
            this.publicKeyBTextBox.ReadOnly = true;
            this.publicKeyBTextBox.Size = new System.Drawing.Size(285, 22);
            this.publicKeyBTextBox.TabIndex = 47;
            // 
            // privateKeyBTextBox
            // 
            this.privateKeyBTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyBTextBox.Location = new System.Drawing.Point(472, 433);
            this.privateKeyBTextBox.Name = "privateKeyBTextBox";
            this.privateKeyBTextBox.ReadOnly = true;
            this.privateKeyBTextBox.Size = new System.Drawing.Size(285, 22);
            this.privateKeyBTextBox.TabIndex = 50;
            // 
            // privateKeyATextBox
            // 
            this.privateKeyATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyATextBox.Location = new System.Drawing.Point(152, 433);
            this.privateKeyATextBox.Name = "privateKeyATextBox";
            this.privateKeyATextBox.ReadOnly = true;
            this.privateKeyATextBox.Size = new System.Drawing.Size(285, 22);
            this.privateKeyATextBox.TabIndex = 49;
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyLabel.Location = new System.Drawing.Point(12, 436);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(134, 16);
            this.privateKeyLabel.TabIndex = 48;
            this.privateKeyLabel.Text = "Закрытые ключи:";
            // 
            // privateKeyCheckLabel
            // 
            this.privateKeyCheckLabel.AutoSize = true;
            this.privateKeyCheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyCheckLabel.Location = new System.Drawing.Point(12, 480);
            this.privateKeyCheckLabel.Name = "privateKeyCheckLabel";
            this.privateKeyCheckLabel.Size = new System.Drawing.Size(262, 16);
            this.privateKeyCheckLabel.TabIndex = 51;
            this.privateKeyCheckLabel.Text = "Проверка закрытых ключей (XOR):";
            // 
            // privateKeyCheckTextBox
            // 
            this.privateKeyCheckTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.privateKeyCheckTextBox.Location = new System.Drawing.Point(280, 477);
            this.privateKeyCheckTextBox.Name = "privateKeyCheckTextBox";
            this.privateKeyCheckTextBox.ReadOnly = true;
            this.privateKeyCheckTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.privateKeyCheckTextBox.Size = new System.Drawing.Size(477, 22);
            this.privateKeyCheckTextBox.TabIndex = 52;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(183, 518);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(182, 31);
            this.startButton.TabIndex = 53;
            this.startButton.Text = "Выполнить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(387, 518);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(182, 31);
            this.resetButton.TabIndex = 54;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 561);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.privateKeyCheckTextBox);
            this.Controls.Add(this.privateKeyCheckLabel);
            this.Controls.Add(this.privateKeyBTextBox);
            this.Controls.Add(this.privateKeyATextBox);
            this.Controls.Add(this.privateKeyLabel);
            this.Controls.Add(this.publicKeyBTextBox);
            this.Controls.Add(this.publicKeyATextBox);
            this.Controls.Add(this.publicKeyLabel);
            this.Controls.Add(this.userBLabel);
            this.Controls.Add(this.userALabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.gNumberLabel);
            this.Controls.Add(this.gNumberTextBox);
            this.Controls.Add(this.qNumberLabel);
            this.Controls.Add(this.qNumberTextBox);
            this.Controls.Add(this.privateNumberBLabel);
            this.Controls.Add(this.privateNumberBTextBox);
            this.Controls.Add(this.privateNumberALabel);
            this.Controls.Add(this.privateNumberATextBox);
            this.Controls.Add(this.pPrimeLabel);
            this.Controls.Add(this.pPrimeTextBox);
            this.Controls.Add(this.inputParametersLabel);
            this.Controls.Add(this.manualRadioButton);
            this.Controls.Add(this.autoRadioButton);
            this.Controls.Add(this.workModeLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(785, 600);
            this.Name = "mainForm";
            this.Text = "Diffie-Hellman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workModeLabel;
        private System.Windows.Forms.RadioButton manualRadioButton;
        private System.Windows.Forms.RadioButton autoRadioButton;
        private System.Windows.Forms.Label inputParametersLabel;
        private System.Windows.Forms.TextBox pPrimeTextBox;
        private System.Windows.Forms.Label pPrimeLabel;
        private System.Windows.Forms.Label privateNumberALabel;
        private System.Windows.Forms.TextBox privateNumberATextBox;
        private System.Windows.Forms.Label privateNumberBLabel;
        private System.Windows.Forms.TextBox privateNumberBTextBox;
        private System.Windows.Forms.Label gNumberLabel;
        private System.Windows.Forms.TextBox gNumberTextBox;
        private System.Windows.Forms.Label qNumberLabel;
        private System.Windows.Forms.TextBox qNumberTextBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label userALabel;
        private System.Windows.Forms.Label userBLabel;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.TextBox publicKeyATextBox;
        private System.Windows.Forms.TextBox publicKeyBTextBox;
        private System.Windows.Forms.TextBox privateKeyBTextBox;
        private System.Windows.Forms.TextBox privateKeyATextBox;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.Label privateKeyCheckLabel;
        private System.Windows.Forms.TextBox privateKeyCheckTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button resetButton;
    }
}

