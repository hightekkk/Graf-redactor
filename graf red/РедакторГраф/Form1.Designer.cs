namespace РедакторГраф
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерКистиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picDrawingSurface = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kist1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Палитра = new System.Windows.Forms.ToolStripButton();
            this.Ластик = new System.Windows.Forms.ToolStripButton();
            this.Фигуры = new System.Windows.Forms.ToolStripSplitButton();
            this.квадратToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кругToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прямоуголникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.очиститьФормуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(816, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.открытьПроектToolStripMenuItem,
            this.сохранитьПроектToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.новыйToolStripMenuItem.Text = "Новый Проект";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьПроектToolStripMenuItem
            // 
            this.открытьПроектToolStripMenuItem.Name = "открытьПроектToolStripMenuItem";
            this.открытьПроектToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.открытьПроектToolStripMenuItem.Text = "Открыть Проект";
            this.открытьПроектToolStripMenuItem.Click += new System.EventHandler(this.открытьПроектToolStripMenuItem_Click);
            // 
            // сохранитьПроектToolStripMenuItem
            // 
            this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
            this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.сохранитьПроектToolStripMenuItem.Text = "Сохранить Проект";
            this.сохранитьПроектToolStripMenuItem.Click += new System.EventHandler(this.сохранитьПроектToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.выходToolStripMenuItem.Text = "Выход ";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.впередToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.впередToolStripMenuItem.Text = "Вперед";
            this.впередToolStripMenuItem.Click += new System.EventHandler(this.впередToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерКистиToolStripMenuItem,
            this.очиститьФормуToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // размерКистиToolStripMenuItem
            // 
            this.размерКистиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem});
            this.размерКистиToolStripMenuItem.Name = "размерКистиToolStripMenuItem";
            this.размерКистиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.размерКистиToolStripMenuItem.Text = "Размер кисти";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.увеличитьToolStripMenuItem.ShowShortcutKeys = false;
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить        Ctrl +";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.уменьшитьToolStripMenuItem.ShowShortcutKeys = false;
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить      Ctrl -";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.языкToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // языкToolStripMenuItem
            // 
            this.языкToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.языкToolStripMenuItem.Name = "языкToolStripMenuItem";
            this.языкToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.языкToolStripMenuItem.Text = "Язык";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // picDrawingSurface
            // 
            this.picDrawingSurface.BackColor = System.Drawing.SystemColors.Window;
            this.picDrawingSurface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDrawingSurface.Location = new System.Drawing.Point(0, 24);
            this.picDrawingSurface.Name = "picDrawingSurface";
            this.picDrawingSurface.Size = new System.Drawing.Size(816, 426);
            this.picDrawingSurface.TabIndex = 1;
            this.picDrawingSurface.TabStop = false;
            this.picDrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseDown);
            this.picDrawingSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseMove);
            this.picDrawingSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picDrawingSurface_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kist1,
            this.toolStripButton2,
            this.Палитра,
            this.Ластик,
            this.Фигуры,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(46, 426);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kist1
            // 
            this.kist1.AutoSize = false;
            this.kist1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kist1.Image = ((System.Drawing.Image)(resources.GetObject("kist1.Image")));
            this.kist1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kist1.Name = "kist1";
            this.kist1.Size = new System.Drawing.Size(30, 30);
            this.kist1.Text = "Сплошная кисть";
            this.kist1.Click += new System.EventHandler(this.kist1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(30, 30);
            this.toolStripButton2.Text = "Пунктирная кисть";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Палитра
            // 
            this.Палитра.AutoSize = false;
            this.Палитра.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Палитра.Image = ((System.Drawing.Image)(resources.GetObject("Палитра.Image")));
            this.Палитра.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Палитра.Name = "Палитра";
            this.Палитра.Size = new System.Drawing.Size(30, 30);
            this.Палитра.Text = "toolStripButton1";
            this.Палитра.ToolTipText = "Палитра";
            this.Палитра.Click += new System.EventHandler(this.Палитра_Click);
            // 
            // Ластик
            // 
            this.Ластик.AutoSize = false;
            this.Ластик.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ластик.Image = ((System.Drawing.Image)(resources.GetObject("Ластик.Image")));
            this.Ластик.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ластик.Name = "Ластик";
            this.Ластик.Size = new System.Drawing.Size(30, 30);
            this.Ластик.Text = "toolStripButton1";
            this.Ластик.ToolTipText = "Ластик";
            this.Ластик.Click += new System.EventHandler(this.Ластик_Click);
            // 
            // Фигуры
            // 
            this.Фигуры.AutoSize = false;
            this.Фигуры.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Фигуры.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратToolStripMenuItem1,
            this.кругToolStripMenuItem,
            this.прямоуголникToolStripMenuItem});
            this.Фигуры.Image = ((System.Drawing.Image)(resources.GetObject("Фигуры.Image")));
            this.Фигуры.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Фигуры.Name = "Фигуры";
            this.Фигуры.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Фигуры.Size = new System.Drawing.Size(30, 30);
            this.Фигуры.Text = "toolStripSplitButton1";
            this.Фигуры.ToolTipText = "Фигуры";
            // 
            // квадратToolStripMenuItem1
            // 
            this.квадратToolStripMenuItem1.Name = "квадратToolStripMenuItem1";
            this.квадратToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.квадратToolStripMenuItem1.Text = "Квадрат";
            this.квадратToolStripMenuItem1.Click += new System.EventHandler(this.квадратToolStripMenuItem1_Click);
            // 
            // кругToolStripMenuItem
            // 
            this.кругToolStripMenuItem.Name = "кругToolStripMenuItem";
            this.кругToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.кругToolStripMenuItem.Text = "Окружность";
            this.кругToolStripMenuItem.Click += new System.EventHandler(this.кругToolStripMenuItem_Click);
            // 
            // прямоуголникToolStripMenuItem
            // 
            this.прямоуголникToolStripMenuItem.Name = "прямоуголникToolStripMenuItem";
            this.прямоуголникToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.прямоуголникToolStripMenuItem.Text = "Прямоуголник";
            this.прямоуголникToolStripMenuItem.Click += new System.EventHandler(this.прямоуголникToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 20);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Заливка Фона";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // очиститьФормуToolStripMenuItem
            // 
            this.очиститьФормуToolStripMenuItem.Name = "очиститьФормуToolStripMenuItem";
            this.очиститьФормуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьФормуToolStripMenuItem.Text = "Очистить форму";
            this.очиститьФормуToolStripMenuItem.Click += new System.EventHandler(this.очиститьФормуToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.picDrawingSurface);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDrawingSurface)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.PictureBox picDrawingSurface;
        private System.Windows.Forms.ToolStripMenuItem языкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерКистиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        public System.Windows.Forms.ToolStripButton kist1;
        private System.Windows.Forms.ToolStripButton Палитра;
        private System.Windows.Forms.ToolStripButton Ластик;
        private System.Windows.Forms.ToolStripSplitButton Фигуры;
        private System.Windows.Forms.ToolStripMenuItem квадратToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кругToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem прямоуголникToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem очиститьФормуToolStripMenuItem;
    }
}

