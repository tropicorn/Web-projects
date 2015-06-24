namespace Project_3
{
    partial class btnLast
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.County = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Type,
            this.Namez,
            this.Email,
            this.City,
            this.Zip,
            this.County,
            this.State});
            this.dataGridView1.Location = new System.Drawing.Point(3, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 196);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 5;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Namez
            // 
            this.Namez.HeaderText = "Name";
            this.Namez.Name = "Namez";
            this.Namez.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            // 
            // County
            // 
            this.County.HeaderText = "County";
            this.County.Name = "County";
            this.County.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(77, 202);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(107, 25);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(532, 202);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 25);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(750, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.dataGridView1);
            this.Name = "btnLast";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn County;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;


    }
}