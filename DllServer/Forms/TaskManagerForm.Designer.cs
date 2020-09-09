namespace DllServer.Forms
{
    partial class TaskManagerForm
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
            this.AwaitingDlls_DataGrid = new System.Windows.Forms.DataGridView();
            this.AwaitingDlls_label = new System.Windows.Forms.Label();
            this.RunningDlls_DataGrid = new System.Windows.Forms.DataGridView();
            this.RunningDlls_label = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningDllsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwaitingDllsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StartDllButton = new System.Windows.Forms.Button();
            this.StopDllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AwaitingDlls_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningDlls_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningDllsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AwaitingDllsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AwaitingDlls_DataGrid
            // 
            this.AwaitingDlls_DataGrid.AutoGenerateColumns = false;
            this.AwaitingDlls_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AwaitingDlls_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AwaitingDlls_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.pathDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn1});
            this.AwaitingDlls_DataGrid.DataMember = "AwaitingDlls_data_source";
            this.AwaitingDlls_DataGrid.DataSource = this.AwaitingDllsBindingSource;
            this.AwaitingDlls_DataGrid.Location = new System.Drawing.Point(12, 30);
            this.AwaitingDlls_DataGrid.MultiSelect = false;
            this.AwaitingDlls_DataGrid.Name = "AwaitingDlls_DataGrid";
            this.AwaitingDlls_DataGrid.Size = new System.Drawing.Size(269, 314);
            this.AwaitingDlls_DataGrid.TabIndex = 0;
            // 
            // AwaitingDlls_label
            // 
            this.AwaitingDlls_label.AutoSize = true;
            this.AwaitingDlls_label.Location = new System.Drawing.Point(13, 11);
            this.AwaitingDlls_label.Name = "AwaitingDlls_label";
            this.AwaitingDlls_label.Size = new System.Drawing.Size(64, 13);
            this.AwaitingDlls_label.TabIndex = 1;
            this.AwaitingDlls_label.Text = "AwaitingDlls";
            // 
            // RunningDlls_DataGrid
            // 
            this.RunningDlls_DataGrid.AutoGenerateColumns = false;
            this.RunningDlls_DataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RunningDlls_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RunningDlls_DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn});
            this.RunningDlls_DataGrid.DataMember = "AwaitingDlls_data_source";
            this.RunningDlls_DataGrid.DataSource = this.RunningDllsBindingSource;
            this.RunningDlls_DataGrid.Location = new System.Drawing.Point(501, 30);
            this.RunningDlls_DataGrid.MultiSelect = false;
            this.RunningDlls_DataGrid.Name = "RunningDlls_DataGrid";
            this.RunningDlls_DataGrid.Size = new System.Drawing.Size(287, 314);
            this.RunningDlls_DataGrid.TabIndex = 2;
            // 
            // RunningDlls_label
            // 
            this.RunningDlls_label.AutoSize = true;
            this.RunningDlls_label.Location = new System.Drawing.Point(498, 11);
            this.RunningDlls_label.Name = "RunningDlls_label";
            this.RunningDlls_label.Size = new System.Drawing.Size(64, 13);
            this.RunningDlls_label.TabIndex = 3;
            this.RunningDlls_label.Text = "RunningDlls";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // RunningDllsBindingSource
            // 
            this.RunningDllsBindingSource.DataSource = typeof(DllServer.DllExecutor);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // pathDataGridViewTextBoxColumn1
            // 
            this.pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn1.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
            // 
            // startTimeDataGridViewTextBoxColumn1
            // 
            this.startTimeDataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn1.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn1.Name = "startTimeDataGridViewTextBoxColumn1";
            // 
            // AwaitingDllsBindingSource
            // 
            this.AwaitingDllsBindingSource.DataSource = typeof(DllServer.DllExecutor);
            // 
            // StartDllButton
            // 
            this.StartDllButton.Location = new System.Drawing.Point(16, 374);
            this.StartDllButton.Name = "StartDllButton";
            this.StartDllButton.Size = new System.Drawing.Size(75, 23);
            this.StartDllButton.TabIndex = 4;
            this.StartDllButton.Text = "StartDll";
            this.StartDllButton.UseVisualStyleBackColor = true;
            this.StartDllButton.Click += new System.EventHandler(this.StartDllButton_Click);
            // 
            // StopDllButton
            // 
            this.StopDllButton.Location = new System.Drawing.Point(501, 374);
            this.StopDllButton.Name = "StopDllButton";
            this.StopDllButton.Size = new System.Drawing.Size(75, 23);
            this.StopDllButton.TabIndex = 5;
            this.StopDllButton.Text = "StopDll";
            this.StopDllButton.UseVisualStyleBackColor = true;
            this.StopDllButton.Click += new System.EventHandler(this.StopDllButton_Click);
            // 
            // TaskManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopDllButton);
            this.Controls.Add(this.StartDllButton);
            this.Controls.Add(this.RunningDlls_label);
            this.Controls.Add(this.RunningDlls_DataGrid);
            this.Controls.Add(this.AwaitingDlls_label);
            this.Controls.Add(this.AwaitingDlls_DataGrid);
            this.Name = "TaskManagerForm";
            this.ShowIcon = false;
            this.Text = "TaskManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.AwaitingDlls_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningDlls_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningDllsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AwaitingDllsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AwaitingDlls_DataGrid;
        private System.Windows.Forms.Label AwaitingDlls_label;
        private System.Windows.Forms.BindingSource AwaitingDllsBindingSource;
        private System.Windows.Forms.DataGridView RunningDlls_DataGrid;
        private System.Windows.Forms.Label RunningDlls_label;
        private System.Windows.Forms.BindingSource RunningDllsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button StartDllButton;
        private System.Windows.Forms.Button StopDllButton;
    }
}