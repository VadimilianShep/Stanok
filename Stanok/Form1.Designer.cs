namespace Stanok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            progressBar1 = new ProgressBar();
            monthCalendar1 = new MonthCalendar();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            свойстваToolStripMenuItem = new ToolStripMenuItem();
            просмотрToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 101);
            button1.Name = "button1";
            button1.Size = new Size(164, 31);
            button1.TabIndex = 0;
            button1.Text = "Инструкция";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(475, 627);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(447, 23);
            progressBar1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 488);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(716, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(506, 516);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(12, 129);
            button2.Name = "button2";
            button2.Size = new Size(164, 32);
            button2.TabIndex = 4;
            button2.Text = "Штрафы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 159);
            button3.Name = "button3";
            button3.Size = new Size(164, 31);
            button3.TabIndex = 5;
            button3.Text = "Документы";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 186);
            button4.Name = "button4";
            button4.Size = new Size(164, 33);
            button4.TabIndex = 6;
            button4.Text = "Нормативы";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 215);
            button5.Name = "button5";
            button5.Size = new Size(164, 33);
            button5.TabIndex = 7;
            button5.Text = "Часы работы";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 244);
            button6.Name = "button6";
            button6.Size = new Size(164, 33);
            button6.TabIndex = 8;
            button6.Text = "Отработанное время";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 274);
            button7.Name = "button7";
            button7.Size = new Size(164, 32);
            button7.TabIndex = 9;
            button7.Text = "Настройки";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 302);
            button8.Name = "button8";
            button8.Size = new Size(164, 33);
            button8.TabIndex = 10;
            button8.Text = "Резерв";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(12, 332);
            button9.Name = "button9";
            button9.Size = new Size(164, 32);
            button9.TabIndex = 11;
            button9.Text = "Аварийный режим";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(12, 361);
            button10.Name = "button10";
            button10.Size = new Size(164, 32);
            button10.TabIndex = 12;
            button10.Text = "Обед";
            button10.UseVisualStyleBackColor = true;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = SystemColors.ControlLight;
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, свойстваToolStripMenuItem, просмотрToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1234, 24);
            menuStrip2.TabIndex = 14;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(93, 20);
            toolStripMenuItem1.Text = "Информация";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(149, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // свойстваToolStripMenuItem
            // 
            свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            свойстваToolStripMenuItem.Size = new Size(70, 20);
            свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // просмотрToolStripMenuItem
            // 
            просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            просмотрToolStripMenuItem.Size = new Size(76, 20);
            просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(192, 70);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(499, 516);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 40);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 16;
            label1.Text = "Камера безопасности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(904, 40);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 17;
            label2.Text = "Камера присутствия";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1234, 668);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private MonthCalendar monthCalendar1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem свойстваToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PrintDialog printDialog1;
    }
}