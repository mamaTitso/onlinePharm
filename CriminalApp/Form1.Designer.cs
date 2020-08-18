namespace CriminalApp
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
            this.wellcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.symtompsList = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstData = new System.Windows.Forms.ListBox();
            this.selectedItem = new System.Windows.Forms.Label();
            this.medicineLabel = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.recommendDoc = new System.Windows.Forms.Label();
            this.cmbSymptoms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSymptoms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // wellcome
            // 
            this.wellcome.AutoSize = true;
            this.wellcome.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wellcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wellcome.Location = new System.Drawing.Point(10, 0);
            this.wellcome.Name = "wellcome";
            this.wellcome.Size = new System.Drawing.Size(285, 54);
            this.wellcome.TabIndex = 0;
            this.wellcome.Text = "PHARMACY";
            this.wellcome.Click += new System.EventHandler(this.wellcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "at your fingertips\r\n\r\n";
            // 
            // symtompsList
            // 
            this.symtompsList.FormattingEnabled = true;
            this.symtompsList.Location = new System.Drawing.Point(202, 254);
            this.symtompsList.Name = "symtompsList";
            this.symtompsList.Size = new System.Drawing.Size(135, 147);
            this.symtompsList.TabIndex = 2;
            this.symtompsList.SelectedIndexChanged += new System.EventHandler(this.symtompsList_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(138, 194);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(-2, 321);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(120, 43);
            this.lstData.TabIndex = 4;
            this.lstData.Visible = false;
            // 
            // selectedItem
            // 
            this.selectedItem.AutoSize = true;
            this.selectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedItem.Location = new System.Drawing.Point(10, 220);
            this.selectedItem.Name = "selectedItem";
            this.selectedItem.Size = new System.Drawing.Size(151, 29);
            this.selectedItem.TabIndex = 5;
            this.selectedItem.Text = "selectedItem";
            this.selectedItem.UseWaitCursor = true;
            // 
            // medicineLabel
            // 
            this.medicineLabel.AutoSize = true;
            this.medicineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineLabel.Location = new System.Drawing.Point(383, 194);
            this.medicineLabel.Name = "medicineLabel";
            this.medicineLabel.Size = new System.Drawing.Size(88, 24);
            this.medicineLabel.TabIndex = 6;
            this.medicineLabel.Text = "medicine";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(450, 318);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(39, 23);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(511, 318);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(39, 23);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "NO";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // recommendDoc
            // 
            this.recommendDoc.AutoSize = true;
            this.recommendDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendDoc.Location = new System.Drawing.Point(-6, 318);
            this.recommendDoc.Name = "recommendDoc";
            this.recommendDoc.Size = new System.Drawing.Size(51, 20);
            this.recommendDoc.TabIndex = 9;
            this.recommendDoc.Text = "label2";
            // 
            // cmbSymptoms
            // 
            this.cmbSymptoms.FormattingEnabled = true;
            this.cmbSymptoms.Location = new System.Drawing.Point(202, 105);
            this.cmbSymptoms.Name = "cmbSymptoms";
            this.cmbSymptoms.Size = new System.Drawing.Size(121, 21);
            this.cmbSymptoms.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "SELECT YOUR SYMPTOMPS";
            // 
            // lstSymptoms
            // 
            this.lstSymptoms.FormattingEnabled = true;
            this.lstSymptoms.Location = new System.Drawing.Point(12, 125);
            this.lstSymptoms.Name = "lstSymptoms";
            this.lstSymptoms.Size = new System.Drawing.Size(120, 95);
            this.lstSymptoms.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 396);
            this.Controls.Add(this.lstSymptoms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSymptoms);
            this.Controls.Add(this.recommendDoc);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.medicineLabel);
            this.Controls.Add(this.selectedItem);
            this.Controls.Add(this.lstData);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.symtompsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wellcome);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wellcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox symtompsList;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.Label selectedItem;
        private System.Windows.Forms.Label medicineLabel;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label recommendDoc;
        private System.Windows.Forms.ComboBox cmbSymptoms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSymptoms;
    }
}

