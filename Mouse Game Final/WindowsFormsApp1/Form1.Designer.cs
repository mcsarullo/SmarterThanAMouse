using System.Windows.Forms;

namespace WindowsFormsApp1
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
        

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.intro = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.win = new System.Windows.Forms.Label();
            this.lose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.intro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(630, 493);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(842, 488);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click Here";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(630, 493);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(842, 488);
            this.button2.TabIndex = 4;
            this.button2.Text = "Start Game";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(876, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 89);
            this.label5.TabIndex = 6;
            this.label5.Text = "Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(425, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 67);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // intro
            // 
            this.intro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.intro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("intro.BackgroundImage")));
            this.intro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.intro.Image = ((System.Drawing.Image)(resources.GetObject("intro.Image")));
            this.intro.InitialImage = ((System.Drawing.Image)(resources.GetObject("intro.InitialImage")));
            this.intro.Location = new System.Drawing.Point(250, 0);
            this.intro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(1064, 457);
            this.intro.TabIndex = 15;
            this.intro.TabStop = false;
            this.intro.Click += new System.EventHandler(this.intro_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.win.Location = new System.Drawing.Point(596, 180);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(843, 67);
            this.win.TabIndex = 16;
            this.win.Text = "You Are Smarter than a Mouse";
            this.win.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lose.Location = new System.Drawing.Point(594, 180);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(746, 67);
            this.lose.TabIndex = 17;
            this.lose.Text = "The Mouse Won this Time!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1320, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(581, 660);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(1320, 343);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 672);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1158);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.win);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "aaa";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.intro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox intro;
        private ImageList imageList1;
        private Label win;
        private Label lose;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}