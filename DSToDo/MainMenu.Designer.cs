namespace DSToDo
{
    partial class MainMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.dgTasks = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailOutstandingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOutstandingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outstandingByPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTasks = new System.Windows.Forms.TabControl();
            this.forMe = new System.Windows.Forms.TabPage();
            this.chkShowCompletes = new System.Windows.Forms.CheckBox();
            this.byMe = new System.Windows.Forms.TabPage();
            this.dgTasksSent = new System.Windows.Forms.DataGridView();
            this.chkShowCompletesSent = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTasks)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.tabTasks.SuspendLayout();
            this.forMe.SuspendLayout();
            this.byMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTasksSent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTasks
            // 
            this.dgTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTasks.Location = new System.Drawing.Point(6, 38);
            this.dgTasks.MultiSelect = false;
            this.dgTasks.Name = "dgTasks";
            this.dgTasks.RowHeadersVisible = false;
            this.dgTasks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgTasks.RowTemplate.ReadOnly = true;
            this.dgTasks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTasks.Size = new System.Drawing.Size(1093, 523);
            this.dgTasks.TabIndex = 0;
            this.dgTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTasks_CellDoubleClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.refreshListToolStripMenuItem,
            this.emailOutstandingToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.newTaskToolStripMenuItem.Text = "New Task";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.refreshListToolStripMenuItem_Click);
            // 
            // emailOutstandingToolStripMenuItem
            // 
            this.emailOutstandingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allOutstandingToolStripMenuItem,
            this.outstandingByPersonToolStripMenuItem});
            this.emailOutstandingToolStripMenuItem.Name = "emailOutstandingToolStripMenuItem";
            this.emailOutstandingToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.emailOutstandingToolStripMenuItem.Text = "Email Outstanding";
            // 
            // allOutstandingToolStripMenuItem
            // 
            this.allOutstandingToolStripMenuItem.Name = "allOutstandingToolStripMenuItem";
            this.allOutstandingToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.allOutstandingToolStripMenuItem.Text = "All Outstanding";
            this.allOutstandingToolStripMenuItem.Click += new System.EventHandler(this.allOutstandingToolStripMenuItem_Click);
            // 
            // outstandingByPersonToolStripMenuItem
            // 
            this.outstandingByPersonToolStripMenuItem.Name = "outstandingByPersonToolStripMenuItem";
            this.outstandingByPersonToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.outstandingByPersonToolStripMenuItem.Text = "Outstanding By Person";
            // 
            // tabTasks
            // 
            this.tabTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabTasks.Controls.Add(this.forMe);
            this.tabTasks.Controls.Add(this.byMe);
            this.tabTasks.Location = new System.Drawing.Point(12, 27);
            this.tabTasks.Name = "tabTasks";
            this.tabTasks.SelectedIndex = 0;
            this.tabTasks.Size = new System.Drawing.Size(1446, 667);
            this.tabTasks.TabIndex = 3;
            // 
            // forMe
            // 
            this.forMe.Controls.Add(this.chkShowCompletes);
            this.forMe.Controls.Add(this.dgTasks);
            this.forMe.Location = new System.Drawing.Point(4, 22);
            this.forMe.Name = "forMe";
            this.forMe.Padding = new System.Windows.Forms.Padding(3);
            this.forMe.Size = new System.Drawing.Size(1438, 641);
            this.forMe.TabIndex = 0;
            this.forMe.Text = "Tasks For Me";
            this.forMe.UseVisualStyleBackColor = true;
            // 
            // chkShowCompletes
            // 
            this.chkShowCompletes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowCompletes.AutoSize = true;
            this.chkShowCompletes.Location = new System.Drawing.Point(994, 15);
            this.chkShowCompletes.Name = "chkShowCompletes";
            this.chkShowCompletes.Size = new System.Drawing.Size(105, 17);
            this.chkShowCompletes.TabIndex = 1;
            this.chkShowCompletes.Text = "Show Completes";
            this.chkShowCompletes.UseVisualStyleBackColor = true;
            this.chkShowCompletes.CheckedChanged += new System.EventHandler(this.chkShowCompletes_CheckedChanged);
            // 
            // byMe
            // 
            this.byMe.Controls.Add(this.chkShowCompletesSent);
            this.byMe.Controls.Add(this.dgTasksSent);
            this.byMe.Location = new System.Drawing.Point(4, 22);
            this.byMe.Name = "byMe";
            this.byMe.Padding = new System.Windows.Forms.Padding(3);
            this.byMe.Size = new System.Drawing.Size(1438, 641);
            this.byMe.TabIndex = 1;
            this.byMe.Text = "Tasks By Me";
            this.byMe.UseVisualStyleBackColor = true;
            // 
            // dgTasksSent
            // 
            this.dgTasksSent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTasksSent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTasksSent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTasksSent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTasksSent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTasksSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTasksSent.Location = new System.Drawing.Point(6, 37);
            this.dgTasksSent.MultiSelect = false;
            this.dgTasksSent.Name = "dgTasksSent";
            this.dgTasksSent.RowHeadersVisible = false;
            this.dgTasksSent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgTasksSent.RowTemplate.ReadOnly = true;
            this.dgTasksSent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTasksSent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTasksSent.Size = new System.Drawing.Size(1093, 525);
            this.dgTasksSent.TabIndex = 1;
            // 
            // chkShowCompletesSent
            // 
            this.chkShowCompletesSent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowCompletesSent.AutoSize = true;
            this.chkShowCompletesSent.Location = new System.Drawing.Point(994, 14);
            this.chkShowCompletesSent.Name = "chkShowCompletesSent";
            this.chkShowCompletesSent.Size = new System.Drawing.Size(105, 17);
            this.chkShowCompletesSent.TabIndex = 2;
            this.chkShowCompletesSent.Text = "Show Completes";
            this.chkShowCompletesSent.UseVisualStyleBackColor = true;
            this.chkShowCompletesSent.CheckedChanged += new System.EventHandler(this.chkShowCompletesSent_CheckedChanged);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 613);
            this.Controls.Add(this.tabTasks);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "DSToDo";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTasks)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabTasks.ResumeLayout(false);
            this.forMe.ResumeLayout(false);
            this.forMe.PerformLayout();
            this.byMe.ResumeLayout(false);
            this.byMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTasksSent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTasks;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTasks;
        private System.Windows.Forms.TabPage forMe;
        private System.Windows.Forms.TabPage byMe;
        private System.Windows.Forms.DataGridView dgTasksSent;
        private System.Windows.Forms.CheckBox chkShowCompletes;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailOutstandingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOutstandingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outstandingByPersonToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkShowCompletesSent;
    }
}

