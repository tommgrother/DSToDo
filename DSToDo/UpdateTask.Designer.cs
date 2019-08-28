namespace DSToDo
{
    partial class UpdateTask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTask));
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgNotes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.btnDeligate = new System.Windows.Forms.Button();
            this.chkNotification = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dteDueDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Task Subject.";
            // 
            // txtSubject
            // 
            this.txtSubject.Enabled = false;
            this.txtSubject.Location = new System.Drawing.Point(12, 110);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(621, 20);
            this.txtSubject.TabIndex = 13;
            // 
            // txtDetail
            // 
            this.txtDetail.Enabled = false;
            this.txtDetail.Location = new System.Drawing.Point(12, 149);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(621, 188);
            this.txtDetail.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Task Detail:";
            // 
            // dgNotes
            // 
            this.dgNotes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNotes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgNotes.Location = new System.Drawing.Point(12, 378);
            this.dgNotes.Name = "dgNotes";
            this.dgNotes.RowHeadersVisible = false;
            this.dgNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNotes.Size = new System.Drawing.Size(621, 150);
            this.dgNotes.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Task Notes";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Complete"});
            this.cmbStatus.Location = new System.Drawing.Point(512, 545);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Task Status:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(558, 581);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(593, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.Location = new System.Drawing.Point(12, 13);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(75, 20);
            this.lblTaskID.TabIndex = 21;
            this.lblTaskID.Text = "lblTaskID";
            // 
            // btnDeligate
            // 
            this.btnDeligate.Location = new System.Drawing.Point(542, 13);
            this.btnDeligate.Name = "btnDeligate";
            this.btnDeligate.Size = new System.Drawing.Size(91, 23);
            this.btnDeligate.TabIndex = 22;
            this.btnDeligate.Text = "Deligate Task";
            this.btnDeligate.UseVisualStyleBackColor = true;
            // 
            // chkNotification
            // 
            this.chkNotification.AutoSize = true;
            this.chkNotification.Location = new System.Drawing.Point(438, 355);
            this.chkNotification.Name = "chkNotification";
            this.chkNotification.Size = new System.Drawing.Size(149, 17);
            this.chkNotification.TabIndex = 23;
            this.chkNotification.Text = "Email notification for notes";
            this.chkNotification.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Task Due:";
            // 
            // dteDueDate
            // 
            this.dteDueDate.Location = new System.Drawing.Point(12, 61);
            this.dteDueDate.Name = "dteDueDate";
            this.dteDueDate.Size = new System.Drawing.Size(139, 20);
            this.dteDueDate.TabIndex = 25;
            // 
            // UpdateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 605);
            this.Controls.Add(this.dteDueDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkNotification);
            this.Controls.Add(this.btnDeligate);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Task";
            this.Load += new System.EventHandler(this.UpdateTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Button btnDeligate;
        private System.Windows.Forms.CheckBox chkNotification;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dteDueDate;
    }
}