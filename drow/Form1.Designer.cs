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
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.brown = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.purple = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.GroupBox();
            this.pencil = new System.Windows.Forms.Button();
            this.ruler = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clean = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.triangle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.figures = new System.Windows.Forms.GroupBox();
            this.Color.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Setting.SuspendLayout();
            this.figures.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 365);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.ForeColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(6, 21);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(35, 20);
            this.red.TabIndex = 0;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.ForeColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(6, 42);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(35, 20);
            this.green.TabIndex = 1;
            this.green.Text = "green";
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.red_Click);
            // 
            // brown
            // 
            this.brown.BackColor = System.Drawing.Color.Brown;
            this.brown.ForeColor = System.Drawing.Color.Brown;
            this.brown.Location = new System.Drawing.Point(6, 65);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(35, 20);
            this.brown.TabIndex = 2;
            this.brown.Text = "brown";
            this.brown.UseVisualStyleBackColor = false;
            this.brown.Click += new System.EventHandler(this.red_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.Orange;
            this.orange.ForeColor = System.Drawing.Color.Orange;
            this.orange.Location = new System.Drawing.Point(47, 21);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(35, 20);
            this.orange.TabIndex = 3;
            this.orange.Text = "orange";
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.red_Click);
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.ForeColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(47, 42);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(35, 20);
            this.blue.TabIndex = 4;
            this.blue.Text = "blue";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.red_Click);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.Color.Black;
            this.black.Location = new System.Drawing.Point(47, 65);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(35, 20);
            this.black.TabIndex = 5;
            this.black.Text = "black";
            this.black.UseVisualStyleBackColor = false;
            this.black.Click += new System.EventHandler(this.red_Click);
            // 
            // yellow
            // 
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.ForeColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(88, 21);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(35, 20);
            this.yellow.TabIndex = 6;
            this.yellow.Text = "yellow";
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.red_Click);
            // 
            // purple
            // 
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.ForeColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(88, 42);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(35, 20);
            this.purple.TabIndex = 7;
            this.purple.Text = "purple";
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.red_Click);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.ForeColor = System.Drawing.Color.White;
            this.white.Location = new System.Drawing.Point(88, 65);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(35, 20);
            this.white.TabIndex = 8;
            this.white.Text = "white";
            this.white.UseVisualStyleBackColor = false;
            this.white.Click += new System.EventHandler(this.red_Click);
            // 
            // Color
            // 
            this.Color.Controls.Add(this.white);
            this.Color.Controls.Add(this.purple);
            this.Color.Controls.Add(this.yellow);
            this.Color.Controls.Add(this.black);
            this.Color.Controls.Add(this.blue);
            this.Color.Controls.Add(this.orange);
            this.Color.Controls.Add(this.brown);
            this.Color.Controls.Add(this.green);
            this.Color.Controls.Add(this.red);
            this.Color.Location = new System.Drawing.Point(12, 7);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(129, 107);
            this.Color.TabIndex = 9;
            this.Color.TabStop = false;
            this.Color.Text = "Цвета";
            // 
            // pencil
            // 
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.Location = new System.Drawing.Point(6, 16);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(43, 41);
            this.pencil.TabIndex = 10;
            this.pencil.UseVisualStyleBackColor = true;
            this.pencil.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // ruler
            // 
            this.ruler.Image = ((System.Drawing.Image)(resources.GetObject("ruler.Image")));
            this.ruler.Location = new System.Drawing.Point(6, 60);
            this.ruler.Name = "ruler";
            this.ruler.Size = new System.Drawing.Size(43, 42);
            this.ruler.TabIndex = 11;
            this.ruler.UseVisualStyleBackColor = true;
            this.ruler.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // eraser
            // 
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.Location = new System.Drawing.Point(55, 16);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(43, 41);
            this.eraser.TabIndex = 12;
            this.eraser.UseVisualStyleBackColor = true;
            this.eraser.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // background
            // 
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(55, 61);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(43, 41);
            this.background.TabIndex = 13;
            this.background.UseVisualStyleBackColor = true;
            this.background.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.background);
            this.groupBox2.Controls.Add(this.eraser);
            this.groupBox2.Controls.Add(this.ruler);
            this.groupBox2.Controls.Add(this.pencil);
            this.groupBox2.Location = new System.Drawing.Point(147, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 107);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Инструменты";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(651, 125);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 22);
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
            this.Setting.Controls.Add(this.label1);
            this.Setting.Controls.Add(this.clean);
            this.Setting.Controls.Add(this.numericUpDown1);
            this.Setting.Location = new System.Drawing.Point(261, 7);
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(98, 107);
            this.Setting.TabIndex = 17;
            this.Setting.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Толщина";
            // 
            // clean
            // 
            this.clean.BackColor = System.Drawing.Color.White;
            this.clean.Location = new System.Drawing.Point(6, 60);
            this.clean.Name = "clean";
            this.clean.Size = new System.Drawing.Size(85, 42);
            this.clean.TabIndex = 17;
            this.clean.Text = "Очистить \r\nвсе\r\n";
            this.clean.UseVisualStyleBackColor = false;
            this.clean.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // circle
            // 
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.Location = new System.Drawing.Point(6, 32);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(60, 50);
            this.circle.TabIndex = 18;
            this.circle.UseVisualStyleBackColor = true;
            this.circle.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // rectangle
            // 
            this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
            this.rectangle.Location = new System.Drawing.Point(138, 32);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(60, 49);
            this.rectangle.TabIndex = 19;
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // triangle
            // 
            this.triangle.Image = ((System.Drawing.Image)(resources.GetObject("triangle.Image")));
            this.triangle.Location = new System.Drawing.Point(72, 32);
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(60, 50);
            this.triangle.TabIndex = 20;
            this.triangle.UseVisualStyleBackColor = true;
            this.triangle.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(204, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "C";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Pencil_Click);
            // 
            // figures
            // 
            this.figures.Controls.Add(this.circle);
            this.figures.Controls.Add(this.button1);
            this.figures.Controls.Add(this.triangle);
            this.figures.Controls.Add(this.rectangle);
            this.figures.Location = new System.Drawing.Point(365, 7);
            this.figures.Name = "figures";
            this.figures.Size = new System.Drawing.Size(272, 107);
            this.figures.TabIndex = 22;
            this.figures.TabStop = false;
            this.figures.Text = "Фигуры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 490);
            this.Controls.Add(this.figures);
            this.Controls.Add(this.Setting);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Color.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Setting.ResumeLayout(false);
            this.Setting.PerformLayout();
            this.figures.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button brown;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.GroupBox Color;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button ruler;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button background;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clean;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button triangle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox figures;
    }
}

