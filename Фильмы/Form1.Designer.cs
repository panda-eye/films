namespace Фильмы
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kontent = new System.Windows.Forms.ToolStripMenuItem();
            this.общийПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоЖанруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоГодуВыходаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоАвторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаСтартовуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыКиноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сейчасВКиноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинотеатрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.киевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.купитьБилетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связатьсяСАвторомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloading = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.name1 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.name4 = new System.Windows.Forms.Label();
            this.name5 = new System.Windows.Forms.Label();
            this.name6 = new System.Windows.Forms.Label();
            this.format1 = new System.Windows.Forms.Label();
            this.format2 = new System.Windows.Forms.Label();
            this.format3 = new System.Windows.Forms.Label();
            this.format4 = new System.Windows.Forms.Label();
            this.format5 = new System.Windows.Forms.Label();
            this.format6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontent,
            this.сеансыКиноToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(802, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kontent
            // 
            this.kontent.CheckOnClick = true;
            this.kontent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общийПоискToolStripMenuItem,
            this.поискПоНазваниюToolStripMenuItem,
            this.поискПоЖанруToolStripMenuItem,
            this.поискПоГодуВыходаToolStripMenuItem,
            this.поискПоАвторуToolStripMenuItem,
            this.вернутьсяНаСтартовуюСтраницуToolStripMenuItem,
            this.вToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.kontent.Name = "kontent";
            this.kontent.Size = new System.Drawing.Size(63, 19);
            this.kontent.Text = "Контент";
            // 
            // общийПоискToolStripMenuItem
            // 
            this.общийПоискToolStripMenuItem.Name = "общийПоискToolStripMenuItem";
            this.общийПоискToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.общийПоискToolStripMenuItem.Text = "Общий поиск";
            // 
            // поискПоНазваниюToolStripMenuItem
            // 
            this.поискПоНазваниюToolStripMenuItem.Name = "поискПоНазваниюToolStripMenuItem";
            this.поискПоНазваниюToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.поискПоНазваниюToolStripMenuItem.Text = "Поиск по названию";
            // 
            // поискПоЖанруToolStripMenuItem
            // 
            this.поискПоЖанруToolStripMenuItem.Name = "поискПоЖанруToolStripMenuItem";
            this.поискПоЖанруToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.поискПоЖанруToolStripMenuItem.Text = "Поиск по жанру";
            // 
            // поискПоГодуВыходаToolStripMenuItem
            // 
            this.поискПоГодуВыходаToolStripMenuItem.Name = "поискПоГодуВыходаToolStripMenuItem";
            this.поискПоГодуВыходаToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.поискПоГодуВыходаToolStripMenuItem.Text = "Поиск по году выхода";
            // 
            // поискПоАвторуToolStripMenuItem
            // 
            this.поискПоАвторуToolStripMenuItem.Name = "поискПоАвторуToolStripMenuItem";
            this.поискПоАвторуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.поискПоАвторуToolStripMenuItem.Text = "Поиск по автору";
            // 
            // вернутьсяНаСтартовуюСтраницуToolStripMenuItem
            // 
            this.вернутьсяНаСтартовуюСтраницуToolStripMenuItem.Name = "вернутьсяНаСтартовуюСтраницуToolStripMenuItem";
            this.вернутьсяНаСтартовуюСтраницуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.вернутьсяНаСтартовуюСтраницуToolStripMenuItem.Text = "Назад";
            // 
            // вToolStripMenuItem
            // 
            this.вToolStripMenuItem.Name = "вToolStripMenuItem";
            this.вToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.вToolStripMenuItem.Text = "Главное меню";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // сеансыКиноToolStripMenuItem
            // 
            this.сеансыКиноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сейчасВКиноToolStripMenuItem,
            this.кинотеатрыToolStripMenuItem,
            this.купитьБилетToolStripMenuItem});
            this.сеансыКиноToolStripMenuItem.Name = "сеансыКиноToolStripMenuItem";
            this.сеансыКиноToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.сеансыКиноToolStripMenuItem.Text = "Сеансы кино";
            // 
            // сейчасВКиноToolStripMenuItem
            // 
            this.сейчасВКиноToolStripMenuItem.Name = "сейчасВКиноToolStripMenuItem";
            this.сейчасВКиноToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.сейчасВКиноToolStripMenuItem.Text = "Сейчас в кино";
            // 
            // кинотеатрыToolStripMenuItem
            // 
            this.кинотеатрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.киевToolStripMenuItem});
            this.кинотеатрыToolStripMenuItem.Name = "кинотеатрыToolStripMenuItem";
            this.кинотеатрыToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.кинотеатрыToolStripMenuItem.Text = "Кинотеатры";
            // 
            // киевToolStripMenuItem
            // 
            this.киевToolStripMenuItem.Name = "киевToolStripMenuItem";
            this.киевToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.киевToolStripMenuItem.Text = "Киев";
            // 
            // купитьБилетToolStripMenuItem
            // 
            this.купитьБилетToolStripMenuItem.Name = "купитьБилетToolStripMenuItem";
            this.купитьБилетToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.купитьБилетToolStripMenuItem.Text = "Купить билет";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шрифтToolStripMenuItem,
            this.фонToolStripMenuItem,
            this.связатьсяСАвторомToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.фонToolStripMenuItem.Text = "Фон";
            // 
            // связатьсяСАвторомToolStripMenuItem
            // 
            this.связатьсяСАвторомToolStripMenuItem.Name = "связатьсяСАвторомToolStripMenuItem";
            this.связатьсяСАвторомToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.связатьсяСАвторомToolStripMenuItem.Text = "Связаться с автором";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.разработчикToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 19);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            // 
            // downloading
            // 
            this.downloading.WorkerReportsProgress = true;
            this.downloading.WorkerSupportsCancellation = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.World, ((byte)(240)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИЛЬМЫ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 133);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Что посмотреть?";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(90, 133);
            this.panel2.TabIndex = 3;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(399, 148);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 133);
            this.panel4.TabIndex = 4;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(399, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 133);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(23, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 133);
            this.panel3.TabIndex = 5;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(399, 497);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 133);
            this.panel6.TabIndex = 5;
            this.panel6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(128, 148);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(46, 18);
            this.name1.TabIndex = 6;
            this.name1.Text = "name";
            this.name1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Location = new System.Drawing.Point(128, 319);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(46, 18);
            this.name2.TabIndex = 7;
            this.name2.Text = "name";
            this.name2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Location = new System.Drawing.Point(128, 497);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(46, 18);
            this.name3.TabIndex = 8;
            this.name3.Text = "name";
            this.name3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // name4
            // 
            this.name4.AutoSize = true;
            this.name4.Location = new System.Drawing.Point(505, 148);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(46, 18);
            this.name4.TabIndex = 9;
            this.name4.Text = "name";
            this.name4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // name5
            // 
            this.name5.AutoSize = true;
            this.name5.Location = new System.Drawing.Point(505, 319);
            this.name5.Name = "name5";
            this.name5.Size = new System.Drawing.Size(46, 18);
            this.name5.TabIndex = 10;
            this.name5.Text = "name";
            this.name5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // name6
            // 
            this.name6.AutoSize = true;
            this.name6.Location = new System.Drawing.Point(505, 497);
            this.name6.Name = "name6";
            this.name6.Size = new System.Drawing.Size(46, 18);
            this.name6.TabIndex = 11;
            this.name6.Text = "name";
            this.name6.Click += new System.EventHandler(this.panel6_Click);
            // 
            // format1
            // 
            this.format1.AutoSize = true;
            this.format1.Font = new System.Drawing.Font("Georgia", 9.5F);
            this.format1.Location = new System.Drawing.Point(128, 172);
            this.format1.Name = "format1";
            this.format1.Size = new System.Drawing.Size(50, 16);
            this.format1.TabIndex = 12;
            this.format1.Text = "format";
            // 
            // format2
            // 
            this.format2.AutoSize = true;
            this.format2.Font = new System.Drawing.Font("Georgia", 9.5F);
            this.format2.Location = new System.Drawing.Point(128, 343);
            this.format2.Name = "format2";
            this.format2.Size = new System.Drawing.Size(50, 16);
            this.format2.TabIndex = 13;
            this.format2.Text = "format";
            // 
            // format3
            // 
            this.format3.AutoSize = true;
            this.format3.Font = new System.Drawing.Font("Georgia", 9.5F);
            this.format3.Location = new System.Drawing.Point(128, 521);
            this.format3.Name = "format3";
            this.format3.Size = new System.Drawing.Size(50, 16);
            this.format3.TabIndex = 14;
            this.format3.Text = "format";
            // 
            // format4
            // 
            this.format4.AutoSize = true;
            this.format4.Font = new System.Drawing.Font("Georgia", 9.5F);
            this.format4.Location = new System.Drawing.Point(505, 172);
            this.format4.Name = "format4";
            this.format4.Size = new System.Drawing.Size(50, 16);
            this.format4.TabIndex = 15;
            this.format4.Text = "format";
            // 
            // format5
            // 
            this.format5.AutoSize = true;
            this.format5.Font = new System.Drawing.Font("Georgia", 9.5F);
            this.format5.Location = new System.Drawing.Point(505, 343);
            this.format5.Name = "format5";
            this.format5.Size = new System.Drawing.Size(50, 16);
            this.format5.TabIndex = 16;
            this.format5.Text = "format";
            // 
            // format6
            // 
            this.format6.AutoSize = true;
            this.format6.Font = new System.Drawing.Font("Georgia", 9.5F);
            this.format6.Location = new System.Drawing.Point(505, 521);
            this.format6.Name = "format6";
            this.format6.Size = new System.Drawing.Size(50, 16);
            this.format6.TabIndex = 17;
            this.format6.Text = "format";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 682);
            this.Controls.Add(this.format6);
            this.Controls.Add(this.format5);
            this.Controls.Add(this.format4);
            this.Controls.Add(this.format3);
            this.Controls.Add(this.format2);
            this.Controls.Add(this.format1);
            this.Controls.Add(this.name6);
            this.Controls.Add(this.name5);
            this.Controls.Add(this.name4);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(802, 682);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильмы";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kontent;
        private System.Windows.Forms.ToolStripMenuItem общийПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоЖанруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоГодуВыходаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоАвторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеансыКиноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сейчасВКиноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинотеатрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem киевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem купитьБилетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker downloading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаСтартовуюСтраницуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связатьсяСАвторомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label name4;
        private System.Windows.Forms.Label name5;
        private System.Windows.Forms.Label name6;
        private System.Windows.Forms.Label format1;
        private System.Windows.Forms.Label format2;
        private System.Windows.Forms.Label format3;
        private System.Windows.Forms.Label format4;
        private System.Windows.Forms.Label format5;
        private System.Windows.Forms.Label format6;
    }
}

