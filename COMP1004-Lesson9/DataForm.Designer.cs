namespace COMP1004_Lesson9
{
    partial class DataForm
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
            this.FirstNameListBox = new System.Windows.Forms.ListBox();
            this.FirstNaneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameListBox
            // 
            this.FirstNameListBox.FormattingEnabled = true;
            this.FirstNameListBox.ItemHeight = 24;
            this.FirstNameListBox.Location = new System.Drawing.Point(49, 122);
            this.FirstNameListBox.Name = "FirstNameListBox";
            this.FirstNameListBox.Size = new System.Drawing.Size(235, 148);
            this.FirstNameListBox.TabIndex = 0;
            // 
            // FirstNaneLabel
            // 
            this.FirstNaneLabel.AutoSize = true;
            this.FirstNaneLabel.Location = new System.Drawing.Point(49, 43);
            this.FirstNaneLabel.Name = "FirstNaneLabel";
            this.FirstNaneLabel.Size = new System.Drawing.Size(101, 24);
            this.FirstNaneLabel.TabIndex = 1;
            this.FirstNaneLabel.Text = "First Name";
            // 
            // DataForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(396, 381);
            this.Controls.Add(this.FirstNaneLabel);
            this.Controls.Add(this.FirstNameListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FirstNameListBox;
        private System.Windows.Forms.Label FirstNaneLabel;
    }
}

