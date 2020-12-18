namespace labTrainerAccount
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer5 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.primer = new System.Windows.Forms.Label();
            this.goodLabel = new System.Windows.Forms.Label();
            this.badLabel = new System.Windows.Forms.Label();
            this.lvlDown = new System.Windows.Forms.Button();
            this.lvlUp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62779F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37221F));
            this.tableLayoutPanel2.Controls.Add(this.answer1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.answer3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.answer5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.answer2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.answer4, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 220);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(537, 174);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // answer1
            // 
            this.answer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer1.Location = new System.Drawing.Point(4, 4);
            this.answer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(258, 64);
            this.answer1.TabIndex = 0;
            this.answer1.Text = "Ответ 1";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(4, 76);
            this.answer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(257, 47);
            this.answer3.TabIndex = 2;
            this.answer3.Text = "Ответ3";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer5
            // 
            this.answer5.Location = new System.Drawing.Point(4, 131);
            this.answer5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer5.Name = "answer5";
            this.answer5.Size = new System.Drawing.Size(257, 39);
            this.answer5.TabIndex = 4;
            this.answer5.Text = "Ответ5";
            this.answer5.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer2.Location = new System.Drawing.Point(270, 4);
            this.answer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(263, 64);
            this.answer2.TabIndex = 1;
            this.answer2.Text = "Ответ2";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(270, 76);
            this.answer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(263, 47);
            this.answer4.TabIndex = 3;
            this.answer4.Text = "Ответ4";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // primer
            // 
            this.primer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primer.Location = new System.Drawing.Point(17, 11);
            this.primer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.primer.Name = "primer";
            this.primer.Size = new System.Drawing.Size(533, 206);
            this.primer.TabIndex = 3;
            this.primer.Text = "10+11=24";
            this.primer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // goodLabel
            // 
            this.goodLabel.AutoSize = true;
            this.goodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.goodLabel.Location = new System.Drawing.Point(28, 426);
            this.goodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.goodLabel.Name = "goodLabel";
            this.goodLabel.Size = new System.Drawing.Size(30, 31);
            this.goodLabel.TabIndex = 4;
            this.goodLabel.Text = "0";
            // 
            // badLabel
            // 
            this.badLabel.AutoSize = true;
            this.badLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.badLabel.ForeColor = System.Drawing.Color.Red;
            this.badLabel.Location = new System.Drawing.Point(284, 426);
            this.badLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.badLabel.Name = "badLabel";
            this.badLabel.Size = new System.Drawing.Size(30, 31);
            this.badLabel.TabIndex = 5;
            this.badLabel.Text = "0";
            // 
            // lvlDown
            // 
            this.lvlDown.BackColor = System.Drawing.Color.GreenYellow;
            this.lvlDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lvlDown.Location = new System.Drawing.Point(51, 16);
            this.lvlDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvlDown.Name = "lvlDown";
            this.lvlDown.Size = new System.Drawing.Size(184, 28);
            this.lvlDown.TabIndex = 6;
            this.lvlDown.Text = "Уровень сложности 1";
            this.lvlDown.UseVisualStyleBackColor = false;
            this.lvlDown.Click += new System.EventHandler(this.lvlDown_Click);
            // 
            // lvlUp
            // 
            this.lvlUp.BackColor = System.Drawing.Color.Gainsboro;
            this.lvlUp.Location = new System.Drawing.Point(284, 16);
            this.lvlUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvlUp.Name = "lvlUp";
            this.lvlUp.Size = new System.Drawing.Size(231, 28);
            this.lvlUp.TabIndex = 7;
            this.lvlUp.Text = "Уровень сложности 2";
            this.lvlUp.UseVisualStyleBackColor = false;
            this.lvlUp.Click += new System.EventHandler(this.lvlUp_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 498);
            this.Controls.Add(this.lvlUp);
            this.Controls.Add(this.lvlDown);
            this.Controls.Add(this.badLabel);
            this.Controls.Add(this.goodLabel);
            this.Controls.Add(this.primer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(586, 536);
            this.Name = "Form1";
            this.Text = "labTrainerAccount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Label primer;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button answer5;
        private System.Windows.Forms.Label goodLabel;
        private System.Windows.Forms.Label badLabel;
        private System.Windows.Forms.Button lvlDown;
        private System.Windows.Forms.Button lvlUp;
        private System.Windows.Forms.Timer timer1;
    }
}

