﻿namespace UserLogin
{
    partial class TakeMatelrials
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textTakeName = new System.Windows.Forms.TextBox();
            this.dataGridView_Materlial = new System.Windows.Forms.DataGridView();
            this.button_Take = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_TimeShow = new System.Windows.Forms.Timer(this.components);
            this.buttonGetMaterials = new System.Windows.Forms.Button();
            this.timerScanRFID = new System.Windows.Forms.Timer(this.components);
            this.labelCounts = new System.Windows.Forms.Label();
            this.textCounts = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Materlial)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(495, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "物品名称";
            // 
            // textTakeName
            // 
            this.textTakeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTakeName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textTakeName.Location = new System.Drawing.Point(606, 67);
            this.textTakeName.Multiline = true;
            this.textTakeName.Name = "textTakeName";
            this.textTakeName.Size = new System.Drawing.Size(183, 29);
            this.textTakeName.TabIndex = 45;
            // 
            // dataGridView_Materlial
            // 
            this.dataGridView_Materlial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Materlial.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Materlial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Materlial.Location = new System.Drawing.Point(-3, 1);
            this.dataGridView_Materlial.Name = "dataGridView_Materlial";
            this.dataGridView_Materlial.RowTemplate.Height = 23;
            this.dataGridView_Materlial.Size = new System.Drawing.Size(489, 424);
            this.dataGridView_Materlial.TabIndex = 41;
            // 
            // button_Take
            // 
            this.button_Take.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Take.BackColor = System.Drawing.Color.White;
            this.button_Take.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Take.Location = new System.Drawing.Point(606, 186);
            this.button_Take.Name = "button_Take";
            this.button_Take.Size = new System.Drawing.Size(82, 34);
            this.button_Take.TabIndex = 42;
            this.button_Take.Text = "查找";
            this.button_Take.UseVisualStyleBackColor = false;
            this.button_Take.Click += new System.EventHandler(this.button_Take_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel1.Text = "当前时间";
            // 
            // toolStripStatusLabelTime
            // 
            this.toolStripStatusLabelTime.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabelTime.Name = "toolStripStatusLabelTime";
            this.toolStripStatusLabelTime.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabelTime.Text = "toolStripStatusLabel2";
            // 
            // timer_TimeShow
            // 
            this.timer_TimeShow.Enabled = true;
            this.timer_TimeShow.Interval = 1000;
            this.timer_TimeShow.Tick += new System.EventHandler(this.timer_TimeShow_Tick);
            // 
            // buttonGetMaterials
            // 
            this.buttonGetMaterials.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGetMaterials.BackColor = System.Drawing.Color.White;
            this.buttonGetMaterials.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonGetMaterials.Location = new System.Drawing.Point(713, 186);
            this.buttonGetMaterials.Name = "buttonGetMaterials";
            this.buttonGetMaterials.Size = new System.Drawing.Size(76, 34);
            this.buttonGetMaterials.TabIndex = 46;
            this.buttonGetMaterials.Text = "取出";
            this.buttonGetMaterials.UseVisualStyleBackColor = false;
            this.buttonGetMaterials.Click += new System.EventHandler(this.buttonGetMaterials_Click);
            // 
            // timerScanRFID
            // 
            this.timerScanRFID.Enabled = true;
            this.timerScanRFID.Interval = 1000;
            // 
            // labelCounts
            // 
            this.labelCounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCounts.AutoSize = true;
            this.labelCounts.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCounts.Location = new System.Drawing.Point(495, 134);
            this.labelCounts.Name = "labelCounts";
            this.labelCounts.Size = new System.Drawing.Size(98, 21);
            this.labelCounts.TabIndex = 48;
            this.labelCounts.Text = "取出数量";
            // 
            // textCounts
            // 
            this.textCounts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCounts.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textCounts.Location = new System.Drawing.Point(606, 129);
            this.textCounts.Multiline = true;
            this.textCounts.Name = "textCounts";
            this.textCounts.Size = new System.Drawing.Size(183, 31);
            this.textCounts.TabIndex = 49;
            // 
            // TakeMatelrials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCounts);
            this.Controls.Add(this.labelCounts);
            this.Controls.Add(this.buttonGetMaterials);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_Take);
            this.Controls.Add(this.dataGridView_Materlial);
            this.Controls.Add(this.textTakeName);
            this.Controls.Add(this.label1);
            this.Name = "TakeMatelrials";
            this.Text = "取物品";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Materlial)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textTakeName;
        private System.Windows.Forms.DataGridView dataGridView_Materlial;
        private System.Windows.Forms.Button button_Take;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTime;
        private System.Windows.Forms.Timer timer_TimeShow;
        private System.Windows.Forms.Button buttonGetMaterials;
        private System.Windows.Forms.Timer timerScanRFID;
        private System.Windows.Forms.Label labelCounts;
        private System.Windows.Forms.TextBox textCounts;
    }
}