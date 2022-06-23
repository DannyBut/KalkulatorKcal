
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mezczyzna = new System.Windows.Forms.CheckBox();
            this.kobieta = new System.Windows.Forms.CheckBox();
            this.plec = new System.Windows.Forms.Label();
            this.podaj_wiek = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.podaj_wage = new System.Windows.Forms.Label();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.podaj_wzrost = new System.Windows.Forms.Label();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.przycisk_bmi = new System.Windows.Forms.Button();
            this.bmr = new System.Windows.Forms.Button();
            this.parametry = new System.Windows.Forms.GroupBox();
            this.pal = new System.Windows.Forms.NumericUpDown();
            this.podaj_pal = new System.Windows.Forms.Label();
            this.funkcje = new System.Windows.Forms.GroupBox();
            this.opis = new System.Windows.Forms.GroupBox();
            this.wprowadzony_opis = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            this.parametry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pal)).BeginInit();
            this.funkcje.SuspendLayout();
            this.opis.SuspendLayout();
            this.SuspendLayout();
            // 
            // mezczyzna
            // 
            this.mezczyzna.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.BackColor = System.Drawing.Color.Honeydew;
            this.mezczyzna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mezczyzna.Location = new System.Drawing.Point(6, 100);
            this.mezczyzna.Name = "mezczyzna";
            this.mezczyzna.Size = new System.Drawing.Size(125, 24);
            this.mezczyzna.TabIndex = 1;
            this.mezczyzna.Text = "Mężczyzna";
            this.mezczyzna.UseVisualStyleBackColor = false;
            this.mezczyzna.CheckedChanged += new System.EventHandler(this.mezczyzna_CheckedChanged);
            // 
            // kobieta
            // 
            this.kobieta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kobieta.AutoSize = true;
            this.kobieta.BackColor = System.Drawing.Color.Honeydew;
            this.kobieta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kobieta.Location = new System.Drawing.Point(6, 130);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(94, 24);
            this.kobieta.TabIndex = 2;
            this.kobieta.Text = "Kobieta";
            this.kobieta.UseVisualStyleBackColor = false;
            this.kobieta.CheckedChanged += new System.EventHandler(this.kobieta_CheckedChanged);
            // 
            // plec
            // 
            this.plec.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.plec.AutoSize = true;
            this.plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plec.Location = new System.Drawing.Point(6, 77);
            this.plec.Name = "plec";
            this.plec.Size = new System.Drawing.Size(124, 20);
            this.plec.TabIndex = 3;
            this.plec.Text = "Wybierz płeć:";
            // 
            // podaj_wiek
            // 
            this.podaj_wiek.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.podaj_wiek.AutoSize = true;
            this.podaj_wiek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.podaj_wiek.Location = new System.Drawing.Point(179, 129);
            this.podaj_wiek.Name = "podaj_wiek";
            this.podaj_wiek.Size = new System.Drawing.Size(149, 20);
            this.podaj_wiek.TabIndex = 4;
            this.podaj_wiek.Text = "Podaj swój wiek:";
            // 
            // wiek
            // 
            this.wiek.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.wiek.Location = new System.Drawing.Point(179, 165);
            this.wiek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(91, 27);
            this.wiek.TabIndex = 5;
            this.wiek.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wiek.ValueChanged += new System.EventHandler(this.wiek_ValueChanged);
            // 
            // podaj_wage
            // 
            this.podaj_wage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.podaj_wage.AutoSize = true;
            this.podaj_wage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.podaj_wage.Location = new System.Drawing.Point(179, 33);
            this.podaj_wage.Name = "podaj_wage";
            this.podaj_wage.Size = new System.Drawing.Size(165, 20);
            this.podaj_wage.TabIndex = 6;
            this.podaj_wage.Text = "Podaj swoją wagę:";
            // 
            // waga
            // 
            this.waga.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.waga.Location = new System.Drawing.Point(179, 68);
            this.waga.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.waga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(91, 27);
            this.waga.TabIndex = 7;
            this.waga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waga.ValueChanged += new System.EventHandler(this.waga_ValueChanged);
            // 
            // podaj_wzrost
            // 
            this.podaj_wzrost.AutoSize = true;
            this.podaj_wzrost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.podaj_wzrost.Location = new System.Drawing.Point(361, 33);
            this.podaj_wzrost.Name = "podaj_wzrost";
            this.podaj_wzrost.Size = new System.Drawing.Size(168, 20);
            this.podaj_wzrost.TabIndex = 8;
            this.podaj_wzrost.Text = "Podaj swój wzrost:";
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(361, 68);
            this.wzrost.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.wzrost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(91, 27);
            this.wzrost.TabIndex = 9;
            this.wzrost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.wzrost.ValueChanged += new System.EventHandler(this.wzrost_ValueChanged);
            // 
            // przycisk_bmi
            // 
            this.przycisk_bmi.BackColor = System.Drawing.Color.Aqua;
            this.przycisk_bmi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.przycisk_bmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.przycisk_bmi.Location = new System.Drawing.Point(34, 67);
            this.przycisk_bmi.Name = "przycisk_bmi";
            this.przycisk_bmi.Size = new System.Drawing.Size(94, 29);
            this.przycisk_bmi.TabIndex = 12;
            this.przycisk_bmi.Text = "BMI";
            this.przycisk_bmi.UseVisualStyleBackColor = false;
            this.przycisk_bmi.Click += new System.EventHandler(this.przycisk_bmi_Click);
            // 
            // bmr
            // 
            this.bmr.BackColor = System.Drawing.Color.Aqua;
            this.bmr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bmr.Location = new System.Drawing.Point(34, 120);
            this.bmr.Name = "bmr";
            this.bmr.Size = new System.Drawing.Size(94, 29);
            this.bmr.TabIndex = 15;
            this.bmr.Text = "BMR";
            this.bmr.UseVisualStyleBackColor = false;
            this.bmr.Click += new System.EventHandler(this.bmr_Click);
            // 
            // parametry
            // 
            this.parametry.Controls.Add(this.pal);
            this.parametry.Controls.Add(this.podaj_pal);
            this.parametry.Controls.Add(this.plec);
            this.parametry.Controls.Add(this.mezczyzna);
            this.parametry.Controls.Add(this.kobieta);
            this.parametry.Controls.Add(this.podaj_wage);
            this.parametry.Controls.Add(this.waga);
            this.parametry.Controls.Add(this.podaj_wzrost);
            this.parametry.Controls.Add(this.wiek);
            this.parametry.Controls.Add(this.wzrost);
            this.parametry.Controls.Add(this.podaj_wiek);
            this.parametry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parametry.Location = new System.Drawing.Point(29, 410);
            this.parametry.Name = "parametry";
            this.parametry.Size = new System.Drawing.Size(591, 219);
            this.parametry.TabIndex = 17;
            this.parametry.TabStop = false;
            this.parametry.Text = "Parametry";
            // 
            // pal
            // 
            this.pal.Location = new System.Drawing.Point(363, 165);
            this.pal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.pal.Name = "pal";
            this.pal.Size = new System.Drawing.Size(91, 27);
            this.pal.TabIndex = 13;
            this.pal.ValueChanged += new System.EventHandler(this.pal_ValueChanged);
            // 
            // podaj_pal
            // 
            this.podaj_pal.AutoSize = true;
            this.podaj_pal.Location = new System.Drawing.Point(361, 130);
            this.podaj_pal.Name = "podaj_pal";
            this.podaj_pal.Size = new System.Drawing.Size(103, 20);
            this.podaj_pal.TabIndex = 12;
            this.podaj_pal.Text = "Podal PAL:";
            // 
            // funkcje
            // 
            this.funkcje.Controls.Add(this.przycisk_bmi);
            this.funkcje.Controls.Add(this.bmr);
            this.funkcje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.funkcje.Location = new System.Drawing.Point(626, 411);
            this.funkcje.Name = "funkcje";
            this.funkcje.Size = new System.Drawing.Size(164, 218);
            this.funkcje.TabIndex = 18;
            this.funkcje.TabStop = false;
            this.funkcje.Text = "Funkcje";
            // 
            // opis
            // 
            this.opis.Controls.Add(this.wprowadzony_opis);
            this.opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.opis.Location = new System.Drawing.Point(29, 28);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(761, 354);
            this.opis.TabIndex = 19;
            this.opis.TabStop = false;
            this.opis.Text = "Opis";
            // 
            // wprowadzony_opis
            // 
            this.wprowadzony_opis.BackColor = System.Drawing.Color.Honeydew;
            this.wprowadzony_opis.Location = new System.Drawing.Point(49, 54);
            this.wprowadzony_opis.Name = "wprowadzony_opis";
            this.wprowadzony_opis.ReadOnly = true;
            this.wprowadzony_opis.Size = new System.Drawing.Size(676, 272);
            this.wprowadzony_opis.TabIndex = 0;
            this.wprowadzony_opis.Text = resources.GetString("wprowadzony_opis.Text");
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(818, 671);
            this.Controls.Add(this.opis);
            this.Controls.Add(this.funkcje);
            this.Controls.Add(this.parametry);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "KalkulatorKcal";
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            this.parametry.ResumeLayout(false);
            this.parametry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pal)).EndInit();
            this.funkcje.ResumeLayout(false);
            this.opis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox mezczyzna;
        private System.Windows.Forms.CheckBox kobieta;
        private System.Windows.Forms.Label plec;
        private System.Windows.Forms.Label podaj_wiek;
        public System.Windows.Forms.NumericUpDown wiek;
        private System.Windows.Forms.Label podaj_wage;
        private System.Windows.Forms.NumericUpDown waga;
        private System.Windows.Forms.Label podaj_wzrost;
        private System.Windows.Forms.NumericUpDown wzrost;
        private System.Windows.Forms.Label podaj_kcal;
        private System.Windows.Forms.Button przycisk_bmi;
        private System.Windows.Forms.Button bmr;
        private System.Windows.Forms.GroupBox parametry;
        private System.Windows.Forms.GroupBox funkcje;
        private System.Windows.Forms.NumericUpDown pal;
        private System.Windows.Forms.Label podaj_pal;
        private System.Windows.Forms.GroupBox opis;
        private System.Windows.Forms.RichTextBox wprowadzony_opis;
    }
}

