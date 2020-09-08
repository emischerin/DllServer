namespace DllServer
{
    partial class ServerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStrip});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(800, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // FileStrip
            // 
            this.FileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskManagerMenuItem,
            this.AddDllMenuItem});
            this.FileStrip.Name = "FileStrip";
            this.FileStrip.Size = new System.Drawing.Size(37, 20);
            this.FileStrip.Text = "File";
            // 
            // TaskManagerMenuItem
            // 
            this.TaskManagerMenuItem.Name = "TaskManagerMenuItem";
            this.TaskManagerMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TaskManagerMenuItem.Text = "TaskManager";
            this.TaskManagerMenuItem.Click += new System.EventHandler(this.TaskManagerMenuItem_Click);
            // 
            // AddDllMenuItem
            // 
            this.AddDllMenuItem.Name = "AddDllMenuItem";
            this.AddDllMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddDllMenuItem.Text = "Add Dll";
            this.AddDllMenuItem.Click += new System.EventHandler(this.AddDllMenuItem_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "ServerForm";
            this.ShowIcon = false;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileStrip;
        private System.Windows.Forms.ToolStripMenuItem TaskManagerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDllMenuItem;
    }
}

