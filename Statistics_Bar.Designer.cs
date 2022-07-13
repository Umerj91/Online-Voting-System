namespace Online_Voting_System
{
    partial class Statistics_Bar
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
            this.label2 = new System.Windows.Forms.Label();
            this.btncheck = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.btncount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Candidate to Check His/Her Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncheck.Location = new System.Drawing.Point(177, 81);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(139, 23);
            this.btncheck.TabIndex = 3;
            this.btncheck.Text = "Enter";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vid,
            this.cid,
            this.cdname,
            this.dis});
            this.dataGridView1.Location = new System.Drawing.Point(0, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 186);
            this.dataGridView1.TabIndex = 4;
            // 
            // vid
            // 
            this.vid.HeaderText = "Voter ID";
            this.vid.Name = "vid";
            // 
            // cid
            // 
            this.cid.HeaderText = "Candidate ID";
            this.cid.Name = "cid";
            // 
            // cdname
            // 
            this.cdname.HeaderText = "Candidate Name";
            this.cdname.Name = "cdname";
            // 
            // dis
            // 
            this.dis.HeaderText = "District";
            this.dis.Name = "dis";
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Raja Parvez Ashraf(101)-NA-58",
            "Shahid Khaqan Abassi(102)-NA-53",
            "Gulzar Khan(103)-NA-4",
            "Khurram Shehzad(104)-NA-107"});
            this.cmb1.Location = new System.Drawing.Point(358, 24);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(204, 21);
            this.cmb1.TabIndex = 5;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // btncount
            // 
            this.btncount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncount.Location = new System.Drawing.Point(388, 81);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(139, 23);
            this.btncount.TabIndex = 6;
            this.btncount.Text = "Count Vote";
            this.btncount.UseVisualStyleBackColor = false;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // Statistics_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 392);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Statistics_Bar";
            this.Text = "Statistics Bar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.DataGridViewTextBoxColumn vid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dis;
    }
}