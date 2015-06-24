namespace Project_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOrgName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOrgTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(144, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organization Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(144, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organization Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(144, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "State";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // txtOrgName
            // 
            this.txtOrgName.AutoCompleteCustomSource.AddRange(new string[] {
            "GetOrgTypes()"});
            this.txtOrgName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOrgName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtOrgName.Location = new System.Drawing.Point(290, 139);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(100, 20);
            this.txtOrgName.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(309, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show results";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOrgTypes
            // 
            this.cmbOrgTypes.FormattingEnabled = true;
            this.cmbOrgTypes.Location = new System.Drawing.Point(290, 90);
            this.cmbOrgTypes.Name = "cmbOrgTypes";
            this.cmbOrgTypes.Size = new System.Drawing.Size(141, 21);
            this.cmbOrgTypes.TabIndex = 8;
            this.cmbOrgTypes.Text = "--Select an organization --";
            this.cmbOrgTypes.SelectedIndexChanged += new System.EventHandler(this.cmbOrgTypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(144, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "County";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(200, 178);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(84, 21);
            this.cmbState.TabIndex = 11;
            this.cmbState.Text = "---";
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(290, 178);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(141, 21);
            this.cmbCity.TabIndex = 12;
            this.cmbCity.Text = "-- Select a town --";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(141, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search Engine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 350);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOrgTypes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrgName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Emergency Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtOrgName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbOrgTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label label5;
    }
}

