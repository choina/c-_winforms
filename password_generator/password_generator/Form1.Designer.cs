namespace password_generator
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
            this.length = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.alpha = new MetroFramework.Controls.MetroTextBox();
            this.output = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // length
            // 
            // 
            // 
            // 
            this.length.CustomButton.Image = null;
            this.length.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.length.CustomButton.Name = "";
            this.length.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.length.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.length.CustomButton.TabIndex = 1;
            this.length.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.length.CustomButton.UseSelectable = true;
            this.length.CustomButton.Visible = false;
            this.length.Lines = new string[0];
            this.length.Location = new System.Drawing.Point(364, 85);
            this.length.MaxLength = 32767;
            this.length.Name = "length";
            this.length.PasswordChar = '\0';
            this.length.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.length.SelectedText = "";
            this.length.SelectionLength = 0;
            this.length.SelectionStart = 0;
            this.length.ShortcutsEnabled = true;
            this.length.Size = new System.Drawing.Size(100, 23);
            this.length.TabIndex = 0;
            this.length.UseSelectable = true;
            this.length.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.length.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox1_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(261, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Number of non alphanumeric characters";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 157);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Length:";
            // 
            // alpha
            // 
            // 
            // 
            // 
            this.alpha.CustomButton.Image = null;
            this.alpha.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.alpha.CustomButton.Name = "";
            this.alpha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.alpha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.alpha.CustomButton.TabIndex = 1;
            this.alpha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.alpha.CustomButton.UseSelectable = true;
            this.alpha.CustomButton.Visible = false;
            this.alpha.Lines = new string[0];
            this.alpha.Location = new System.Drawing.Point(325, 154);
            this.alpha.MaxLength = 32767;
            this.alpha.Name = "alpha";
            this.alpha.PasswordChar = '\0';
            this.alpha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.alpha.SelectedText = "";
            this.alpha.SelectionLength = 0;
            this.alpha.SelectionStart = 0;
            this.alpha.ShortcutsEnabled = true;
            this.alpha.Size = new System.Drawing.Size(100, 23);
            this.alpha.TabIndex = 3;
            this.alpha.UseSelectable = true;
            this.alpha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.alpha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.alpha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextBox2_KeyPress);
            // 
            // output
            // 
            // 
            // 
            // 
            this.output.CustomButton.Image = null;
            this.output.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.output.CustomButton.Name = "";
            this.output.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.output.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.output.CustomButton.TabIndex = 1;
            this.output.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.output.CustomButton.UseSelectable = true;
            this.output.CustomButton.Visible = false;
            this.output.Lines = new string[0];
            this.output.Location = new System.Drawing.Point(83, 285);
            this.output.MaxLength = 32767;
            this.output.Name = "output";
            this.output.PasswordChar = '\0';
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.output.SelectedText = "";
            this.output.SelectionLength = 0;
            this.output.SelectionStart = 0;
            this.output.ShortcutsEnabled = true;
            this.output.Size = new System.Drawing.Size(200, 23);
            this.output.TabIndex = 4;
            this.output.UseSelectable = true;
            this.output.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.output.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(94, 215);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(213, 39);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Generate";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.length);
            this.Name = "Form1";
            this.Text = "Password generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox length;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox alpha;
        private MetroFramework.Controls.MetroTextBox output;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

