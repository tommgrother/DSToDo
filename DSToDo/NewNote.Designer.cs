namespace DSToDo
{
    partial class NewNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewNote));
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveNote = new System.Windows.Forms.Button();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.cmbEmail = new System.Windows.Forms.ComboBox();
            this.user_infoDataSet2 = new DSToDo.user_infoDataSet2();
            this.viewcurrentuserswithemailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_current_users_with_emailTableAdapter = new DSToDo.user_infoDataSet2TableAdapters.view_current_users_with_emailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcurrentuserswithemailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(13, 31);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(465, 171);
            this.txtNote.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Note Detail:";
            // 
            // btnSaveNote
            // 
            this.btnSaveNote.Location = new System.Drawing.Point(403, 252);
            this.btnSaveNote.Name = "btnSaveNote";
            this.btnSaveNote.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNote.TabIndex = 2;
            this.btnSaveNote.Text = "Save Note";
            this.btnSaveNote.UseVisualStyleBackColor = true;
            this.btnSaveNote.Click += new System.EventHandler(this.btnSaveNote_Click);
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(13, 208);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(117, 17);
            this.chkEmail.TabIndex = 3;
            this.chkEmail.Text = "Send Note In Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            //this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // cmbEmail
            // 
            this.cmbEmail.DataSource = this.viewcurrentuserswithemailBindingSource;
            this.cmbEmail.DisplayMember = "FullName";
            this.cmbEmail.FormattingEnabled = true;
            this.cmbEmail.Location = new System.Drawing.Point(137, 208);
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.Size = new System.Drawing.Size(341, 21);
            this.cmbEmail.TabIndex = 4;
            this.cmbEmail.ValueMember = "id";
            // 
            // user_infoDataSet2
            // 
            this.user_infoDataSet2.DataSetName = "user_infoDataSet2";
            this.user_infoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewcurrentuserswithemailBindingSource
            // 
            this.viewcurrentuserswithemailBindingSource.DataMember = "view_current_users_with_email";
            this.viewcurrentuserswithemailBindingSource.DataSource = this.user_infoDataSet2;
            // 
            // view_current_users_with_emailTableAdapter
            // 
            this.view_current_users_with_emailTableAdapter.ClearBeforeFill = true;
            // 
            // NewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 301);
            this.Controls.Add(this.cmbEmail);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.btnSaveNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewNote";
            this.Text = "New Note";
            this.Load += new System.EventHandler(this.NewNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_infoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewcurrentuserswithemailBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveNote;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.ComboBox cmbEmail;
        private user_infoDataSet2 user_infoDataSet2;
        private System.Windows.Forms.BindingSource viewcurrentuserswithemailBindingSource;
        private user_infoDataSet2TableAdapters.view_current_users_with_emailTableAdapter view_current_users_with_emailTableAdapter;
    }
}