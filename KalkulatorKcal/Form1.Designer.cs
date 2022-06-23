
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
            this.mezczyzna = new System.Windows.Forms.CheckBox();
            this.kobieta = new System.Windows.Forms.CheckBox();
            this.plec = new System.Windows.Forms.Label();
            this.podaj_wiek = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.NumericUpDown();
            this.podaj_wage = new System.Windows.Forms.Label();
            this.waga = new System.Windows.Forms.NumericUpDown();
            this.podaj_wzrost = new System.Windows.Forms.Label();
            this.wzrost = new System.Windows.Forms.NumericUpDown();
            this.podaj_kcal = new System.Windows.Forms.Label();
            this.kcal = new System.Windows.Forms.NumericUpDown();
            this.przycisk_bmi = new System.Windows.Forms.Button();
            this.brm = new System.Windows.Forms.Button();
            this.przytyc = new System.Windows.Forms.Button();
            this.parametry = new System.Windows.Forms.GroupBox();
            this.funkcje = new System.Windows.Forms.GroupBox();
            this.podaj_pal = new System.Windows.Forms.Label();
            this.pal = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcal)).BeginInit();
            this.parametry.SuspendLayout();
            this.funkcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pal)).BeginInit();
            this.SuspendLayout();
            // 
            // mezczyzna
            // 
            this.mezczyzna.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.BackColor = System.Drawing.Color.Honeydew;
            this.mezczyzna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mezczyzna.Location = new System.Drawing.Point(6, 56);
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
            this.kobieta.Location = new System.Drawing.Point(6, 86);
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
            this.plec.Location = new System.Drawing.Point(6, 33);
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
            // podaj_kcal
            // 
            this.podaj_kcal.AutoSize = true;
            this.podaj_kcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.podaj_kcal.Location = new System.Drawing.Point(361, 129);
            this.podaj_kcal.Name = "podaj_kcal";
            this.podaj_kcal.Size = new System.Drawing.Size(218, 20);
            this.podaj_kcal.TabIndex = 10;
            this.podaj_kcal.Text = "Dzienne spożycie (kcal):";
            // 
            // kcal
            // 
            this.kcal.Location = new System.Drawing.Point(361, 165);
            this.kcal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.kcal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kcal.Name = "kcal";
            this.kcal.Size = new System.Drawing.Size(91, 27);
            this.kcal.TabIndex = 11;
            this.kcal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kcal.ValueChanged += new System.EventHandler(this.kcal_ValueChanged);
            // 
            // przycisk_bmi
            // 
            this.przycisk_bmi.BackColor = System.Drawing.Color.Aqua;
            this.przycisk_bmi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.przycisk_bmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.przycisk_bmi.Location = new System.Drawing.Point(97, 52);
            this.przycisk_bmi.Name = "przycisk_bmi";
            this.przycisk_bmi.Size = new System.Drawing.Size(94, 29);
            this.przycisk_bmi.TabIndex = 12;
            this.przycisk_bmi.Text = "BMI";
            this.przycisk_bmi.UseVisualStyleBackColor = false;
            this.przycisk_bmi.Click += new System.EventHandler(this.przycisk_bmi_Click);
            // 
            // brm
            // 
            this.brm.BackColor = System.Drawing.Color.Aqua;
            this.brm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brm.Location = new System.Drawing.Point(97, 105);
            this.brm.Name = "brm";
            this.brm.Size = new System.Drawing.Size(94, 29);
            this.brm.TabIndex = 15;
            this.brm.Text = "BRM";
            this.brm.UseVisualStyleBackColor = false;
            this.brm.Click += new System.EventHandler(this.brm_Click);
            // 
            // przytyc
            // 
            this.przytyc.BackColor = System.Drawing.Color.Aqua;
            this.przytyc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.przytyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.przytyc.Location = new System.Drawing.Point(97, 161);
            this.przytyc.Name = "przytyc";
            this.przytyc.Size = new System.Drawing.Size(94, 29);
            this.przytyc.TabIndex = 16;
            this.przytyc.Text = "WZROST";
            this.przytyc.UseVisualStyleBackColor = false;
            this.przytyc.Click += new System.EventHandler(this.przytyc_Click);
            // 
            // parametry
            // 
            this.parametry.Controls.Add(this.pal);
            this.parametry.Controls.Add(this.podaj_pal);
            this.parametry.Controls.Add(this.plec);
            this.parametry.Controls.Add(this.mezczyzna);
            this.parametry.Controls.Add(this.kobieta);
            this.parametry.Controls.Add(this.podaj_wage);
            this.parametry.Controls.Add(this.kcal);
            this.parametry.Controls.Add(this.waga);
            this.parametry.Controls.Add(this.podaj_kcal);
            this.parametry.Controls.Add(this.podaj_wzrost);
            this.parametry.Controls.Add(this.wiek);
            this.parametry.Controls.Add(this.wzrost);
            this.parametry.Controls.Add(this.podaj_wiek);
            this.parametry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.parametry.Location = new System.Drawing.Point(24, 12);
            this.parametry.Name = "parametry";
            this.parametry.Size = new System.Drawing.Size(591, 233);
            this.parametry.TabIndex = 17;
            this.parametry.TabStop = false;
            this.parametry.Text = "Parametry";
            // 
            // funkcje
            // 
            this.funkcje.Controls.Add(this.przycisk_bmi);
            this.funkcje.Controls.Add(this.brm);
            this.funkcje.Controls.Add(this.przytyc);
            this.funkcje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.funkcje.Location = new System.Drawing.Point(687, 13);
            this.funkcje.Name = "funkcje";
            this.funkcje.Size = new System.Drawing.Size(276, 232);
            this.funkcje.TabIndex = 18;
            this.funkcje.TabStop = false;
            this.funkcje.Text = "Funkcje";
            // 
            // podaj_pal
            // 
            this.podaj_pal.AutoSize = true;
            this.podaj_pal.Location = new System.Drawing.Point(7, 129);
            this.podaj_pal.Name = "podaj_pal";
            this.podaj_pal.Size = new System.Drawing.Size(103, 20);
            this.podaj_pal.TabIndex = 12;
            this.podaj_pal.Text = "Podal PAL:";
            // 
            // pal
            // 
            this.pal.Location = new System.Drawing.Point(9, 164);
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(988, 268);
            this.Controls.Add(this.funkcje);
            this.Controls.Add(this.parametry);
            this.Name = "Form1";
            this.Text = "KalkulatorKcal";
            ((System.ComponentModel.ISupportInitialize)(this.wiek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wzrost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kcal)).EndInit();
            this.parametry.ResumeLayout(false);
            this.parametry.PerformLayout();
            this.funkcje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pal)).EndInit();
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
        private System.Windows.Forms.NumericUpDown kcal;
        private System.Windows.Forms.Button przycisk_bmi;
        private System.Windows.Forms.Button brm;
        private System.Windows.Forms.Button przytyc;
        private System.Windows.Forms.GroupBox parametry;
        private System.Windows.Forms.GroupBox funkcje;
        private System.Windows.Forms.NumericUpDown pal;
        private System.Windows.Forms.Label podaj_pal;
    }
}

