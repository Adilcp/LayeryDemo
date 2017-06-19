namespace LayeryDemo.Presentation.WinForm
{
    partial class frmMain
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
            this.lstTeacher = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.lstStds = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTeacher
            // 
            this.lstTeacher.DisplayMember = "Name";
            this.lstTeacher.FormattingEnabled = true;
            this.lstTeacher.Location = new System.Drawing.Point(67, 32);
            this.lstTeacher.Name = "lstTeacher";
            this.lstTeacher.Size = new System.Drawing.Size(232, 199);
            this.lstTeacher.TabIndex = 0;
            this.lstTeacher.SelectedIndexChanged += new System.EventHandler(this.lstTeacher_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(184, 240);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(67, 240);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(103, 29);
            this.btnAddTeacher.TabIndex = 2;
            this.btnAddTeacher.Text = "Add New";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // lstStds
            // 
            this.lstStds.DisplayMember = "Label";
            this.lstStds.FormattingEnabled = true;
            this.lstStds.Location = new System.Drawing.Point(387, 30);
            this.lstStds.Name = "lstStds";
            this.lstStds.Size = new System.Drawing.Size(196, 199);
            this.lstStds.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 284);
            this.Controls.Add(this.lstStds);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lstTeacher);
            this.Name = "frmMain";
            this.Text = "Standards";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTeacher;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.ListBox lstStds;
    }
}

