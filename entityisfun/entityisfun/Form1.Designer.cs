namespace entityisfun
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.gbFiltering = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.cbContactTitles = new System.Windows.Forms.ComboBox();
            this.lbCountries = new System.Windows.Forms.Label();
            this.lbContactTitles = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbFiltering.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(13, 13);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(566, 247);
            this.dgvCustomers.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Location = new System.Drawing.Point(13, 267);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(62, 17);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Text = "Filtering\r\n";
            this.cbFilter.UseVisualStyleBackColor = true;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.cbFilter_CheckedChanged);
            // 
            // gbFiltering
            // 
            this.gbFiltering.Controls.Add(this.btnRefresh);
            this.gbFiltering.Controls.Add(this.cbCountries);
            this.gbFiltering.Controls.Add(this.cbContactTitles);
            this.gbFiltering.Controls.Add(this.lbCountries);
            this.gbFiltering.Controls.Add(this.lbContactTitles);
            this.gbFiltering.Controls.Add(this.tbCustomerName);
            this.gbFiltering.Controls.Add(this.lbCustomerName);
            this.gbFiltering.Location = new System.Drawing.Point(13, 290);
            this.gbFiltering.Name = "gbFiltering";
            this.gbFiltering.Size = new System.Drawing.Size(566, 64);
            this.gbFiltering.TabIndex = 2;
            this.gbFiltering.TabStop = false;
            this.gbFiltering.Text = "Filtering";
            this.gbFiltering.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(485, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbCountries
            // 
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Items.AddRange(new object[] {
            "All"});
            this.cbCountries.Location = new System.Drawing.Point(300, 37);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(121, 21);
            this.cbCountries.TabIndex = 5;
            // 
            // cbContactTitles
            // 
            this.cbContactTitles.FormattingEnabled = true;
            this.cbContactTitles.Items.AddRange(new object[] {
            "All"});
            this.cbContactTitles.Location = new System.Drawing.Point(138, 37);
            this.cbContactTitles.Name = "cbContactTitles";
            this.cbContactTitles.Size = new System.Drawing.Size(121, 21);
            this.cbContactTitles.TabIndex = 4;
            // 
            // lbCountries
            // 
            this.lbCountries.AutoSize = true;
            this.lbCountries.Location = new System.Drawing.Point(297, 20);
            this.lbCountries.Name = "lbCountries";
            this.lbCountries.Size = new System.Drawing.Size(43, 13);
            this.lbCountries.TabIndex = 3;
            this.lbCountries.Text = "Country";
            // 
            // lbContactTitles
            // 
            this.lbContactTitles.AutoSize = true;
            this.lbContactTitles.Location = new System.Drawing.Point(146, 20);
            this.lbContactTitles.Name = "lbContactTitles";
            this.lbContactTitles.Size = new System.Drawing.Size(27, 13);
            this.lbContactTitles.TabIndex = 2;
            this.lbContactTitles.Text = "Title";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(10, 38);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(7, 20);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 368);
            this.Controls.Add(this.gbFiltering);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbFiltering.ResumeLayout(false);
            this.gbFiltering.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.GroupBox gbFiltering;
        private System.Windows.Forms.Label lbContactTitles;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.ComboBox cbContactTitles;
        private System.Windows.Forms.Label lbCountries;
        private System.Windows.Forms.Button btnRefresh;
    }
}

