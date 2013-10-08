namespace GetClassesFromDll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCloseForm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btDefault = new System.Windows.Forms.Button();
            this.tbConfig = new System.Windows.Forms.TextBox();
            this.btConfig = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btDll = new System.Windows.Forms.Button();
            this.tbdll = new System.Windows.Forms.TextBox();
            this.btNUnit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNUnit = new System.Windows.Forms.TextBox();
            this.btXSL = new System.Windows.Forms.Button();
            this.tbXSL = new System.Windows.Forms.TextBox();
            this.btWatch = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btClearChecked = new System.Windows.Forms.Button();
            this.btCheckedAll = new System.Windows.Forms.Button();
            this.cblbTree = new System.Windows.Forms.CheckedListBox();
            this.ofdDll = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdNUnit = new System.Windows.Forms.OpenFileDialog();
            this.ofdXSL = new System.Windows.Forms.OpenFileDialog();
            this.ofdConfig = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ofdOpenSavedFile = new System.Windows.Forms.OpenFileDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCloseForm
            // 
            this.btCloseForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCloseForm.Location = new System.Drawing.Point(715, 527);
            this.btCloseForm.Name = "btCloseForm";
            this.btCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btCloseForm.TabIndex = 0;
            this.btCloseForm.Text = "Выход";
            this.btCloseForm.UseVisualStyleBackColor = true;
            this.btCloseForm.Click += new System.EventHandler(this.btCloseForm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btWatch);
            this.groupBox1.Controls.Add(this.btSubmit);
            this.groupBox1.Location = new System.Drawing.Point(264, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 468);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загрузка и исполнение тестов";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(241, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.btDefault);
            this.groupBox4.Controls.Add(this.tbConfig);
            this.groupBox4.Controls.Add(this.btConfig);
            this.groupBox4.Location = new System.Drawing.Point(7, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 143);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введите путь к config файлу";
            // 
            // btDefault
            // 
            this.btDefault.Location = new System.Drawing.Point(4, 90);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(189, 23);
            this.btDefault.TabIndex = 14;
            this.btDefault.Text = "Загрузить данные по умолчанию";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // tbConfig
            // 
            this.tbConfig.Location = new System.Drawing.Point(5, 56);
            this.tbConfig.Name = "tbConfig";
            this.tbConfig.ReadOnly = true;
            this.tbConfig.Size = new System.Drawing.Size(394, 20);
            this.tbConfig.TabIndex = 16;
            this.tbConfig.Text = "config.xml";
            // 
            // btConfig
            // 
            this.btConfig.Location = new System.Drawing.Point(413, 54);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(75, 23);
            this.btConfig.TabIndex = 15;
            this.btConfig.Text = "Загрузить";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btDll);
            this.groupBox3.Controls.Add(this.tbdll);
            this.groupBox3.Controls.Add(this.btNUnit);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbNUnit);
            this.groupBox3.Controls.Add(this.btXSL);
            this.groupBox3.Controls.Add(this.tbXSL);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 221);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите имя сборки для загрузки тестов";
            // 
            // btDll
            // 
            this.btDll.Location = new System.Drawing.Point(418, 45);
            this.btDll.Name = "btDll";
            this.btDll.Size = new System.Drawing.Size(75, 23);
            this.btDll.TabIndex = 1;
            this.btDll.Text = "Загрузить";
            this.btDll.UseVisualStyleBackColor = true;
            this.btDll.Click += new System.EventHandler(this.btDll_Click);
            // 
            // tbdll
            // 
            this.tbdll.Location = new System.Drawing.Point(9, 48);
            this.tbdll.Name = "tbdll";
            this.tbdll.ReadOnly = true;
            this.tbdll.Size = new System.Drawing.Size(394, 20);
            this.tbdll.TabIndex = 2;
            this.tbdll.TextChanged += new System.EventHandler(this.tbdll_TextChanged);
            // 
            // btNUnit
            // 
            this.btNUnit.Location = new System.Drawing.Point(418, 113);
            this.btNUnit.Name = "btNUnit";
            this.btNUnit.Size = new System.Drawing.Size(75, 23);
            this.btNUnit.TabIndex = 3;
            this.btNUnit.Text = "Загрузить";
            this.btNUnit.UseVisualStyleBackColor = true;
            this.btNUnit.Click += new System.EventHandler(this.btNUnit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите путь к NUnit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введите путь к файлу преобразования и визуализации ";
            // 
            // tbNUnit
            // 
            this.tbNUnit.Location = new System.Drawing.Point(9, 116);
            this.tbNUnit.Name = "tbNUnit";
            this.tbNUnit.ReadOnly = true;
            this.tbNUnit.Size = new System.Drawing.Size(394, 20);
            this.tbNUnit.TabIndex = 4;
            // 
            // btXSL
            // 
            this.btXSL.Location = new System.Drawing.Point(417, 184);
            this.btXSL.Name = "btXSL";
            this.btXSL.Size = new System.Drawing.Size(75, 23);
            this.btXSL.TabIndex = 5;
            this.btXSL.Text = "Загрузить";
            this.btXSL.UseVisualStyleBackColor = true;
            this.btXSL.Click += new System.EventHandler(this.btXSL_Click);
            // 
            // tbXSL
            // 
            this.tbXSL.Location = new System.Drawing.Point(8, 187);
            this.tbXSL.Name = "tbXSL";
            this.tbXSL.ReadOnly = true;
            this.tbXSL.Size = new System.Drawing.Size(394, 20);
            this.tbXSL.TabIndex = 6;
            // 
            // btWatch
            // 
            this.btWatch.Enabled = false;
            this.btWatch.Location = new System.Drawing.Point(120, 431);
            this.btWatch.Name = "btWatch";
            this.btWatch.Size = new System.Drawing.Size(75, 23);
            this.btWatch.TabIndex = 9;
            this.btWatch.Text = "Показать";
            this.btWatch.UseVisualStyleBackColor = true;
            this.btWatch.Click += new System.EventHandler(this.btWatch_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Enabled = false;
            this.btSubmit.Location = new System.Drawing.Point(6, 431);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 0;
            this.btSubmit.Text = "Запуск";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btClearChecked);
            this.groupBox2.Controls.Add(this.btCheckedAll);
            this.groupBox2.Controls.Add(this.cblbTree);
            this.groupBox2.Location = new System.Drawing.Point(12, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 468);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дерево тестов";
            // 
            // btClearChecked
            // 
            this.btClearChecked.Location = new System.Drawing.Point(152, 431);
            this.btClearChecked.Name = "btClearChecked";
            this.btClearChecked.Size = new System.Drawing.Size(75, 23);
            this.btClearChecked.TabIndex = 16;
            this.btClearChecked.Text = "Ничего";
            this.btClearChecked.UseVisualStyleBackColor = true;
            this.btClearChecked.Click += new System.EventHandler(this.btClearChecked_Click);
            // 
            // btCheckedAll
            // 
            this.btCheckedAll.Location = new System.Drawing.Point(6, 431);
            this.btCheckedAll.Name = "btCheckedAll";
            this.btCheckedAll.Size = new System.Drawing.Size(75, 23);
            this.btCheckedAll.TabIndex = 15;
            this.btCheckedAll.Text = "Все";
            this.btCheckedAll.UseVisualStyleBackColor = true;
            this.btCheckedAll.Click += new System.EventHandler(this.btCheckedAll_Click);
            // 
            // cblbTree
            // 
            this.cblbTree.Dock = System.Windows.Forms.DockStyle.Top;
            this.cblbTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cblbTree.FormattingEnabled = true;
            this.cblbTree.Location = new System.Drawing.Point(3, 16);
            this.cblbTree.Name = "cblbTree";
            this.cblbTree.Size = new System.Drawing.Size(227, 382);
            this.cblbTree.TabIndex = 14;
            // 
            // ofdDll
            // 
            this.ofdDll.FileName = "openFileDialog1";
            this.ofdDll.Filter = "dll файл с тестами (*.dll) | *.dll";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.Filter = "dat файл (*.dat) | *.dat";
            // 
            // ofdNUnit
            // 
            this.ofdNUnit.FileName = "openFileDialog1";
            // 
            // ofdXSL
            // 
            this.ofdXSL.FileName = "openFileDialog1";
            // 
            // ofdConfig
            // 
            this.ofdConfig.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&Новый";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Открыть";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Сохранить";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "&Помощь";
            // 
            // ofdOpenSavedFile
            // 
            this.ofdOpenSavedFile.FileName = "openFileDialog1";
            this.ofdOpenSavedFile.Filter = "dat файл (*.dat) | *.dat";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 528);
            this.ProgressBar.MarqueeAnimationSpeed = 10;
            this.ProgressBar.Maximum = 25;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(687, 22);
            this.ProgressBar.Step = 20;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btCloseForm;
            this.ClientSize = new System.Drawing.Size(801, 561);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCloseForm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование с помощью Selenium";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCloseForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbdll;
        private System.Windows.Forms.Button btDll;
        private System.Windows.Forms.OpenFileDialog ofdDll;
        private System.Windows.Forms.TextBox tbXSL;
        private System.Windows.Forms.Button btXSL;
        private System.Windows.Forms.TextBox tbNUnit;
        private System.Windows.Forms.Button btNUnit;
        private System.Windows.Forms.Button btWatch;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.OpenFileDialog ofdNUnit;
        private System.Windows.Forms.OpenFileDialog ofdXSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cblbTree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbConfig;
        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.OpenFileDialog ofdConfig;
        private System.Windows.Forms.Button btCheckedAll;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button btClearChecked;
        private System.Windows.Forms.OpenFileDialog ofdOpenSavedFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

