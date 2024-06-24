namespace YourNamespace
{
    partial class ArchiveForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.archiveListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // archiveListBox
            // 
            this.archiveListBox.FormattingEnabled = true;
            this.archiveListBox.Location = new System.Drawing.Point(12, 12);
            this.archiveListBox.Name = "archiveListBox";
            this.archiveListBox.Size = new System.Drawing.Size(360, 238);
            this.archiveListBox.TabIndex = 0;
            // 
            // ArchiveForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.archiveListBox);
            this.Name = "ArchiveForm";
            this.Text = "Crime Record Archive";
            this.Load += new System.EventHandler(this.ArchiveForm_Load);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox archiveListBox;
    }
}
