namespace Project
{
    partial class frmStudentRecords
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
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnUpdateSInfo = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateDGV = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutStudents = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblOutAAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFirstRecord = new System.Windows.Forms.Button();
            this.btnLastRecord = new System.Windows.Forms.Button();
            this.btnNextRecord = new System.Windows.Forms.Button();
            this.btnPrevRecord = new System.Windows.Forms.Button();
            this.btnAllStudents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(40, 131);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.Size = new System.Drawing.Size(568, 401);
            this.dgvStudents.TabIndex = 0;
            // 
            // btnUpdateSInfo
            // 
            this.btnUpdateSInfo.Location = new System.Drawing.Point(856, 177);
            this.btnUpdateSInfo.Name = "btnUpdateSInfo";
            this.btnUpdateSInfo.Size = new System.Drawing.Size(170, 40);
            this.btnUpdateSInfo.TabIndex = 1;
            this.btnUpdateSInfo.Text = "Update Student Information";
            this.btnUpdateSInfo.UseVisualStyleBackColor = true;
            this.btnUpdateSInfo.Click += new System.EventHandler(this.btnUpdateSInfo_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(856, 223);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(170, 40);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Delete a Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(856, 131);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(170, 40);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add a Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateDGV
            // 
            this.btnUpdateDGV.Location = new System.Drawing.Point(856, 315);
            this.btnUpdateDGV.Name = "btnUpdateDGV";
            this.btnUpdateDGV.Size = new System.Drawing.Size(170, 40);
            this.btnUpdateDGV.TabIndex = 4;
            this.btnUpdateDGV.Text = "Update DGV";
            this.btnUpdateDGV.UseVisualStyleBackColor = true;
            this.btnUpdateDGV.Click += new System.EventHandler(this.btnUpdateDGV_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(856, 269);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(170, 40);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Generate a summary report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(727, 396);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total number of student";
            // 
            // lblOutStudents
            // 
            this.lblOutStudents.AutoSize = true;
            this.lblOutStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutStudents.Location = new System.Drawing.Point(852, 384);
            this.lblOutStudents.Name = "lblOutStudents";
            this.lblOutStudents.Size = new System.Drawing.Size(177, 39);
            this.lblOutStudents.TabIndex = 7;
            this.lblOutStudents.Text = "OStudents";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Location = new System.Drawing.Point(727, 456);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(126, 13);
            this.lblAverageAge.TabIndex = 8;
            this.lblAverageAge.Text = "Average Age of Students";
            // 
            // lblOutAAge
            // 
            this.lblOutAAge.AutoSize = true;
            this.lblOutAAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutAAge.Location = new System.Drawing.Point(859, 435);
            this.lblOutAAge.Name = "lblOutAAge";
            this.lblOutAAge.Size = new System.Drawing.Size(231, 39);
            this.lblOutAAge.TabIndex = 9;
            this.lblOutAAge.Text = "OAverageAge";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(261, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Marco";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(457, 57);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(151, 20);
            this.txtAge.TabIndex = 12;
            this.txtAge.Text = "20";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(658, 57);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(151, 20);
            this.txtCourse.TabIndex = 13;
            this.txtCourse.Text = "BCOMP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Course:";
            // 
            // btnFirstRecord
            // 
            this.btnFirstRecord.Location = new System.Drawing.Point(40, 548);
            this.btnFirstRecord.Name = "btnFirstRecord";
            this.btnFirstRecord.Size = new System.Drawing.Size(75, 23);
            this.btnFirstRecord.TabIndex = 18;
            this.btnFirstRecord.Text = "|<";
            this.btnFirstRecord.UseVisualStyleBackColor = true;
            this.btnFirstRecord.Click += new System.EventHandler(this.btnFirstRecord_Click);
            // 
            // btnLastRecord
            // 
            this.btnLastRecord.Location = new System.Drawing.Point(410, 548);
            this.btnLastRecord.Name = "btnLastRecord";
            this.btnLastRecord.Size = new System.Drawing.Size(75, 23);
            this.btnLastRecord.TabIndex = 19;
            this.btnLastRecord.Text = ">|";
            this.btnLastRecord.UseVisualStyleBackColor = true;
            this.btnLastRecord.Click += new System.EventHandler(this.btnLastRecord_Click);
            // 
            // btnNextRecord
            // 
            this.btnNextRecord.Location = new System.Drawing.Point(279, 548);
            this.btnNextRecord.Name = "btnNextRecord";
            this.btnNextRecord.Size = new System.Drawing.Size(75, 23);
            this.btnNextRecord.TabIndex = 20;
            this.btnNextRecord.Text = ">";
            this.btnNextRecord.UseVisualStyleBackColor = true;
            this.btnNextRecord.Click += new System.EventHandler(this.btnNextRecord_Click);
            // 
            // btnPrevRecord
            // 
            this.btnPrevRecord.Location = new System.Drawing.Point(167, 548);
            this.btnPrevRecord.Name = "btnPrevRecord";
            this.btnPrevRecord.Size = new System.Drawing.Size(75, 23);
            this.btnPrevRecord.TabIndex = 21;
            this.btnPrevRecord.Text = "<";
            this.btnPrevRecord.UseVisualStyleBackColor = true;
            this.btnPrevRecord.Click += new System.EventHandler(this.btnPrevRecord_Click);
            // 
            // btnAllStudents
            // 
            this.btnAllStudents.Location = new System.Drawing.Point(859, 89);
            this.btnAllStudents.Name = "btnAllStudents";
            this.btnAllStudents.Size = new System.Drawing.Size(166, 36);
            this.btnAllStudents.TabIndex = 22;
            this.btnAllStudents.Text = "View all students";
            this.btnAllStudents.UseVisualStyleBackColor = true;
            this.btnAllStudents.Click += new System.EventHandler(this.btnAllStudents_Click);
            // 
            // frmStudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 681);
            this.Controls.Add(this.btnAllStudents);
            this.Controls.Add(this.btnPrevRecord);
            this.Controls.Add(this.btnNextRecord);
            this.Controls.Add(this.btnLastRecord);
            this.Controls.Add(this.btnFirstRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblOutAAge);
            this.Controls.Add(this.lblAverageAge);
            this.Controls.Add(this.lblOutStudents);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnUpdateDGV);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateSInfo);
            this.Controls.Add(this.dgvStudents);
            this.Name = "frmStudentRecords";
            this.Text = "Student Records";
            this.Load += new System.EventHandler(this.frmStudentRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnUpdateSInfo;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateDGV;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutStudents;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblOutAAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFirstRecord;
        private System.Windows.Forms.Button btnLastRecord;
        private System.Windows.Forms.Button btnNextRecord;
        private System.Windows.Forms.Button btnPrevRecord;
        private System.Windows.Forms.Button btnAllStudents;
    }
}

