namespace CityPhonesApp
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
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cityCodeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.FormattingEnabled = true;
            this.cityBox.Location = new System.Drawing.Point(339, 172);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(178, 21);
            this.cityBox.TabIndex = 1;
            this.cityBox.SelectedIndexChanged += new System.EventHandler(this.cityBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(285, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Город";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(388, 220);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(129, 20);
            this.phoneTextBox.TabIndex = 3;
            // 
            // cityCodeTextBox
            // 
            this.cityCodeTextBox.Location = new System.Drawing.Point(339, 220);
            this.cityCodeTextBox.Name = "cityCodeTextBox";
            this.cityCodeTextBox.Size = new System.Drawing.Size(43, 20);
            this.cityCodeTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(265, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(239, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Информация";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(340, 262);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(177, 101);
            this.infoTextBox.TabIndex = 7;
            this.infoTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(368, 369);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(107, 46);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Показать информацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityCodeTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityBox);
            this.Name = "Form1";
            this.Text = "Домашний телефон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox cityCodeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox infoTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button button1;
    }
}

