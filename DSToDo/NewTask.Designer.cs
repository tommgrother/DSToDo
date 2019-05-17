namespace DSToDo
{
    partial class NewTask
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTask));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.dteDueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbSetForID = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_infoDataSet = new DSToDo.user_infoDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.userTableAdapter = new DSToDo.user_infoDataSetTableAdapters.userTableAdapter();
            this.user_infoDataSet1 = new DSToDo.user_infoDataSet();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task For:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priority:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Task Detail:";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(15, 118);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(621, 188);
            this.txtDetail.TabIndex = 4;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(72, 72);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(200, 21);
            this.cmbPriority.TabIndex = 5;
            // 
            // dteDueDate
            // 
            this.dteDueDate.Location = new System.Drawing.Point(72, 48);
            this.dteDueDate.Name = "dteDueDate";
            this.dteDueDate.Size = new System.Drawing.Size(200, 20);
            this.dteDueDate.TabIndex = 6;
            // 
            // cmbSetForID
            // 
            this.cmbSetForID.DataSource = this.userBindingSource1;
            this.cmbSetForID.DisplayMember = "forename";
            this.cmbSetForID.FormattingEnabled = true;
            this.cmbSetForID.Location = new System.Drawing.Point(72, 21);
            this.cmbSetForID.Name = "cmbSetForID";
            this.cmbSetForID.Size = new System.Drawing.Size(200, 21);
            this.cmbSetForID.TabIndex = 7;
            this.cmbSetForID.ValueMember = "id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.user_infoDataSet;
            // 
            // user_infoDataSet
            // 
            this.user_infoDataSet.DataSetName = "user_infoDataSet";
            this.user_infoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(561, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // user_infoDataSet1
            // 
            this.user_infoDataSet1.DataSetName = "user_infoDataSet";
            this.user_infoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.user_infoDataSet1;
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 355);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbSetForID);
            this.Controls.Add(this.dteDueDate);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTask";
            this.Text = "New Task";
            this.Load += new System.EventHandler(this.NewTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.DateTimePicker dteDueDate;
        private System.Windows.Forms.ComboBox cmbSetForID;
        private System.Windows.Forms.Button btnSave;
        private user_infoDataSet user_infoDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private user_infoDataSetTableAdapters.userTableAdapter userTableAdapter;
        private user_infoDataSet user_infoDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource1;
    }
}