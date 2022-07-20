using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Xml;

namespace РедакторГраф
{
    public partial class Form1 : Form
    {
        bool drawing;
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        public Color historyColor;
        List<Image> History;
        public int historyCounter;
        public Form1()
        {
            InitializeComponent();

            drawing = false;
            currentPen = new Pen(Color.Black);
            History = new List<Image>();
        }
        //Смены языка редактора
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            уменьшитьToolStripMenuItem.Text = "Del Size";
            увеличитьToolStripMenuItem.Text = "Add Size";

            размерКистиToolStripMenuItem.Text = "Size Brush";

            englishToolStripMenuItem.Checked = true;
            русскийToolStripMenuItem.Checked = false;
            файлToolStripMenuItem.Text = "File";
            новыйToolStripMenuItem.Text = "New Project";
            открытьПроектToolStripMenuItem.Text = "Open Project";
            сохранитьПроектToolStripMenuItem.Text = "Save Project";
            выходToolStripMenuItem.Text = "Exit";

            правкаToolStripMenuItem.Text = "Edit";
            назадToolStripMenuItem.Text = "Undo";
            впередToolStripMenuItem.Text = "Reno";

            инструментыToolStripMenuItem.Text = "Instruments";

            настройкиToolStripMenuItem.Text = "Settings";
            языкToolStripMenuItem.Text = "Language";


        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {

            уменьшитьToolStripMenuItem.Text = "Уменьшить";
            увеличитьToolStripMenuItem.Text = "Увеличить";

            размерКистиToolStripMenuItem.Text = "Размер Кисти";

            englishToolStripMenuItem.Checked = false;
            русскийToolStripMenuItem.Checked = true;
            файлToolStripMenuItem.Text = "Файл";
            новыйToolStripMenuItem.Text = "Новый Проект";
            открытьПроектToolStripMenuItem.Text = "Открыть Проект";
            сохранитьПроектToolStripMenuItem.Text = "Сохранить Проект";
            выходToolStripMenuItem.Text = "Выход";

            правкаToolStripMenuItem.Text = "Правка";
            назадToolStripMenuItem.Text = "Назад";
            впередToolStripMenuItem.Text = "Вперед";

            инструментыToolStripMenuItem.Text = "Инструменты";

            настройкиToolStripMenuItem.Text = "Настройки";
            языкToolStripMenuItem.Text = "Язык";
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: сохранитьПроектToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(3000, 3000);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));
        }


        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4;
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "")
            {
                FileStream fs = (FileStream)SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg); break;

                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp); break;

                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif); break;

                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png); break;
                }

                fs.Close();
            }
        }

        private void открытьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1;
            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);
            picDrawingSurface.AutoSize = true;
            History.Clear();
            historyCounter = 0;
            History.Add(new Bitmap(picDrawingSurface.Image));
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void впередToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.No:
                        break;
                    case DialogResult.Yes:
                        сохранитьПроектToolStripMenuItem_Click(sender, e);
                        break;
                }
            }
            Application.Exit();

        }

   
        private void picDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {//Координаты
           label1.Text = e.X.ToString() + ", " + e.Y.ToString();
            if (drawing)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
            }

        }

        private void picDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!"); return;
            }
            else if (квадратToolStripMenuItem1.Checked == true)
            {
                ColorDialog c = new ColorDialog();
                if (c.ShowDialog() == DialogResult.OK)
                {
                    currentPen.Color = c.Color;

                }
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                SolidBrush sb = new SolidBrush(currentPen.Color);
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                g.FillRectangle(sb, e.X, e.Y, currentPen.Width * 50, currentPen.Width * 50);

                drawing = false;

                квадратToolStripMenuItem1.Checked = false;

            }
            else if (прямоуголникToolStripMenuItem.Checked == true)
            {
                ColorDialog c = new ColorDialog();
                if (c.ShowDialog() == DialogResult.OK)
                {
                    currentPen.Color = c.Color;

                }
                drawing = true;
                SolidBrush sb = new SolidBrush(currentPen.Color);
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                g.FillRectangle(sb, e.X, e.Y, 2 * currentPen.Width * 50, currentPen.Width * 50);

                drawing = false;
                прямоуголникToolStripMenuItem.Checked = false;

            }
            else if (кругToolStripMenuItem.Checked == true)
            {
                ColorDialog c = new ColorDialog();
                if (c.ShowDialog() == DialogResult.OK)
                {
                    currentPen.Color = c.Color;

                }
                drawing = true;
                SolidBrush sb = new SolidBrush(currentPen.Color);
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                g.FillEllipse(sb, e.X, e.Y, currentPen.Width * 50, currentPen.Width * 50);

                drawing = false;
                кругToolStripMenuItem.Checked = false;

            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    drawing = true;
                    oldLocation = e.Location;
                    currentPath = new GraphicsPath();
                }

            }





        }

        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
            if (e.Button == MouseButtons.Left)
            {
                drawing = false;
                try
                {
                    currentPath.Dispose();
                }
                catch { };
                
            }
            else if (e.Button == MouseButtons.Right)
            {
                drawing = false;
                try
                {
                    currentPath.Dispose();
                }
                catch { };
                currentPen.Color = historyColor;
            }



        }

     

        private void увеличитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.Width += 1;
            if (currentPen.Width == 11)
            {
                currentPen.Width = 10;
            }
        }

        private void уменьшитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.Width -= 1;
            if (currentPen.Width == -1)
            {
                currentPen.Width = 0;
            }
        }

        private void kist1_Click(object sender, EventArgs e)
        {
            currentPen.Color = historyColor;
            currentPen.DashStyle = DashStyle.Solid;
            historyColor = currentPen.Color;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            currentPen.Color = historyColor;
            currentPen.DashStyle = DashStyle.Dot;

        }

        private void Палитра_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentPen.Color = colorDialog.Color;
            }
        }

        private void Ластик_Click(object sender, EventArgs e)
        {

            historyColor = currentPen.Color;
            currentPen.Color = Color.White;
        }
        //Заливка фона
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!"); return;
            }
            else { }
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                picDrawingSurface.BackColor = c.Color;

            }

        }

        private void квадратToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            квадратToolStripMenuItem1.Checked = true;

        }

       

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            кругToolStripMenuItem.Checked = true;
        }

        private void прямоуголникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            прямоуголникToolStripMenuItem.Checked = true;
        }

        private void очиститьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picDrawingSurface.Image = null;
        }
    }
}
