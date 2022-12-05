namespace distribution
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.formA = new System.Windows.Forms.NumericUpDown();
            this.formNiter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.formLeft = new System.Windows.Forms.NumericUpDown();
            this.formRight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxNeymon = new System.Windows.Forms.CheckBox();
            this.checkBoxMetropolis = new System.Windows.Forms.CheckBox();
            this.checkBoxInverse = new System.Windows.Forms.CheckBox();
            this.formStep = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarMetropolis = new System.Windows.Forms.ProgressBar();
            this.progressBarNeymon = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBarInverse = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.Sigm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disperse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.indexNfield = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexNfield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1083, 27);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(94, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 24);
            this.toolStripButton1.Text = "Distribution";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 24);
            this.toolStripButton2.Text = "About";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 24);
            this.toolStripLabel1.Text = "Help";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // formA
            // 
            this.formA.DecimalPlaces = 1;
            this.formA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.formA.Location = new System.Drawing.Point(37, 11);
            this.formA.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.formA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.formA.Name = "formA";
            this.formA.Size = new System.Drawing.Size(92, 24);
            this.formA.TabIndex = 1;
            this.formA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // formNiter
            // 
            this.formNiter.DecimalPlaces = 1;
            this.formNiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formNiter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.formNiter.Location = new System.Drawing.Point(161, 13);
            this.formNiter.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.formNiter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.formNiter.Name = "formNiter";
            this.formNiter.Size = new System.Drawing.Size(120, 24);
            this.formNiter.TabIndex = 2;
            this.formNiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formNiter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "α";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(138, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "β";
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(6, 147);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(106, 28);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // formLeft
            // 
            this.formLeft.DecimalPlaces = 1;
            this.formLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formLeft.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.formLeft.Location = new System.Drawing.Point(94, 51);
            this.formLeft.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formLeft.Name = "formLeft";
            this.formLeft.Size = new System.Drawing.Size(92, 24);
            this.formLeft.TabIndex = 7;
            this.formLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formRight
            // 
            this.formRight.DecimalPlaces = 1;
            this.formRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formRight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.formRight.Location = new System.Drawing.Point(94, 81);
            this.formRight.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formRight.Name = "formRight";
            this.formRight.Size = new System.Drawing.Size(92, 24);
            this.formRight.TabIndex = 8;
            this.formRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formRight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formRight.ValueChanged += new System.EventHandler(this.formRight_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "X from";
            // 
            // checkBoxNeymon
            // 
            this.checkBoxNeymon.AutoSize = true;
            this.checkBoxNeymon.Checked = true;
            this.checkBoxNeymon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNeymon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNeymon.Location = new System.Drawing.Point(356, 254);
            this.checkBoxNeymon.Name = "checkBoxNeymon";
            this.checkBoxNeymon.Size = new System.Drawing.Size(89, 22);
            this.checkBoxNeymon.TabIndex = 11;
            this.checkBoxNeymon.Text = "Neymon";
            this.checkBoxNeymon.UseVisualStyleBackColor = true;
            this.checkBoxNeymon.Visible = false;
            this.checkBoxNeymon.CheckedChanged += new System.EventHandler(this.checkBoxNeymon_CheckedChanged);
            // 
            // checkBoxMetropolis
            // 
            this.checkBoxMetropolis.AutoSize = true;
            this.checkBoxMetropolis.Checked = true;
            this.checkBoxMetropolis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMetropolis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMetropolis.Location = new System.Drawing.Point(356, 292);
            this.checkBoxMetropolis.Name = "checkBoxMetropolis";
            this.checkBoxMetropolis.Size = new System.Drawing.Size(107, 22);
            this.checkBoxMetropolis.TabIndex = 12;
            this.checkBoxMetropolis.Text = "Metropolis";
            this.checkBoxMetropolis.UseVisualStyleBackColor = true;
            this.checkBoxMetropolis.Visible = false;
            this.checkBoxMetropolis.CheckedChanged += new System.EventHandler(this.checkBoxMetropolis_CheckedChanged);
            // 
            // checkBoxInverse
            // 
            this.checkBoxInverse.AutoSize = true;
            this.checkBoxInverse.Checked = true;
            this.checkBoxInverse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxInverse.Location = new System.Drawing.Point(356, 331);
            this.checkBoxInverse.Name = "checkBoxInverse";
            this.checkBoxInverse.Size = new System.Drawing.Size(81, 22);
            this.checkBoxInverse.TabIndex = 13;
            this.checkBoxInverse.Text = "Inverse";
            this.checkBoxInverse.UseVisualStyleBackColor = true;
            this.checkBoxInverse.Visible = false;
            this.checkBoxInverse.CheckedChanged += new System.EventHandler(this.checkBoxInverse_CheckedChanged);
            // 
            // formStep
            // 
            this.formStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formStep.Location = new System.Drawing.Point(94, 115);
            this.formStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.formStep.Name = "formStep";
            this.formStep.Size = new System.Drawing.Size(92, 24);
            this.formStep.TabIndex = 14;
            this.formStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.formStep.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Columns";
            // 
            // progressBarMetropolis
            // 
            this.progressBarMetropolis.Location = new System.Drawing.Point(16, 304);
            this.progressBarMetropolis.Name = "progressBarMetropolis";
            this.progressBarMetropolis.Size = new System.Drawing.Size(283, 10);
            this.progressBarMetropolis.TabIndex = 16;
            // 
            // progressBarNeymon
            // 
            this.progressBarNeymon.Location = new System.Drawing.Point(16, 266);
            this.progressBarNeymon.Name = "progressBarNeymon";
            this.progressBarNeymon.Size = new System.Drawing.Size(283, 10);
            this.progressBarNeymon.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(224, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Neymann";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(219, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Metropolis";
            // 
            // progressBarInverse
            // 
            this.progressBarInverse.Location = new System.Drawing.Point(16, 343);
            this.progressBarInverse.Name = "progressBarInverse";
            this.progressBarInverse.Size = new System.Drawing.Size(283, 10);
            this.progressBarInverse.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(241, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "Inverse";
            // 
            // Sigm
            // 
            this.Sigm.HeaderText = "Sigma";
            this.Sigm.MinimumWidth = 6;
            this.Sigm.Name = "Sigm";
            this.Sigm.ReadOnly = true;
            this.Sigm.Width = 125;
            // 
            // Disperse
            // 
            this.Disperse.HeaderText = "Dispers";
            this.Disperse.MinimumWidth = 6;
            this.Disperse.Name = "Disperse";
            this.Disperse.ReadOnly = true;
            this.Disperse.Width = 125;
            // 
            // Mean
            // 
            this.Mean.HeaderText = "Mean";
            this.Mean.MinimumWidth = 6;
            this.Mean.Name = "Mean";
            this.Mean.ReadOnly = true;
            this.Mean.Width = 125;
            // 
            // Method
            // 
            this.Method.HeaderText = "Method";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            this.Method.ReadOnly = true;
            this.Method.Width = 125;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Method,
            this.Mean,
            this.Disperse,
            this.Sigm});
            this.dataGrid.Location = new System.Drawing.Point(15, 374);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.Size = new System.Drawing.Size(448, 127);
            this.dataGrid.TabIndex = 24;
            this.dataGrid.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.indexNfield);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.Save);
            this.splitContainer1.Panel1.Controls.Add(this.StopButton);
            this.splitContainer1.Panel1.Controls.Add(this.PauseButton);
            this.splitContainer1.Panel1.Controls.Add(this.formA);
            this.splitContainer1.Panel1.Controls.Add(this.dataGrid);
            this.splitContainer1.Panel1.Controls.Add(this.formNiter);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarInverse);
            this.splitContainer1.Panel1.Controls.Add(this.Start);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.formLeft);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.formRight);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarNeymon);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.progressBarMetropolis);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxNeymon);
            this.splitContainer1.Panel1.Controls.Add(this.formStep);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMetropolis);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxInverse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(1083, 524);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 0;
            // 
            // indexNfield
            // 
            this.indexNfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indexNfield.Location = new System.Drawing.Point(318, 15);
            this.indexNfield.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.indexNfield.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.indexNfield.Name = "indexNfield";
            this.indexNfield.Size = new System.Drawing.Size(92, 24);
            this.indexNfield.TabIndex = 29;
            this.indexNfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.indexNfield.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(292, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 18);
            this.label9.TabIndex = 30;
            this.label9.Text = "N";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(350, 215);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(106, 28);
            this.Save.TabIndex = 28;
            this.Save.Text = "Save results";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Visible = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(6, 215);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(106, 28);
            this.StopButton.TabIndex = 26;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PauseButton.Location = new System.Drawing.Point(6, 181);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(106, 28);
            this.PauseButton.TabIndex = 25;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Absolute";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series10.Legend = "Legend1";
            series10.Name = "Neymon";
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series11.Legend = "Legend1";
            series11.Name = "Metropolis";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Inverse";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(602, 524);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Beta distribution";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formNiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indexNfield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.NumericUpDown formA;
        private System.Windows.Forms.NumericUpDown formNiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.NumericUpDown formLeft;
        private System.Windows.Forms.NumericUpDown formRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxNeymon;
        private System.Windows.Forms.CheckBox checkBoxMetropolis;
        private System.Windows.Forms.CheckBox checkBoxInverse;
        private System.Windows.Forms.NumericUpDown formStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarMetropolis;
        private System.Windows.Forms.ProgressBar progressBarNeymon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBarInverse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disperse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.NumericUpDown indexNfield;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

