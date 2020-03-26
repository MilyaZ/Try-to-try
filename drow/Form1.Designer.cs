namespace drow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.figures = new System.Windows.Forms.GroupBox();
            this.Star = new System.Windows.Forms.Button();
            this.Arrow = new System.Windows.Forms.Button();
            this.Regular_polynom = new System.Windows.Forms.Button();
            this.t90 = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.transparent = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.purple = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.ColorGB = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fill = new System.Windows.Forms.CheckBox();
            this.Pick1 = new System.Windows.Forms.Button();
            this.Palette = new System.Windows.Forms.Button();
            this.Pick = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.ruler = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clean = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.StyleCB = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Open = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Save_Open = new System.Windows.Forms.GroupBox();
            this.figures.SuspendLayout();
            this.ColorGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Setting.SuspendLayout();
            this.Save_Open.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.Chocolate;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(2047, 870);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 366);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // figures
            // 
            this.figures.Controls.Add(this.Star);
            this.figures.Controls.Add(this.Arrow);
            this.figures.Controls.Add(this.Regular_polynom);
            this.figures.Controls.Add(this.t90);
            this.figures.Controls.Add(this.circle);
            this.figures.Controls.Add(this.triangle);
            this.figures.Controls.Add(this.rectangle);
            this.figures.Location = new System.Drawing.Point(566, 7);
            this.figures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.figures.Name = "figures";
            this.figures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.figures.Size = new System.Drawing.Size(416, 113);
            this.figures.TabIndex = 22;
            this.figures.TabStop = false;
            this.figures.Text = "Фигуры";
            // 
            // Star
            // 
            this.Star.Image = ((System.Drawing.Image)(resources.GetObject("Star.Image")));
            this.Star.Location = new System.Drawing.Point(357, 32);
            this.Star.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(53, 49);
            this.Star.TabIndex = 27;
            this.Star.UseVisualStyleBackColor = true;
            this.Star.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // Arrow
            // 
            this.Arrow.Image = ((System.Drawing.Image)(resources.GetObject("Arrow.Image")));
            this.Arrow.Location = new System.Drawing.Point(299, 32);
            this.Arrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(53, 49);
            this.Arrow.TabIndex = 26;
            this.Arrow.UseVisualStyleBackColor = true;
            this.Arrow.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // Regular_polynom
            // 
            this.Regular_polynom.Image = ((System.Drawing.Image)(resources.GetObject("Regular_polynom.Image")));
            this.Regular_polynom.Location = new System.Drawing.Point(240, 32);
            this.Regular_polynom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Regular_polynom.Name = "Regular_polynom";
            this.Regular_polynom.Size = new System.Drawing.Size(53, 49);
            this.Regular_polynom.TabIndex = 24;
            this.Regular_polynom.UseVisualStyleBackColor = true;
            this.Regular_polynom.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // t90
            // 
            this.t90.Image = ((System.Drawing.Image)(resources.GetObject("t90.Image")));
            this.t90.Location = new System.Drawing.Point(181, 33);
            this.t90.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.t90.Name = "t90";
            this.t90.Size = new System.Drawing.Size(53, 49);
            this.t90.TabIndex = 22;
            this.t90.UseVisualStyleBackColor = true;
            this.t90.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // circle
            // 
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(5, 32);
            this.circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(53, 49);
            this.circle.TabIndex = 18;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // triangle
            // 
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.Location = new System.Drawing.Point(64, 32);
            this.triangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(53, 49);
            this.triangle.TabIndex = 20;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // rectangle
            // 
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(123, 33);
            this.rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(53, 49);
            this.rectangle.TabIndex = 19;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.ForeColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(5, 12);
            this.red.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(35, 28);
            this.red.TabIndex = 0;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            this.red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.ForeColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(5, 43);
            this.green.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(35, 28);
            this.green.TabIndex = 1;
            this.green.Text = "green";
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.red_Click);
            this.green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // transparent
            // 
            this.transparent.BackColor = System.Drawing.Color.Transparent;
            this.transparent.ForeColor = System.Drawing.Color.Transparent;
            this.transparent.Location = new System.Drawing.Point(85, 74);
            this.transparent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transparent.Name = "transparent";
            this.transparent.Size = new System.Drawing.Size(35, 28);
            this.transparent.TabIndex = 2;
            this.transparent.UseVisualStyleBackColor = false;
            this.transparent.Click += new System.EventHandler(this.red_Click);
            this.transparent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.Orange;
            this.orange.ForeColor = System.Drawing.Color.Orange;
            this.orange.Location = new System.Drawing.Point(45, 12);
            this.orange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(35, 28);
            this.orange.TabIndex = 3;
            this.orange.Text = "orange";
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.red_Click);
            this.orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.ForeColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(45, 43);
            this.blue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(35, 28);
            this.blue.TabIndex = 4;
            this.blue.Text = "blue";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.red_Click);
            this.blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(5, 74);
            this.black.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(35, 28);
            this.black.TabIndex = 5;
            this.black.Text = "black";
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.red_Click);
            this.black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.ForeColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(85, 12);
            this.yellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(35, 28);
            this.yellow.TabIndex = 6;
            this.yellow.Text = "yellow";
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.red_Click);
            this.yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.ForeColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(85, 43);
            this.purple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(35, 28);
            this.purple.TabIndex = 7;
            this.purple.Text = "purple";
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.red_Click);
            this.purple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.ForeColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(45, 74);
            this.white.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(35, 28);
            this.white.TabIndex = 8;
            this.white.Text = "white";
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.red_Click);
            this.white.MouseDown += new System.Windows.Forms.MouseEventHandler(this.red_MouseDown);
            // 
            // ColorGB
            // 
            this.ColorGB.Controls.Add(this.label3);
            this.ColorGB.Controls.Add(this.label2);
            this.ColorGB.Controls.Add(this.Fill);
            this.ColorGB.Controls.Add(this.Pick1);
            this.ColorGB.Controls.Add(this.Palette);
            this.ColorGB.Controls.Add(this.Pick);
            this.ColorGB.Controls.Add(this.white);
            this.ColorGB.Controls.Add(this.purple);
            this.ColorGB.Controls.Add(this.yellow);
            this.ColorGB.Controls.Add(this.black);
            this.ColorGB.Controls.Add(this.blue);
            this.ColorGB.Controls.Add(this.orange);
            this.ColorGB.Controls.Add(this.transparent);
            this.ColorGB.Controls.Add(this.green);
            this.ColorGB.Controls.Add(this.red);
            this.ColorGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorGB.Location = new System.Drawing.Point(77, 7);
            this.ColorGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorGB.Name = "ColorGB";
            this.ColorGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorGB.Size = new System.Drawing.Size(233, 113);
            this.ColorGB.TabIndex = 9;
            this.ColorGB.TabStop = false;
            this.ColorGB.Text = "Цвета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Перо";
            // 
            // Fill
            // 
            this.Fill.AutoSize = true;
            this.Fill.Location = new System.Drawing.Point(128, 85);
            this.Fill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(85, 21);
            this.Fill.TabIndex = 25;
            this.Fill.Text = "Заливка";
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.CheckedChanged += new System.EventHandler(this.Fill_CheckedChanged);
            // 
            // Pick1
            // 
            this.Pick1.BackColor = System.Drawing.Color.Black;
            this.Pick1.ForeColor = System.Drawing.Color.Black;
            this.Pick1.Location = new System.Drawing.Point(128, 62);
            this.Pick1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pick1.Name = "Pick1";
            this.Pick1.Size = new System.Drawing.Size(20, 18);
            this.Pick1.TabIndex = 10;
            this.Pick1.UseVisualStyleBackColor = false;
            this.Pick1.Click += new System.EventHandler(this.Pick_Click);
            // 
            // Palette
            // 
            this.Palette.Image = ((System.Drawing.Image)(resources.GetObject("Palette.Image")));
            this.Palette.Location = new System.Drawing.Point(127, 10);
            this.Palette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Palette.Name = "Palette";
            this.Palette.Size = new System.Drawing.Size(73, 28);
            this.Palette.TabIndex = 10;
            this.Palette.UseVisualStyleBackColor = true;
            this.Palette.Click += new System.EventHandler(this.Palette_Click);
            // 
            // Pick
            // 
            this.Pick.BackColor = System.Drawing.Color.Black;
            this.Pick.ForeColor = System.Drawing.Color.Black;
            this.Pick.Location = new System.Drawing.Point(128, 41);
            this.Pick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pick.Name = "Pick";
            this.Pick.Size = new System.Drawing.Size(20, 18);
            this.Pick.TabIndex = 9;
            this.Pick.UseVisualStyleBackColor = false;
            this.Pick.Click += new System.EventHandler(this.Pick_Click);
            // 
            // pencil
            // 
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.Location = new System.Drawing.Point(5, 15);
            this.pencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(40, 37);
            this.pencil.TabIndex = 10;
            this.pencil.UseVisualStyleBackColor = true;
            this.pencil.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // ruler
            // 
            this.ruler.Image = ((System.Drawing.Image)(resources.GetObject("ruler.Image")));
            this.ruler.Location = new System.Drawing.Point(5, 49);
            this.ruler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ruler.Name = "ruler";
            this.ruler.Size = new System.Drawing.Size(40, 37);
            this.ruler.TabIndex = 11;
            this.ruler.UseVisualStyleBackColor = true;
            this.ruler.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // eraser
            // 
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.Location = new System.Drawing.Point(51, 15);
            this.eraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(40, 37);
            this.eraser.TabIndex = 12;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(51, 49);
            this.background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(40, 37);
            this.background.TabIndex = 13;
            this.background.UseVisualStyleBackColor = true;
            this.background.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.background);
            this.groupBox2.Controls.Add(this.clean);
            this.groupBox2.Controls.Add(this.eraser);
            this.groupBox2.Controls.Add(this.ruler);
            this.groupBox2.Controls.Add(this.pencil);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(316, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(111, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Инструмент";
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.White;
            this.clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clean.Location = new System.Drawing.Point(5, 86);
            this.clean.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(85, 22);
            this.clean.TabIndex = 17;
            this.clean.Text = "Очистить все\r\n";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(991, 126);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(5, 23);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(116, 22);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.StyleCB);
            this.Setting.Controls.Add(this.numericUpDown1);
            this.Setting.Location = new System.Drawing.Point(432, 7);
            this.Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Setting.Size = new System.Drawing.Size(128, 113);
            this.Setting.TabIndex = 17;
            this.Setting.TabStop = false;
            this.Setting.Text = "Кисть";
            // 
            // StyleCB
            // 
            this.StyleCB.FormattingEnabled = true;
            this.StyleCB.Items.AddRange(new object[] {
            "Квадратики",
            "Полоски",
            "Диоганальки",
            "Шарики",
            "Сплошной"});
            this.StyleCB.Location = new System.Drawing.Point(5, 63);
            this.StyleCB.Margin = new System.Windows.Forms.Padding(4);
            this.StyleCB.Name = "StyleCB";
            this.StyleCB.Size = new System.Drawing.Size(115, 24);
            this.StyleCB.TabIndex = 19;
            this.StyleCB.Text = "Стиль";
            this.StyleCB.SelectedIndexChanged += new System.EventHandler(this.StyleCB_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(7, 12);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(45, 42);
            this.Save.TabIndex = 23;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.Location = new System.Drawing.Point(7, 55);
            this.Open.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(45, 42);
            this.Open.TabIndex = 24;
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Save_Open
            // 
            this.Save_Open.Controls.Add(this.Open);
            this.Save_Open.Controls.Add(this.Save);
            this.Save_Open.Location = new System.Drawing.Point(12, 7);
            this.Save_Open.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Open.Name = "Save_Open";
            this.Save_Open.Padding = new System.Windows.Forms.Padding(4);
            this.Save_Open.Size = new System.Drawing.Size(59, 113);
            this.Save_Open.TabIndex = 27;
            this.Save_Open.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 490);
            this.Controls.Add(this.figures);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Save_Open);
            this.Controls.Add(this.ColorGB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Рисовалка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.figures.ResumeLayout(false);
            this.ColorGB.ResumeLayout(false);
            this.ColorGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Setting.ResumeLayout(false);
            this.Save_Open.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button transparent;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.GroupBox ColorGB;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button ruler;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button background;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.GroupBox figures;
        private System.Windows.Forms.Button Palette;
        private System.Windows.Forms.Button Pick;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button t90;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Regular_polynom;
        private System.Windows.Forms.CheckBox Fill;
        private System.Windows.Forms.Button Pick1;
        private System.Windows.Forms.Button Arrow;
        private System.Windows.Forms.GroupBox Save_Open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StyleCB;
        private System.Windows.Forms.Button Star;
    }
}

