namespace Kursovayaa
{
    partial class MainForm
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
            this.groupBoxPanelSize = new System.Windows.Forms.GroupBox();
            this.buttonSetPanelSize = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.panelHeightInput = new System.Windows.Forms.TextBox();
            this.panelWidthInput = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.groupBoxPopulate = new System.Windows.Forms.GroupBox();
            this.sizeSelect = new System.Windows.Forms.ComboBox();
            this.buttonPopulate = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.countInput = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.groupBoxOperate = new System.Windows.Forms.GroupBox();
            this.FCNR = new System.Windows.Forms.Button();
            this.BFDH = new System.Windows.Forms.Button();
            this.NFDH = new System.Windows.Forms.Button();
            this.FFDH = new System.Windows.Forms.Button();
            this.buttonScramble = new System.Windows.Forms.Button();
            this.buttonShowHideDebug = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.log = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPanelSize.SuspendLayout();
            this.groupBoxPopulate.SuspendLayout();
            this.groupBoxOperate.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPanelSize
            // 
            this.groupBoxPanelSize.Controls.Add(this.buttonSetPanelSize);
            this.groupBoxPanelSize.Controls.Add(this.labelHeight);
            this.groupBoxPanelSize.Controls.Add(this.panelHeightInput);
            this.groupBoxPanelSize.Controls.Add(this.panelWidthInput);
            this.groupBoxPanelSize.Controls.Add(this.labelWidth);
            this.groupBoxPanelSize.Location = new System.Drawing.Point(3, 6);
            this.groupBoxPanelSize.Name = "groupBoxPanelSize";
            this.groupBoxPanelSize.Size = new System.Drawing.Size(170, 105);
            this.groupBoxPanelSize.TabIndex = 0;
            this.groupBoxPanelSize.TabStop = false;
            this.groupBoxPanelSize.Text = "Panel Size";
            // 
            // buttonSetPanelSize
            // 
            this.buttonSetPanelSize.Location = new System.Drawing.Point(9, 71);
            this.buttonSetPanelSize.Name = "buttonSetPanelSize";
            this.buttonSetPanelSize.Size = new System.Drawing.Size(155, 23);
            this.buttonSetPanelSize.TabIndex = 3;
            this.buttonSetPanelSize.Text = "Set Panel Size";
            this.buttonSetPanelSize.UseVisualStyleBackColor = true;
            this.buttonSetPanelSize.Click += new System.EventHandler(this.SetPanelSizeClick);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 48);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 3;
            this.labelHeight.Text = "Height";
            // 
            // panelHeightInput
            // 
            this.panelHeightInput.Location = new System.Drawing.Point(74, 45);
            this.panelHeightInput.Name = "panelHeightInput";
            this.panelHeightInput.Size = new System.Drawing.Size(90, 20);
            this.panelHeightInput.TabIndex = 2;
            this.panelHeightInput.Text = "350";
            this.panelHeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelWidthInput
            // 
            this.panelWidthInput.Location = new System.Drawing.Point(74, 22);
            this.panelWidthInput.Name = "panelWidthInput";
            this.panelWidthInput.Size = new System.Drawing.Size(90, 20);
            this.panelWidthInput.TabIndex = 1;
            this.panelWidthInput.Text = "621";
            this.panelWidthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 22);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(35, 13);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width";
            // 
            // groupBoxPopulate
            // 
            this.groupBoxPopulate.Controls.Add(this.sizeSelect);
            this.groupBoxPopulate.Controls.Add(this.buttonPopulate);
            this.groupBoxPopulate.Controls.Add(this.labelCount);
            this.groupBoxPopulate.Controls.Add(this.countInput);
            this.groupBoxPopulate.Controls.Add(this.labelSize);
            this.groupBoxPopulate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.groupBoxPopulate.Location = new System.Drawing.Point(179, 6);
            this.groupBoxPopulate.Name = "groupBoxPopulate";
            this.groupBoxPopulate.Size = new System.Drawing.Size(170, 105);
            this.groupBoxPopulate.TabIndex = 0;
            this.groupBoxPopulate.TabStop = false;
            this.groupBoxPopulate.Text = "Populate";
            // 
            // sizeSelect
            // 
            this.sizeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeSelect.FormattingEnabled = true;
            this.sizeSelect.Items.AddRange(new object[] {
            "5-50 px",
            "50-100 px",
            "100-500 px"});
            this.sizeSelect.Location = new System.Drawing.Point(74, 19);
            this.sizeSelect.Name = "sizeSelect";
            this.sizeSelect.Size = new System.Drawing.Size(90, 21);
            this.sizeSelect.TabIndex = 4;
            // 
            // buttonPopulate
            // 
            this.buttonPopulate.Location = new System.Drawing.Point(9, 71);
            this.buttonPopulate.Name = "buttonPopulate";
            this.buttonPopulate.Size = new System.Drawing.Size(155, 23);
            this.buttonPopulate.TabIndex = 6;
            this.buttonPopulate.Text = "Generate Blocks";
            this.buttonPopulate.UseVisualStyleBackColor = true;
            this.buttonPopulate.Click += new System.EventHandler(this.PopulateClick);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(6, 48);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(35, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "Count";
            // 
            // countInput
            // 
            this.countInput.Location = new System.Drawing.Point(74, 45);
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(90, 20);
            this.countInput.TabIndex = 5;
            this.countInput.Text = "30";
            this.countInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(6, 22);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(62, 13);
            this.labelSize.TabIndex = 0;
            this.labelSize.Text = "Size Range";
            // 
            // groupBoxOperate
            // 
            this.groupBoxOperate.Controls.Add(this.FCNR);
            this.groupBoxOperate.Controls.Add(this.BFDH);
            this.groupBoxOperate.Controls.Add(this.NFDH);
            this.groupBoxOperate.Controls.Add(this.FFDH);
            this.groupBoxOperate.Controls.Add(this.buttonScramble);
            this.groupBoxOperate.Controls.Add(this.buttonShowHideDebug);
            this.groupBoxOperate.Location = new System.Drawing.Point(355, 6);
            this.groupBoxOperate.Name = "groupBoxOperate";
            this.groupBoxOperate.Size = new System.Drawing.Size(253, 105);
            this.groupBoxOperate.TabIndex = 7;
            this.groupBoxOperate.TabStop = false;
            this.groupBoxOperate.Text = "Operate";
            // 
            // FCNR
            // 
            this.FCNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FCNR.Location = new System.Drawing.Point(9, 17);
            this.FCNR.Name = "FCNR";
            this.FCNR.Size = new System.Drawing.Size(116, 23);
            this.FCNR.TabIndex = 12;
            this.FCNR.Text = "FCNR";
            this.FCNR.UseVisualStyleBackColor = true;
            this.FCNR.Click += new System.EventHandler(this.button3_Click);
            // 
            // BFDH
            // 
            this.BFDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFDH.Location = new System.Drawing.Point(131, 17);
            this.BFDH.Name = "BFDH";
            this.BFDH.Size = new System.Drawing.Size(116, 23);
            this.BFDH.TabIndex = 11;
            this.BFDH.Text = "BFDH";
            this.BFDH.UseVisualStyleBackColor = true;
            this.BFDH.Click += new System.EventHandler(this.button2_Click);
            // 
            // NFDH
            // 
            this.NFDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NFDH.Location = new System.Drawing.Point(9, 43);
            this.NFDH.Name = "NFDH";
            this.NFDH.Size = new System.Drawing.Size(116, 23);
            this.NFDH.TabIndex = 9;
            this.NFDH.Text = "NFDH";
            this.NFDH.UseVisualStyleBackColor = true;
            this.NFDH.Click += new System.EventHandler(this.button1_Click);
            // 
            // FFDH
            // 
            this.FFDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FFDH.Location = new System.Drawing.Point(131, 45);
            this.FFDH.Name = "FFDH";
            this.FFDH.Size = new System.Drawing.Size(116, 23);
            this.FFDH.TabIndex = 10;
            this.FFDH.Text = "FFDH";
            this.FFDH.UseVisualStyleBackColor = true;
            this.FFDH.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonScramble
            // 
            this.buttonScramble.Location = new System.Drawing.Point(9, 71);
            this.buttonScramble.Name = "buttonScramble";
            this.buttonScramble.Size = new System.Drawing.Size(116, 23);
            this.buttonScramble.TabIndex = 7;
            this.buttonScramble.Text = "Scramble";
            this.buttonScramble.UseVisualStyleBackColor = true;
            this.buttonScramble.Click += new System.EventHandler(this.ScrambleClick);
            // 
            // buttonShowHideDebug
            // 
            this.buttonShowHideDebug.Location = new System.Drawing.Point(131, 71);
            this.buttonShowHideDebug.Name = "buttonShowHideDebug";
            this.buttonShowHideDebug.Size = new System.Drawing.Size(116, 23);
            this.buttonShowHideDebug.TabIndex = 6;
            this.buttonShowHideDebug.Text = "Show Log";
            this.buttonShowHideDebug.UseVisualStyleBackColor = true;
            this.buttonShowHideDebug.Click += new System.EventHandler(this.ToggleLogClick);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.log);
            this.groupBoxLog.Location = new System.Drawing.Point(4, 113);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(598, 127);
            this.groupBoxLog.TabIndex = 8;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Log";
            // 
            // log
            // 
            this.log.FormattingEnabled = true;
            this.log.Location = new System.Drawing.Point(10, 20);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(582, 95);
            this.log.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(604, 367);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPaint);
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.AutoScroll = true;
            this.containerPanel.BackColor = System.Drawing.Color.Transparent;
            this.containerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.containerPanel.Controls.Add(this.panel);
            this.containerPanel.Location = new System.Drawing.Point(13, 13);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(606, 368);
            this.containerPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.groupBoxLog);
            this.panel1.Controls.Add(this.groupBoxOperate);
            this.panel1.Controls.Add(this.groupBoxPopulate);
            this.panel1.Controls.Add(this.groupBoxPanelSize);
            this.panel1.Location = new System.Drawing.Point(12, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 249);
            this.panel1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(631, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.containerPanel);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "MainForm";
            this.Text = "BinPacker";
            this.groupBoxPanelSize.ResumeLayout(false);
            this.groupBoxPanelSize.PerformLayout();
            this.groupBoxPopulate.ResumeLayout(false);
            this.groupBoxPopulate.PerformLayout();
            this.groupBoxOperate.ResumeLayout(false);
            this.groupBoxLog.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPanelSize;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox panelHeightInput;
        private System.Windows.Forms.TextBox panelWidthInput;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Button buttonSetPanelSize;
        private System.Windows.Forms.GroupBox groupBoxPopulate;
        private System.Windows.Forms.Button buttonPopulate;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox countInput;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox sizeSelect;
        private System.Windows.Forms.GroupBox groupBoxOperate;
        private System.Windows.Forms.Button buttonScramble;
        private System.Windows.Forms.Button buttonShowHideDebug;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.ListBox log;
        private System.Windows.Forms.Button NFDH;
        private System.Windows.Forms.Button FFDH;
        private System.Windows.Forms.Button BFDH;
        private System.Windows.Forms.Button FCNR;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
    }
}