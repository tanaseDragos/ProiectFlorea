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
            this.startSimulare = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.branchTextBox = new System.Windows.Forms.TextBox();
            this.storeTextBox = new System.Windows.Forms.TextBox();
            this.loadTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ticksTextBox = new System.Windows.Forms.TextBox();
            this.issueRateTextBox = new System.Windows.Forms.TextBox();
            this.oneCycleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.biport = new System.Windows.Forms.RadioButton();
            this.uniport = new System.Windows.Forms.RadioButton();
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
            this.traceFilesListBox = new System.Windows.Forms.ListBox();
            this.parsareFisier = new System.Windows.Forms.Button();
            this.influentaIR = new System.Windows.Forms.Label();
            this.influentaIrTextBox = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fetch Rate (FR):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Rate Maxim (IRmax):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instruction Buffer Size (IBS):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Latenta (for hit in cache):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "N_PEN (miss in cache):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 300);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(416, 357);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametrii Simulator";
            // 
            // latenta
            // 
            this.latenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latenta.Location = new System.Drawing.Point(302, 183);
            this.latenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.latenta.Name = "latenta";
            this.latenta.Size = new System.Drawing.Size(90, 30);
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
            this.nrSetRegistrii.Location = new System.Drawing.Point(302, 288);
            this.nrSetRegistrii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrSetRegistrii.Name = "nrSetRegistrii";
            this.nrSetRegistrii.Size = new System.Drawing.Size(88, 33);
            this.nrSetRegistrii.TabIndex = 12;
            // 
            // nPen
            // 
            this.nPen.BackColor = System.Drawing.Color.LightGray;
            this.nPen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPen.FormattingEnabled = true;
            this.nPen.Location = new System.Drawing.Point(302, 235);
            this.nPen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nPen.Name = "nPen";
            this.nPen.Size = new System.Drawing.Size(88, 33);
            this.nPen.TabIndex = 11;
            this.nPen.SelectedIndexChanged += new System.EventHandler(this.nPen_SelectedIndexChanged);
            // 
            // instructionBufferSize
            // 
            this.instructionBufferSize.BackColor = System.Drawing.Color.LightGray;
            this.instructionBufferSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.instructionBufferSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionBufferSize.FormattingEnabled = true;
            this.instructionBufferSize.Location = new System.Drawing.Point(302, 128);
            this.instructionBufferSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instructionBufferSize.Name = "instructionBufferSize";
            this.instructionBufferSize.Size = new System.Drawing.Size(88, 33);
            this.instructionBufferSize.TabIndex = 9;
            this.instructionBufferSize.SelectedIndexChanged += new System.EventHandler(this.instructionBufferSize_SelectedIndexChanged);
            // 
            // irMax
            // 
            this.irMax.BackColor = System.Drawing.Color.LightGray;
            this.irMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.irMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irMax.FormattingEnabled = true;
            this.irMax.Location = new System.Drawing.Point(302, 75);
            this.irMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.irMax.Name = "irMax";
            this.irMax.Size = new System.Drawing.Size(88, 33);
            this.irMax.TabIndex = 8;
            this.irMax.SelectedIndexChanged += new System.EventHandler(this.irMax_SelectedIndexChanged);
            // 
            // fetchRate
            // 
            this.fetchRate.BackColor = System.Drawing.Color.LightGray;
            this.fetchRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fetchRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchRate.FormattingEnabled = true;
            this.fetchRate.Location = new System.Drawing.Point(302, 26);
            this.fetchRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fetchRate.Name = "fetchRate";
            this.fetchRate.Size = new System.Drawing.Size(88, 33);
            this.fetchRate.TabIndex = 7;
            this.fetchRate.SelectedIndexChanged += new System.EventHandler(this.fetchRate_SelectedIndexChanged);
            this.fetchRate.TextUpdate += new System.EventHandler(this.fetchRate_SelectedIndexChanged);
            // 
            // startSimulare
            // 
            this.startSimulare.Location = new System.Drawing.Point(18, 385);
            this.startSimulare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startSimulare.Name = "startSimulare";
            this.startSimulare.Size = new System.Drawing.Size(112, 80);
            this.startSimulare.TabIndex = 10;
            this.startSimulare.Text = "Start Simulare";
            this.startSimulare.UseVisualStyleBackColor = true;
            this.startSimulare.Click += new System.EventHandler(this.startSimulare_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(18, 480);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 54);
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
            this.groupBox2.Controls.Add(this.totalTextBox);
            this.groupBox2.Controls.Add(this.branchTextBox);
            this.groupBox2.Controls.Add(this.storeTextBox);
            this.groupBox2.Controls.Add(this.loadTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(550, 400);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(300, 249);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructiuni";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Branch:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Load:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(124, 183);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(165, 35);
            this.totalTextBox.TabIndex = 16;
            // 
            // branchTextBox
            // 
            this.branchTextBox.Location = new System.Drawing.Point(124, 134);
            this.branchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.branchTextBox.Name = "branchTextBox";
            this.branchTextBox.Size = new System.Drawing.Size(165, 35);
            this.branchTextBox.TabIndex = 15;
            // 
            // storeTextBox
            // 
            this.storeTextBox.Location = new System.Drawing.Point(124, 85);
            this.storeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeTextBox.Name = "storeTextBox";
            this.storeTextBox.Size = new System.Drawing.Size(165, 35);
            this.storeTextBox.TabIndex = 14;
            // 
            // loadTextBox
            // 
            this.loadTextBox.Location = new System.Drawing.Point(124, 38);
            this.loadTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loadTextBox.Name = "loadTextBox";
            this.loadTextBox.Size = new System.Drawing.Size(165, 35);
            this.loadTextBox.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.influentaIrTextBox);
            this.groupBox3.Controls.Add(this.influentaIR);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.ticksTextBox);
            this.groupBox3.Controls.Add(this.issueRateTextBox);
            this.groupBox3.Controls.Add(this.oneCycleTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(920, 400);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(356, 249);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rezultate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 25);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ticks:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 93);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 25);
            this.label13.TabIndex = 17;
            this.label13.Text = "Issue Rate:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 44);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 25);
            this.label14.TabIndex = 13;
            this.label14.Text = "One-Cycle:";
            // 
            // ticksTextBox
            // 
            this.ticksTextBox.Location = new System.Drawing.Point(97, 134);
            this.ticksTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticksTextBox.Name = "ticksTextBox";
            this.ticksTextBox.Size = new System.Drawing.Size(251, 35);
            this.ticksTextBox.TabIndex = 15;
            // 
            // issueRateTextBox
            // 
            this.issueRateTextBox.Location = new System.Drawing.Point(142, 85);
            this.issueRateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.issueRateTextBox.Name = "issueRateTextBox";
            this.issueRateTextBox.Size = new System.Drawing.Size(206, 35);
            this.issueRateTextBox.TabIndex = 14;
            // 
            // oneCycleTextBox
            // 
            this.oneCycleTextBox.Location = new System.Drawing.Point(142, 38);
            this.oneCycleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oneCycleTextBox.Name = "oneCycleTextBox";
            this.oneCycleTextBox.Size = new System.Drawing.Size(206, 35);
            this.oneCycleTextBox.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.biport);
            this.groupBox4.Controls.Add(this.uniport);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(476, 42);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(578, 334);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parametrii Cache (Mapare Directa)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(267, 105);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "= FR";
            // 
            // biport
            // 
            this.biport.AutoSize = true;
            this.biport.Location = new System.Drawing.Point(9, 288);
            this.biport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.biport.Name = "biport";
            this.biport.Size = new System.Drawing.Size(108, 33);
            this.biport.TabIndex = 3;
            this.biport.TabStop = true;
            this.biport.Text = "Biport";
            this.biport.UseVisualStyleBackColor = true;
            // 
            // uniport
            // 
            this.uniport.AutoSize = true;
            this.uniport.Location = new System.Drawing.Point(9, 245);
            this.uniport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uniport.Name = "uniport";
            this.uniport.Size = new System.Drawing.Size(123, 33);
            this.uniport.TabIndex = 2;
            this.uniport.TabStop = true;
            this.uniport.Text = "Uniport";
            this.uniport.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sizeDC);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.blockSizeDC);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(346, 52);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(222, 166);
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
            this.sizeDC.Location = new System.Drawing.Point(117, 95);
            this.sizeDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeDC.Name = "sizeDC";
            this.sizeDC.Size = new System.Drawing.Size(88, 33);
            this.sizeDC.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 105);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 25);
            this.label18.TabIndex = 15;
            this.label18.Text = "Size_DC:";
            // 
            // blockSizeDC
            // 
            this.blockSizeDC.BackColor = System.Drawing.Color.LightGray;
            this.blockSizeDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blockSizeDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockSizeDC.FormattingEnabled = true;
            this.blockSizeDC.Location = new System.Drawing.Point(117, 40);
            this.blockSizeDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blockSizeDC.Name = "blockSizeDC";
            this.blockSizeDC.Size = new System.Drawing.Size(88, 33);
            this.blockSizeDC.TabIndex = 15;
            this.blockSizeDC.SelectedIndexChanged += new System.EventHandler(this.blockSizeDC_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(9, 48);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 25);
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
            this.groupBox5.Location = new System.Drawing.Point(39, 52);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(298, 166);
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
            this.sizeIC.Location = new System.Drawing.Point(129, 105);
            this.sizeIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sizeIC.Name = "sizeIC";
            this.sizeIC.Size = new System.Drawing.Size(88, 33);
            this.sizeIC.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 108);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 25);
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
            this.blockSize.Location = new System.Drawing.Point(129, 48);
            this.blockSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blockSize.Name = "blockSize";
            this.blockSize.Size = new System.Drawing.Size(88, 33);
            this.blockSize.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 52);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Block Size:";
            // 
            // traceFilesListBox
            // 
            this.traceFilesListBox.FormattingEnabled = true;
            this.traceFilesListBox.ItemHeight = 20;
            this.traceFilesListBox.Location = new System.Drawing.Point(140, 385);
            this.traceFilesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.traceFilesListBox.Name = "traceFilesListBox";
            this.traceFilesListBox.Size = new System.Drawing.Size(178, 244);
            this.traceFilesListBox.TabIndex = 21;
            // 
            // parsareFisier
            // 
            this.parsareFisier.Location = new System.Drawing.Point(328, 385);
            this.parsareFisier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parsareFisier.Name = "parsareFisier";
            this.parsareFisier.Size = new System.Drawing.Size(112, 66);
            this.parsareFisier.TabIndex = 22;
            this.parsareFisier.Text = "Parseaza Fisier";
            this.parsareFisier.UseVisualStyleBackColor = true;
            this.parsareFisier.Click += new System.EventHandler(this.parsareFisier_Click);
            // 
            // influentaIR
            // 
            this.influentaIR.AutoSize = true;
            this.influentaIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.influentaIR.Location = new System.Drawing.Point(21, 193);
            this.influentaIR.Name = "influentaIR";
            this.influentaIR.Size = new System.Drawing.Size(109, 25);
            this.influentaIR.TabIndex = 19;
            this.influentaIR.Text = "influentaIR:";
            // 
            // influentaIrTextBox
            // 
            this.influentaIrTextBox.Location = new System.Drawing.Point(142, 187);
            this.influentaIrTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.influentaIrTextBox.Name = "influentaIrTextBox";
            this.influentaIrTextBox.Size = new System.Drawing.Size(180, 35);
            this.influentaIrTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 692);
            this.Controls.Add(this.parsareFisier);
            this.Controls.Add(this.traceFilesListBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startSimulare);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button startSimulare;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox branchTextBox;
        private System.Windows.Forms.TextBox storeTextBox;
        private System.Windows.Forms.TextBox loadTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ticksTextBox;
        private System.Windows.Forms.TextBox issueRateTextBox;
        private System.Windows.Forms.TextBox oneCycleTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton biport;
        private System.Windows.Forms.RadioButton uniport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox blockSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sizeIC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox blockSizeDC;
        private System.Windows.Forms.ComboBox sizeDC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox traceFilesListBox;
        private System.Windows.Forms.Button parsareFisier;
        private System.Windows.Forms.TextBox influentaIrTextBox;
        private System.Windows.Forms.Label influentaIR;
    }
}

