namespace EntityFrameworkQueries
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectAllVendors = new System.Windows.Forms.Button();
            this.btnAllCaliVendors = new System.Windows.Forms.Button();
            this.btnSelectSpecificColumns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectAllVendors
            // 
            this.btnSelectAllVendors.Location = new System.Drawing.Point(60, 51);
            this.btnSelectAllVendors.Name = "btnSelectAllVendors";
            this.btnSelectAllVendors.Size = new System.Drawing.Size(274, 34);
            this.btnSelectAllVendors.TabIndex = 0;
            this.btnSelectAllVendors.Text = "Select * FROM Vendors";
            this.btnSelectAllVendors.UseVisualStyleBackColor = true;
            this.btnSelectAllVendors.Click += new System.EventHandler(this.btnSelectAllVendors_Click);
            // 
            // btnAllCaliVendors
            // 
            this.btnAllCaliVendors.Location = new System.Drawing.Point(60, 101);
            this.btnAllCaliVendors.Name = "btnAllCaliVendors";
            this.btnAllCaliVendors.Size = new System.Drawing.Size(274, 142);
            this.btnAllCaliVendors.TabIndex = 1;
            this.btnAllCaliVendors.Text = "SELECT * \r\nFROM Vendors \r\nWHERE VendorState=\'CA\' \r\nORDER BY VendorNameASC";
            this.btnAllCaliVendors.UseVisualStyleBackColor = true;
            this.btnAllCaliVendors.Click += new System.EventHandler(this.btnAllCaliVendors_Click);
            // 
            // btnSelectSpecificColumns
            // 
            this.btnSelectSpecificColumns.Location = new System.Drawing.Point(60, 249);
            this.btnSelectSpecificColumns.Name = "btnSelectSpecificColumns";
            this.btnSelectSpecificColumns.Size = new System.Drawing.Size(274, 198);
            this.btnSelectSpecificColumns.TabIndex = 2;
            this.btnSelectSpecificColumns.Text = "SELECT VendroName, \r\nVendorCity, \r\nVendorState \r\nFROM Vendors";
            this.btnSelectSpecificColumns.UseVisualStyleBackColor = true;
            this.btnSelectSpecificColumns.Click += new System.EventHandler(this.btnSelectSpecificColumns_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 629);
            this.Controls.Add(this.btnSelectSpecificColumns);
            this.Controls.Add(this.btnAllCaliVendors);
            this.Controls.Add(this.btnSelectAllVendors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSelectAllVendors;
        private Button btnAllCaliVendors;
        private Button btnSelectSpecificColumns;
    }
}