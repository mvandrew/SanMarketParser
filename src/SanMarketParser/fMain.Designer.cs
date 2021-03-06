﻿namespace SanMarketParser
{
    partial class fMain
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
            this.bImport = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.tbEvents = new System.Windows.Forms.TextBox();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tbExportPath = new System.Windows.Forms.TextBox();
            this.lbExportPath = new System.Windows.Forms.Label();
            this.cbFragment = new System.Windows.Forms.CheckBox();
            this.lbFragmentSize = new System.Windows.Forms.Label();
            this.nmFragmentSize = new System.Windows.Forms.NumericUpDown();
            this.tcMain.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFragmentSize)).BeginInit();
            this.SuspendLayout();
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(12, 12);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(145, 23);
            this.bImport.TabIndex = 0;
            this.bImport.Text = "Импорт товаров";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(12, 41);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(145, 23);
            this.bExport.TabIndex = 1;
            this.bExport.Text = "Экспорт пакета";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bAll
            // 
            this.bAll.Location = new System.Drawing.Point(12, 70);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(145, 23);
            this.bAll.TabIndex = 2;
            this.bAll.Text = "Выполнить Всё";
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Visible = false;
            // 
            // bCancel
            // 
            this.bCancel.Enabled = false;
            this.bCancel.Location = new System.Drawing.Point(12, 99);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(145, 23);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpEvents);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Location = new System.Drawing.Point(163, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(554, 372);
            this.tcMain.TabIndex = 4;
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.tbEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvents.Size = new System.Drawing.Size(546, 346);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "Журнал событий";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tbEvents
            // 
            this.tbEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEvents.Location = new System.Drawing.Point(3, 3);
            this.tbEvents.Multiline = true;
            this.tbEvents.Name = "tbEvents";
            this.tbEvents.ReadOnly = true;
            this.tbEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbEvents.Size = new System.Drawing.Size(540, 340);
            this.tbEvents.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.nmFragmentSize);
            this.tpSettings.Controls.Add(this.lbFragmentSize);
            this.tpSettings.Controls.Add(this.cbFragment);
            this.tpSettings.Controls.Add(this.tbExportPath);
            this.tpSettings.Controls.Add(this.lbExportPath);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(546, 346);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Параметры";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tbExportPath
            // 
            this.tbExportPath.Location = new System.Drawing.Point(9, 19);
            this.tbExportPath.Name = "tbExportPath";
            this.tbExportPath.Size = new System.Drawing.Size(531, 20);
            this.tbExportPath.TabIndex = 1;
            // 
            // lbExportPath
            // 
            this.lbExportPath.AutoSize = true;
            this.lbExportPath.Location = new System.Drawing.Point(6, 3);
            this.lbExportPath.Name = "lbExportPath";
            this.lbExportPath.Size = new System.Drawing.Size(221, 13);
            this.lbExportPath.TabIndex = 0;
            this.lbExportPath.Text = "Путь к пакетам экспорта для 1С-Битрикс:";
            // 
            // cbFragment
            // 
            this.cbFragment.AutoSize = true;
            this.cbFragment.Location = new System.Drawing.Point(9, 46);
            this.cbFragment.Name = "cbFragment";
            this.cbFragment.Size = new System.Drawing.Size(182, 17);
            this.cbFragment.TabIndex = 2;
            this.cbFragment.Text = "Экспортировать фрагментами";
            this.cbFragment.UseVisualStyleBackColor = true;
            // 
            // lbFragmentSize
            // 
            this.lbFragmentSize.AutoSize = true;
            this.lbFragmentSize.Location = new System.Drawing.Point(6, 65);
            this.lbFragmentSize.Name = "lbFragmentSize";
            this.lbFragmentSize.Size = new System.Drawing.Size(105, 13);
            this.lbFragmentSize.TabIndex = 3;
            this.lbFragmentSize.Text = "Размер фрагмента";
            // 
            // nmFragmentSize
            // 
            this.nmFragmentSize.Location = new System.Drawing.Point(9, 81);
            this.nmFragmentSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmFragmentSize.Name = "nmFragmentSize";
            this.nmFragmentSize.Size = new System.Drawing.Size(120, 20);
            this.nmFragmentSize.TabIndex = 4;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 396);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bImport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парсинг товаров сайта SanMarket.ru";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.tcMain.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.tpEvents.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFragmentSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TextBox tbEvents;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TextBox tbExportPath;
        private System.Windows.Forms.Label lbExportPath;
        private System.Windows.Forms.NumericUpDown nmFragmentSize;
        private System.Windows.Forms.Label lbFragmentSize;
        private System.Windows.Forms.CheckBox cbFragment;
    }
}