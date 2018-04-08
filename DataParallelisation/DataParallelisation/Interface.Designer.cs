namespace DataParallelisation
{
    partial class Interface
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
            this.outputLog = new System.Windows.Forms.RichTextBox();
            this.storeID = new System.Windows.Forms.Label();
            this.storeYear = new System.Windows.Forms.Label();
            this.storeWeek = new System.Windows.Forms.Label();
            this.retrieveInfo = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.weekText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputLog
            // 
            this.outputLog.Location = new System.Drawing.Point(469, 12);
            this.outputLog.Name = "outputLog";
            this.outputLog.Size = new System.Drawing.Size(930, 607);
            this.outputLog.TabIndex = 0;
            this.outputLog.Text = "";
            this.outputLog.TextChanged += new System.EventHandler(this.outputLog_TextChanged);
            // 
            // storeID
            // 
            this.storeID.AutoSize = true;
            this.storeID.Location = new System.Drawing.Point(123, 171);
            this.storeID.Name = "storeID";
            this.storeID.Size = new System.Drawing.Size(46, 13);
            this.storeID.TabIndex = 4;
            this.storeID.Text = "Store ID";
            // 
            // storeYear
            // 
            this.storeYear.AutoSize = true;
            this.storeYear.Location = new System.Drawing.Point(123, 198);
            this.storeYear.Name = "storeYear";
            this.storeYear.Size = new System.Drawing.Size(64, 13);
            this.storeYear.TabIndex = 5;
            this.storeYear.Text = "Report Year";
            // 
            // storeWeek
            // 
            this.storeWeek.AutoSize = true;
            this.storeWeek.Location = new System.Drawing.Point(123, 224);
            this.storeWeek.Name = "storeWeek";
            this.storeWeek.Size = new System.Drawing.Size(71, 13);
            this.storeWeek.TabIndex = 6;
            this.storeWeek.Text = "Report Week";
            // 
            // retrieveInfo
            // 
            this.retrieveInfo.Location = new System.Drawing.Point(236, 250);
            this.retrieveInfo.Name = "retrieveInfo";
            this.retrieveInfo.Size = new System.Drawing.Size(75, 23);
            this.retrieveInfo.TabIndex = 7;
            this.retrieveInfo.Text = "Search";
            this.retrieveInfo.UseVisualStyleBackColor = true;
            this.retrieveInfo.Click += new System.EventHandler(this.retrieveInfo_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1364, 27);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(24, 578);
            this.vScrollBar1.TabIndex = 8;
            // 
            // tFilePath
            // 
            this.tFilePath.Location = new System.Drawing.Point(100, 388);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Size = new System.Drawing.Size(363, 20);
            this.tFilePath.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(236, 171);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(107, 20);
            this.idText.TabIndex = 11;
            // 
            // weekText
            // 
            this.weekText.Location = new System.Drawing.Point(236, 224);
            this.weekText.Name = "weekText";
            this.weekText.Size = new System.Drawing.Size(107, 20);
            this.weekText.TabIndex = 12;
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(236, 198);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(107, 20);
            this.yearText.TabIndex = 13;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 631);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.weekText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tFilePath);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.retrieveInfo);
            this.Controls.Add(this.storeWeek);
            this.Controls.Add(this.storeYear);
            this.Controls.Add(this.storeID);
            this.Controls.Add(this.outputLog);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox outputLog;
        private System.Windows.Forms.Label storeID;
        private System.Windows.Forms.Label storeYear;
        private System.Windows.Forms.Label storeWeek;
        private System.Windows.Forms.Button retrieveInfo;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox weekText;
        private System.Windows.Forms.TextBox yearText;
    }
}