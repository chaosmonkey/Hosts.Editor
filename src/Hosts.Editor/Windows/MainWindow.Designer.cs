namespace Hosts.Editor.Windows
{
    partial class MainWindow
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.Bindings = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bindings)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(584, 40);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenMenuItem,
            this.FileSaveMenuItem,
            this.FileSaveAsMenuItem,
            this.FileSeperator1,
            this.FileExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(64, 36);
            this.FileMenuItem.Text = "&File";
            this.FileMenuItem.DropDownOpened += new System.EventHandler(this.MainMenu_DropDownOpened);
            // 
            // FileOpenMenuItem
            // 
            this.FileOpenMenuItem.Name = "FileOpenMenuItem";
            this.FileOpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileOpenMenuItem.Size = new System.Drawing.Size(364, 38);
            this.FileOpenMenuItem.Text = "&Open ...";
            this.FileOpenMenuItem.Visible = false;
            // 
            // FileSaveMenuItem
            // 
            this.FileSaveMenuItem.Name = "FileSaveMenuItem";
            this.FileSaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileSaveMenuItem.Size = new System.Drawing.Size(364, 38);
            this.FileSaveMenuItem.Text = "&Save";
            this.FileSaveMenuItem.Click += new System.EventHandler(this.FileSaveMenuItem_Click);
            // 
            // FileSaveAsMenuItem
            // 
            this.FileSaveAsMenuItem.Name = "FileSaveAsMenuItem";
            this.FileSaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.FileSaveAsMenuItem.Size = new System.Drawing.Size(364, 38);
            this.FileSaveAsMenuItem.Text = "Save &As ...";
            this.FileSaveAsMenuItem.Visible = false;
            // 
            // FileSeperator1
            // 
            this.FileSeperator1.Name = "FileSeperator1";
            this.FileSeperator1.Size = new System.Drawing.Size(361, 6);
            // 
            // FileExitMenuItem
            // 
            this.FileExitMenuItem.Name = "FileExitMenuItem";
            this.FileExitMenuItem.Size = new System.Drawing.Size(364, 38);
            this.FileExitMenuItem.Text = "E&xit";
            // 
            // StatusBar
            // 
            this.StatusBar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StatusBar.Location = new System.Drawing.Point(0, 639);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(584, 22);
            this.StatusBar.TabIndex = 1;
            this.StatusBar.Text = "statusStrip1";
            this.StatusBar.Visible = false;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.AcceptsReturn = true;
            this.ContentTextBox.AcceptsTab = true;
            this.ContentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ContentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Bindings, "Content", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentTextBox.Location = new System.Drawing.Point(0, 40);
            this.ContentTextBox.Multiline = true;
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ContentTextBox.Size = new System.Drawing.Size(584, 621);
            this.ContentTextBox.TabIndex = 2;
            this.ContentTextBox.WordWrap = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 661);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.Bindings, "WindowText", true));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MainMenu;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hosts Editor";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bindings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileSeperator1;
        private System.Windows.Forms.ToolStripMenuItem FileExitMenuItem;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.BindingSource Bindings;
    }
}

