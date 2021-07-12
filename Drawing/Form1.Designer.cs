namespace Drawing
{
    partial class Drawing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Drawing));
            this.lb_grey = new System.Windows.Forms.Label();
            this.lb_black = new System.Windows.Forms.Label();
            this.lb_red = new System.Windows.Forms.Label();
            this.lb_blue = new System.Windows.Forms.Label();
            this.lb_green = new System.Windows.Forms.Label();
            this.lb_yellow = new System.Windows.Forms.Label();
            this.lb_brown = new System.Windows.Forms.Label();
            this.lb_white = new System.Windows.Forms.Label();
            this.lbbrown = new System.Windows.Forms.Label();
            this.lb_purple = new System.Windows.Forms.Label();
            this.pencil = new System.Windows.Forms.PictureBox();
            this.pencilSize = new System.Windows.Forms.NumericUpDown();
            this.rubber = new System.Windows.Forms.PictureBox();
            this.rectangleBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pencil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_grey
            // 
            this.lb_grey.BackColor = System.Drawing.Color.Gray;
            this.lb_grey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_grey.Location = new System.Drawing.Point(68, 16);
            this.lb_grey.Name = "lb_grey";
            this.lb_grey.Size = new System.Drawing.Size(40, 23);
            this.lb_grey.TabIndex = 2;
            this.lb_grey.Text = "Grey";
            this.lb_grey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_grey.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_black
            // 
            this.lb_black.BackColor = System.Drawing.Color.Black;
            this.lb_black.ForeColor = System.Drawing.Color.White;
            this.lb_black.Location = new System.Drawing.Point(131, 16);
            this.lb_black.Name = "lb_black";
            this.lb_black.Size = new System.Drawing.Size(44, 23);
            this.lb_black.TabIndex = 3;
            this.lb_black.Text = "Black";
            this.lb_black.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_black.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_red
            // 
            this.lb_red.BackColor = System.Drawing.Color.Red;
            this.lb_red.Location = new System.Drawing.Point(196, 16);
            this.lb_red.Name = "lb_red";
            this.lb_red.Size = new System.Drawing.Size(42, 23);
            this.lb_red.TabIndex = 4;
            this.lb_red.Text = "Red";
            this.lb_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_red.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_blue
            // 
            this.lb_blue.BackColor = System.Drawing.Color.Blue;
            this.lb_blue.Location = new System.Drawing.Point(259, 16);
            this.lb_blue.Margin = new System.Windows.Forms.Padding(0);
            this.lb_blue.Name = "lb_blue";
            this.lb_blue.Size = new System.Drawing.Size(41, 23);
            this.lb_blue.TabIndex = 5;
            this.lb_blue.Text = "Blue";
            this.lb_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_blue.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_green
            // 
            this.lb_green.BackColor = System.Drawing.Color.Green;
            this.lb_green.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_green.Location = new System.Drawing.Point(323, 16);
            this.lb_green.Name = "lb_green";
            this.lb_green.Size = new System.Drawing.Size(44, 23);
            this.lb_green.TabIndex = 6;
            this.lb_green.Text = "Green";
            this.lb_green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_green.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_yellow
            // 
            this.lb_yellow.BackColor = System.Drawing.Color.Yellow;
            this.lb_yellow.Location = new System.Drawing.Point(386, 16);
            this.lb_yellow.Name = "lb_yellow";
            this.lb_yellow.Size = new System.Drawing.Size(40, 23);
            this.lb_yellow.TabIndex = 7;
            this.lb_yellow.Text = "Yellow";
            this.lb_yellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_yellow.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_brown
            // 
            this.lb_brown.BackColor = System.Drawing.Color.Orange;
            this.lb_brown.Location = new System.Drawing.Point(443, 16);
            this.lb_brown.Name = "lb_brown";
            this.lb_brown.Size = new System.Drawing.Size(44, 23);
            this.lb_brown.TabIndex = 8;
            this.lb_brown.Text = "Orange";
            this.lb_brown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_brown.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_white
            // 
            this.lb_white.BackColor = System.Drawing.Color.White;
            this.lb_white.Location = new System.Drawing.Point(6, 16);
            this.lb_white.Name = "lb_white";
            this.lb_white.Size = new System.Drawing.Size(39, 23);
            this.lb_white.TabIndex = 10;
            this.lb_white.Text = "White";
            this.lb_white.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_white.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbbrown
            // 
            this.lbbrown.BackColor = System.Drawing.Color.Brown;
            this.lbbrown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbbrown.Location = new System.Drawing.Point(508, 16);
            this.lbbrown.Name = "lbbrown";
            this.lbbrown.Size = new System.Drawing.Size(46, 23);
            this.lbbrown.TabIndex = 11;
            this.lbbrown.Text = "Brown";
            this.lbbrown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbbrown.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_purple
            // 
            this.lb_purple.BackColor = System.Drawing.Color.Violet;
            this.lb_purple.Location = new System.Drawing.Point(569, 16);
            this.lb_purple.Name = "lb_purple";
            this.lb_purple.Size = new System.Drawing.Size(54, 23);
            this.lb_purple.TabIndex = 12;
            this.lb_purple.Text = "Violet";
            this.lb_purple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_purple.Click += new System.EventHandler(this.label1_Click);
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.SystemColors.Control;
            this.pencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.Location = new System.Drawing.Point(4, 150);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(45, 33);
            this.pencil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pencil.TabIndex = 0;
            this.pencil.TabStop = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // pencilSize
            // 
            this.pencilSize.Location = new System.Drawing.Point(4, 189);
            this.pencilSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.pencilSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pencilSize.Name = "pencilSize";
            this.pencilSize.Size = new System.Drawing.Size(45, 20);
            this.pencilSize.TabIndex = 13;
            this.pencilSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pencilSize.Visible = false;
            this.pencilSize.ValueChanged += new System.EventHandler(this.pencilSize_ValueChanged);
            // 
            // rubber
            // 
            this.rubber.BackColor = System.Drawing.SystemColors.Control;
            this.rubber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rubber.Image = ((System.Drawing.Image)(resources.GetObject("rubber.Image")));
            this.rubber.Location = new System.Drawing.Point(4, 72);
            this.rubber.Name = "rubber";
            this.rubber.Size = new System.Drawing.Size(45, 33);
            this.rubber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rubber.TabIndex = 14;
            this.rubber.TabStop = false;
            this.rubber.Click += new System.EventHandler(this.rubber_Click);
            // 
            // rectangleBox2
            // 
            this.rectangleBox2.BackColor = System.Drawing.SystemColors.Control;
            this.rectangleBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectangleBox2.Image = ((System.Drawing.Image)(resources.GetObject("rectangleBox2.Image")));
            this.rectangleBox2.Location = new System.Drawing.Point(4, 111);
            this.rectangleBox2.Name = "rectangleBox2";
            this.rectangleBox2.Size = new System.Drawing.Size(45, 33);
            this.rectangleBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectangleBox2.TabIndex = 15;
            this.rectangleBox2.TabStop = false;
            this.rectangleBox2.Click += new System.EventHandler(this.rectangleBox2_Click);
            this.rectangleBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.rectangleBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.rubber);
            this.groupBox1.Controls.Add(this.pencilSize);
            this.groupBox1.Controls.Add(this.rectangleBox2);
            this.groupBox1.Controls.Add(this.pencil);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(55, 423);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.lb_white);
            this.groupBox2.Controls.Add(this.lb_grey);
            this.groupBox2.Controls.Add(this.lb_purple);
            this.groupBox2.Controls.Add(this.lb_black);
            this.groupBox2.Controls.Add(this.lbbrown);
            this.groupBox2.Controls.Add(this.lb_red);
            this.groupBox2.Controls.Add(this.lb_brown);
            this.groupBox2.Controls.Add(this.lb_blue);
            this.groupBox2.Controls.Add(this.lb_yellow);
            this.groupBox2.Controls.Add(this.lb_green);
            this.groupBox2.Location = new System.Drawing.Point(67, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 58);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colors";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 378);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(828, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Drawing";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.pencil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pencilSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rectangleBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_grey;
        private System.Windows.Forms.Label lb_black;
        private System.Windows.Forms.Label lb_red;
        private System.Windows.Forms.Label lb_blue;
        private System.Windows.Forms.Label lb_green;
        private System.Windows.Forms.Label lb_yellow;
        private System.Windows.Forms.Label lb_brown;
        private System.Windows.Forms.Label lb_white;
        private System.Windows.Forms.Label lbbrown;
        private System.Windows.Forms.Label lb_purple;
        private System.Windows.Forms.PictureBox pencil;
        private System.Windows.Forms.NumericUpDown pencilSize;
        private System.Windows.Forms.PictureBox rubber;
        private System.Windows.Forms.PictureBox rectangleBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

