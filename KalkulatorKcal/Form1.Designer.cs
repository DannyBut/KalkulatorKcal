
namespace KalkulatorKcal
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
            this.tytul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tytul
            // 
            this.tytul.AutoSize = true;
            this.tytul.Location = new System.Drawing.Point(501, 9);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(104, 20);
            this.tytul.TabIndex = 0;
            this.tytul.Text = "KalkulatorKcal";
            this.tytul.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 278);
            this.Controls.Add(this.tytul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tytul;
    }
}

