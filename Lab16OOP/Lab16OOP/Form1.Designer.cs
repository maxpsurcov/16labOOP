namespace Lab16OOP
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
            this.addButton = new System.Windows.Forms.Button();
            this.fractionsListBox = new System.Windows.Forms.ListBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.addFractionsButton = new System.Windows.Forms.Button();
            this.subtractFractionsButton = new System.Windows.Forms.Button();
            this.multiplyFractionsButton = new System.Windows.Forms.Button();
            this.divideFractionsButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.notEqualButton = new System.Windows.Forms.Button();
            this.greaterThanButton = new System.Windows.Forms.Button();
            this.lessThanButton = new System.Windows.Forms.Button();
            this.greaterThanOrEqualButton = new System.Windows.Forms.Button();
            this.lessThanOrEqualButton = new System.Windows.Forms.Button();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.numeratorTextBox = new System.Windows.Forms.TextBox();
            this.denominatorTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(483, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(178, 78);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "addButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fractionsListBox
            // 
            this.fractionsListBox.FormattingEnabled = true;
            this.fractionsListBox.ItemHeight = 24;
            this.fractionsListBox.Location = new System.Drawing.Point(12, 12);
            this.fractionsListBox.Name = "fractionsListBox";
            this.fractionsListBox.Size = new System.Drawing.Size(465, 220);
            this.fractionsListBox.TabIndex = 1;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(483, 96);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(178, 69);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "sortButton";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // addFractionsButton
            // 
            this.addFractionsButton.Location = new System.Drawing.Point(483, 171);
            this.addFractionsButton.Name = "addFractionsButton";
            this.addFractionsButton.Size = new System.Drawing.Size(225, 45);
            this.addFractionsButton.TabIndex = 3;
            this.addFractionsButton.Text = "Додати дроби";
            this.addFractionsButton.UseVisualStyleBackColor = true;
            this.addFractionsButton.Click += new System.EventHandler(this.addFractionsButton_Click);
            // 
            // subtractFractionsButton
            // 
            this.subtractFractionsButton.Location = new System.Drawing.Point(483, 222);
            this.subtractFractionsButton.Name = "subtractFractionsButton";
            this.subtractFractionsButton.Size = new System.Drawing.Size(225, 44);
            this.subtractFractionsButton.TabIndex = 4;
            this.subtractFractionsButton.Text = "Відняти дроби";
            this.subtractFractionsButton.UseVisualStyleBackColor = true;
            this.subtractFractionsButton.Click += new System.EventHandler(this.subtractFractionsButton_Click);
            // 
            // multiplyFractionsButton
            // 
            this.multiplyFractionsButton.Location = new System.Drawing.Point(714, 171);
            this.multiplyFractionsButton.Name = "multiplyFractionsButton";
            this.multiplyFractionsButton.Size = new System.Drawing.Size(225, 47);
            this.multiplyFractionsButton.TabIndex = 5;
            this.multiplyFractionsButton.Text = "Помножити дроби";
            this.multiplyFractionsButton.UseVisualStyleBackColor = true;
            this.multiplyFractionsButton.Click += new System.EventHandler(this.multiplyFractionsButton_Click);
            // 
            // divideFractionsButton
            // 
            this.divideFractionsButton.Location = new System.Drawing.Point(714, 224);
            this.divideFractionsButton.Name = "divideFractionsButton";
            this.divideFractionsButton.Size = new System.Drawing.Size(225, 50);
            this.divideFractionsButton.TabIndex = 6;
            this.divideFractionsButton.Text = "Поділити дроби";
            this.divideFractionsButton.UseVisualStyleBackColor = true;
            this.divideFractionsButton.Click += new System.EventHandler(this.divideFractionsButton_Click);
            // 
            // reduceButton
            // 
            this.reduceButton.Location = new System.Drawing.Point(610, 355);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(141, 55);
            this.reduceButton.TabIndex = 7;
            this.reduceButton.Text = "Зменшити";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(610, 295);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(141, 47);
            this.powerButton.TabIndex = 8;
            this.powerButton.Text = "Піднесення до степеня";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(12, 248);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(144, 43);
            this.equalButton.TabIndex = 9;
            this.equalButton.Text = "Дорівнює";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // notEqualButton
            // 
            this.notEqualButton.Location = new System.Drawing.Point(12, 306);
            this.notEqualButton.Name = "notEqualButton";
            this.notEqualButton.Size = new System.Drawing.Size(144, 36);
            this.notEqualButton.TabIndex = 10;
            this.notEqualButton.Text = "Не дорівнює";
            this.notEqualButton.UseVisualStyleBackColor = true;
            this.notEqualButton.Click += new System.EventHandler(this.notEqualButton_Click);
            // 
            // greaterThanButton
            // 
            this.greaterThanButton.Location = new System.Drawing.Point(178, 248);
            this.greaterThanButton.Name = "greaterThanButton";
            this.greaterThanButton.Size = new System.Drawing.Size(196, 50);
            this.greaterThanButton.TabIndex = 11;
            this.greaterThanButton.Text = "Більше";
            this.greaterThanButton.UseVisualStyleBackColor = true;
            this.greaterThanButton.Click += new System.EventHandler(this.greaterThanButton_Click);
            // 
            // lessThanButton
            // 
            this.lessThanButton.Location = new System.Drawing.Point(178, 306);
            this.lessThanButton.Name = "lessThanButton";
            this.lessThanButton.Size = new System.Drawing.Size(196, 45);
            this.lessThanButton.TabIndex = 12;
            this.lessThanButton.Text = "Менше";
            this.lessThanButton.UseVisualStyleBackColor = true;
            this.lessThanButton.Click += new System.EventHandler(this.lessThanButton_Click);
            // 
            // greaterThanOrEqualButton
            // 
            this.greaterThanOrEqualButton.Location = new System.Drawing.Point(12, 357);
            this.greaterThanOrEqualButton.Name = "greaterThanOrEqualButton";
            this.greaterThanOrEqualButton.Size = new System.Drawing.Size(269, 57);
            this.greaterThanOrEqualButton.TabIndex = 13;
            this.greaterThanOrEqualButton.Text = "Більше або дорівнює";
            this.greaterThanOrEqualButton.UseVisualStyleBackColor = true;
            this.greaterThanOrEqualButton.Click += new System.EventHandler(this.greaterThanOrEqualButton_Click);
            // 
            // lessThanOrEqualButton
            // 
            this.lessThanOrEqualButton.Location = new System.Drawing.Point(299, 360);
            this.lessThanOrEqualButton.Name = "lessThanOrEqualButton";
            this.lessThanOrEqualButton.Size = new System.Drawing.Size(258, 50);
            this.lessThanOrEqualButton.TabIndex = 14;
            this.lessThanOrEqualButton.Text = "Менше або дорівнює";
            this.lessThanOrEqualButton.UseVisualStyleBackColor = true;
            this.lessThanOrEqualButton.Click += new System.EventHandler(this.lessThanOrEqualButton_Click);
            // 
            // powerTextBox
            // 
            this.powerTextBox.Location = new System.Drawing.Point(769, 295);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(170, 29);
            this.powerTextBox.TabIndex = 15;
            // 
            // numeratorTextBox
            // 
            this.numeratorTextBox.Location = new System.Drawing.Point(667, 12);
            this.numeratorTextBox.Name = "numeratorTextBox";
            this.numeratorTextBox.Size = new System.Drawing.Size(185, 29);
            this.numeratorTextBox.TabIndex = 16;
            // 
            // denominatorTextBox
            // 
            this.denominatorTextBox.Location = new System.Drawing.Point(668, 47);
            this.denominatorTextBox.Name = "denominatorTextBox";
            this.denominatorTextBox.Size = new System.Drawing.Size(184, 29);
            this.denominatorTextBox.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(868, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 29);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Чисельник";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(868, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 29);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "Знаменник";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 578);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.denominatorTextBox);
            this.Controls.Add(this.numeratorTextBox);
            this.Controls.Add(this.powerTextBox);
            this.Controls.Add(this.lessThanOrEqualButton);
            this.Controls.Add(this.greaterThanOrEqualButton);
            this.Controls.Add(this.lessThanButton);
            this.Controls.Add(this.greaterThanButton);
            this.Controls.Add(this.notEqualButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.reduceButton);
            this.Controls.Add(this.divideFractionsButton);
            this.Controls.Add(this.multiplyFractionsButton);
            this.Controls.Add(this.subtractFractionsButton);
            this.Controls.Add(this.addFractionsButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.fractionsListBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox fractionsListBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button addFractionsButton;
        private System.Windows.Forms.Button subtractFractionsButton;
        private System.Windows.Forms.Button multiplyFractionsButton;
        private System.Windows.Forms.Button divideFractionsButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button notEqualButton;
        private System.Windows.Forms.Button greaterThanButton;
        private System.Windows.Forms.Button lessThanButton;
        private System.Windows.Forms.Button greaterThanOrEqualButton;
        private System.Windows.Forms.Button lessThanOrEqualButton;
        private System.Windows.Forms.TextBox powerTextBox;
        private System.Windows.Forms.TextBox numeratorTextBox;
        private System.Windows.Forms.TextBox denominatorTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

