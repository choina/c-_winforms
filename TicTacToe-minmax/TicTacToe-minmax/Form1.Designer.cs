namespace TicTacToe_minmax
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziomTrudnościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.łatwyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.średniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trudnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pole0 = new System.Windows.Forms.PictureBox();
            this.pole1 = new System.Windows.Forms.PictureBox();
            this.pole2 = new System.Windows.Forms.PictureBox();
            this.pole3 = new System.Windows.Forms.PictureBox();
            this.pole4 = new System.Windows.Forms.PictureBox();
            this.pole5 = new System.Windows.Forms.PictureBox();
            this.pole6 = new System.Windows.Forms.PictureBox();
            this.pole7 = new System.Windows.Forms.PictureBox();
            this.pole8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pole0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.pictureBox1.Image = global::TicTacToe_minmax.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 600);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetujToolStripMenuItem,
            this.poziomTrudnościToolStripMenuItem});
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // resetujToolStripMenuItem
            // 
            this.resetujToolStripMenuItem.Name = "resetujToolStripMenuItem";
            this.resetujToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.resetujToolStripMenuItem.Text = "Resetuj";
            // 
            // poziomTrudnościToolStripMenuItem
            // 
            this.poziomTrudnościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.łatwyToolStripMenuItem,
            this.średniToolStripMenuItem,
            this.trudnyToolStripMenuItem});
            this.poziomTrudnościToolStripMenuItem.Name = "poziomTrudnościToolStripMenuItem";
            this.poziomTrudnościToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.poziomTrudnościToolStripMenuItem.Text = "Poziom trudności";
            // 
            // łatwyToolStripMenuItem
            // 
            this.łatwyToolStripMenuItem.Name = "łatwyToolStripMenuItem";
            this.łatwyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.łatwyToolStripMenuItem.Text = "Łatwy";
            // 
            // średniToolStripMenuItem
            // 
            this.średniToolStripMenuItem.Name = "średniToolStripMenuItem";
            this.średniToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.średniToolStripMenuItem.Text = "Średni";
            // 
            // trudnyToolStripMenuItem
            // 
            this.trudnyToolStripMenuItem.Name = "trudnyToolStripMenuItem";
            this.trudnyToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.trudnyToolStripMenuItem.Text = "Trudny";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pole0
            // 
            this.pole0.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole0.Location = new System.Drawing.Point(37, 63);
            this.pole0.Name = "pole0";
            this.pole0.Size = new System.Drawing.Size(150, 150);
            this.pole0.TabIndex = 22;
            this.pole0.TabStop = false;
            this.pole0.Click += new System.EventHandler(this.pole0_Click);
            // 
            // pole1
            // 
            this.pole1.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole1.Location = new System.Drawing.Point(223, 63);
            this.pole1.Name = "pole1";
            this.pole1.Size = new System.Drawing.Size(150, 150);
            this.pole1.TabIndex = 23;
            this.pole1.TabStop = false;
            // 
            // pole2
            // 
            this.pole2.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole2.Location = new System.Drawing.Point(410, 63);
            this.pole2.Name = "pole2";
            this.pole2.Size = new System.Drawing.Size(150, 150);
            this.pole2.TabIndex = 24;
            this.pole2.TabStop = false;
            // 
            // pole3
            // 
            this.pole3.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole3.Location = new System.Drawing.Point(35, 252);
            this.pole3.Name = "pole3";
            this.pole3.Size = new System.Drawing.Size(150, 150);
            this.pole3.TabIndex = 25;
            this.pole3.TabStop = false;
            // 
            // pole4
            // 
            this.pole4.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole4.Location = new System.Drawing.Point(223, 252);
            this.pole4.Name = "pole4";
            this.pole4.Size = new System.Drawing.Size(150, 150);
            this.pole4.TabIndex = 26;
            this.pole4.TabStop = false;
            // 
            // pole5
            // 
            this.pole5.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole5.Location = new System.Drawing.Point(410, 252);
            this.pole5.Name = "pole5";
            this.pole5.Size = new System.Drawing.Size(150, 150);
            this.pole5.TabIndex = 27;
            this.pole5.TabStop = false;
            // 
            // pole6
            // 
            this.pole6.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole6.Location = new System.Drawing.Point(35, 442);
            this.pole6.Name = "pole6";
            this.pole6.Size = new System.Drawing.Size(150, 150);
            this.pole6.TabIndex = 28;
            this.pole6.TabStop = false;
            // 
            // pole7
            // 
            this.pole7.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole7.Location = new System.Drawing.Point(223, 442);
            this.pole7.Name = "pole7";
            this.pole7.Size = new System.Drawing.Size(150, 150);
            this.pole7.TabIndex = 29;
            this.pole7.TabStop = false;
            // 
            // pole8
            // 
            this.pole8.Image = global::TicTacToe_minmax.Properties.Resources.r;
            this.pole8.Location = new System.Drawing.Point(410, 442);
            this.pole8.Name = "pole8";
            this.pole8.Size = new System.Drawing.Size(150, 150);
            this.pole8.TabIndex = 30;
            this.pole8.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 621);
            this.Controls.Add(this.pole8);
            this.Controls.Add(this.pole7);
            this.Controls.Add(this.pole6);
            this.Controls.Add(this.pole5);
            this.Controls.Add(this.pole4);
            this.Controls.Add(this.pole3);
            this.Controls.Add(this.pole2);
            this.Controls.Add(this.pole1);
            this.Controls.Add(this.pole0);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pole0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pole8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poziomTrudnościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem łatwyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem średniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trudnyToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pole0;
        private System.Windows.Forms.PictureBox pole1;
        private System.Windows.Forms.PictureBox pole2;
        private System.Windows.Forms.PictureBox pole3;
        private System.Windows.Forms.PictureBox pole4;
        private System.Windows.Forms.PictureBox pole5;
        private System.Windows.Forms.PictureBox pole6;
        private System.Windows.Forms.PictureBox pole7;
        private System.Windows.Forms.PictureBox pole8;
    }
}

