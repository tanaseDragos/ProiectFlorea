namespace ProiectFloreaLicenta
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.latenta = new System.Windows.Forms.NumericUpDown();
            this.nrSetRegistrii = new System.Windows.Forms.ComboBox();
            this.nPen = new System.Windows.Forms.ComboBox();
            this.instructionBufferSize = new System.Windows.Forms.ComboBox();
            this.irMax = new System.Windows.Forms.ComboBox();
            this.fetchRate = new System.Windows.Forms.ComboBox();
            this.alegeFisier = new System.Windows.Forms.Button();
            this.pathFisier = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sizeDC = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.blockSizeDC = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sizeIC = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.blockSize = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fetch Rate (FR):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Rate Maxim (IRmax):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instruction Buffer Size (IBS):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Latenta (for hit in cache):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "N_PEN (miss in cache):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nr. Set Registri:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.latenta);
            this.groupBox1.Controls.Add(this.nrSetRegistrii);
            this.groupBox1.Controls.Add(this.nPen);
            this.groupBox1.Controls.Add(this.instructionBufferSize);
            this.groupBox1.Controls.Add(this.irMax);
            this.groupBox1.Controls.Add(this.fetchRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametrii Simulator";
            // 
            // latenta
            // 
            this.latenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latenta.Location = new System.Drawing.Point(201, 119);
            this.latenta.Name = "latenta";
            this.latenta.Size = new System.Drawing.Size(60, 22);
            this.latenta.TabIndex = 8;
            this.latenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nrSetRegistrii
            // 
            this.nrSetRegistrii.BackColor = System.Drawing.Color.LightGray;
            this.nrSetRegistrii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nrSetRegistrii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nrSetRegistrii.FormattingEnabled = true;
            this.nrSetRegistrii.Location = new System.Drawing.Point(201, 187);
            this.nrSetRegistrii.Name = "nrSetRegistrii";
            this.nrSetRegistrii.Size = new System.Drawing.Size(60, 24);
            this.nrSetRegistrii.TabIndex = 12;
            // 
            // nPen
            // 
            this.nPen.BackColor = System.Drawing.Color.LightGray;
            this.nPen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPen.FormattingEnabled = true;
            this.nPen.Location = new System.Drawing.Point(201, 153);
            this.nPen.Name = "nPen";
            this.nPen.Size = new System.Drawing.Size(60, 24);
            this.nPen.TabIndex = 11;
            this.nPen.SelectedIndexChanged += new System.EventHandler(this.nPen_SelectedIndexChanged);
            // 
            // instructionBufferSize
            // 
            this.instructionBufferSize.BackColor = System.Drawing.Color.LightGray;
            this.instructionBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructionBufferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionBufferSize.FormattingEnabled = true;
            this.instructionBufferSize.Location = new System.Drawing.Point(201, 83);
            this.instructionBufferSize.Name = "instructionBufferSize";
            this.instructionBufferSize.Size = new System.Drawing.Size(60, 24);
            this.instructionBufferSize.TabIndex = 9;
            this.instructionBufferSize.SelectedIndexChanged += new System.EventHandler(this.instructionBufferSize_SelectedIndexChanged);
            // 
            // irMax
            // 
            this.irMax.BackColor = System.Drawing.Color.LightGray;
            this.irMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.irMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irMax.FormattingEnabled = true;
            this.irMax.Location = new System.Drawing.Point(201, 49);
            this.irMax.Name = "irMax";
            this.irMax.Size = new System.Drawing.Size(60, 24);
            this.irMax.TabIndex = 8;
            this.irMax.SelectedIndexChanged += new System.EventHandler(this.irMax_SelectedIndexChanged);
            // 
            // fetchRate
            // 
            this.fetchRate.BackColor = System.Drawing.Color.LightGray;
            this.fetchRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fetchRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchRate.FormattingEnabled = true;
            this.fetchRate.Location = new System.Drawing.Point(201, 17);
            this.fetchRate.Name = "fetchRate";
            this.fetchRate.Size = new System.Drawing.Size(60, 24);
            this.fetchRate.TabIndex = 7;
            this.fetchRate.SelectedIndexChanged += new System.EventHandler(this.fetchRate_SelectedIndexChanged);
            this.fetchRate.TextUpdate += new System.EventHandler(this.fetchRate_SelectedIndexChanged);
            // 
            // alegeFisier
            // 
            this.alegeFisier.Location = new System.Drawing.Point(12, 260);
            this.alegeFisier.Name = "alegeFisier";
            this.alegeFisier.Size = new System.Drawing.Size(75, 23);
            this.alegeFisier.TabIndex = 8;
            this.alegeFisier.Text = "Alege fisier";
            this.alegeFisier.UseVisualStyleBackColor = true;
            this.alegeFisier.Click += new System.EventHandler(this.alegeFisier_Click);
            // 
            // pathFisier
            // 
            this.pathFisier.Location = new System.Drawing.Point(13, 289);
            this.pathFisier.Name = "pathFisier";
            this.pathFisier.Size = new System.Drawing.Size(172, 20);
            this.pathFisier.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "Start Simulare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(254, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 162);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructiuni";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Branch:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Load:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 26);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 26);
            this.textBox1.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(498, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 162);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezultate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ticks:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Issue Rate:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "One-Cycle:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 87);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 26);
            this.textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(128, 55);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(66, 26);
            this.textBox7.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(128, 25);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 26);
            this.textBox8.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(317, 27);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 217);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametrii Cache (Mapare Directa)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(178, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "= FR";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 187);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 24);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Biport";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 159);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Uniport";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sizeDC);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.blockSizeDC);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(231, 34);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(148, 108);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Cache";
            // 
            // sizeDC
            // 
            this.sizeDC.BackColor = System.Drawing.Color.LightGray;
            this.sizeDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeDC.FormattingEnabled = true;
            this.sizeDC.Location = new System.Drawing.Point(78, 62);
            this.sizeDC.Name = "sizeDC";
            this.sizeDC.Size = new System.Drawing.Size(60, 24);
            this.sizeDC.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 16);
            this.label18.TabIndex = 15;
            this.label18.Text = "Size_DC:";
            // 
            // blockSizeDC
            // 
            this.blockSizeDC.BackColor = System.Drawing.Color.LightGray;
            this.blockSizeDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockSizeDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockSizeDC.FormattingEnabled = true;
            this.blockSizeDC.Location = new System.Drawing.Point(78, 26);
            this.blockSizeDC.Name = "blockSizeDC";
            this.blockSizeDC.Size = new System.Drawing.Size(60, 24);
            this.blockSizeDC.TabIndex = 15;
            this.blockSizeDC.SelectedIndexChanged += new System.EventHandler(this.blockSizeDC_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Block Size:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sizeIC);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.blockSize);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(26, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(199, 108);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Instruction Cache";
            // 
            // sizeIC
            // 
            this.sizeIC.BackColor = System.Drawing.Color.LightGray;
            this.sizeIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeIC.FormattingEnabled = true;
            this.sizeIC.Location = new System.Drawing.Point(86, 68);
            this.sizeIC.Name = "sizeIC";
            this.sizeIC.Size = new System.Drawing.Size(60, 24);
            this.sizeIC.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Size_IC:";
            // 
            // blockSize
            // 
            this.blockSize.BackColor = System.Drawing.Color.LightGray;
            this.blockSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockSize.Enabled = false;
            this.blockSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockSize.FormattingEnabled = true;
            this.blockSize.Location = new System.Drawing.Point(86, 31);
            this.blockSize.Name = "blockSize";
            this.blockSize.Size = new System.Drawing.Size(60, 24);
            this.blockSize.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Block Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathFisier);
            this.Controls.Add(this.alegeFisier);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Simulator Cache";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fetchRate;
        private System.Windows.Forms.ComboBox irMax;
        private System.Windows.Forms.ComboBox instructionBufferSize;
        private System.Windows.Forms.ComboBox nPen;
        private System.Windows.Forms.ComboBox nrSetRegistrii;
        private System.Windows.Forms.NumericUpDown latenta;
        private System.Windows.Forms.Button alegeFisier;
        private System.Windows.Forms.TextBox pathFisier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox blockSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sizeIC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox blockSizeDC;
        private System.Windows.Forms.ComboBox sizeDC;
        private System.Windows.Forms.Label label18;
    }
}

