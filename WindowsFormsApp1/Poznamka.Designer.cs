namespace WindowsFormsApp1
{
    partial class Poznamka
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.buttonSafe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(28, 30);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(436, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(26, 15);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Jméno poznámky";
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Location = new System.Drawing.Point(28, 69);
            this.richTextBoxNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(436, 255);
            this.richTextBoxNote.TabIndex = 2;
            this.richTextBoxNote.Text = "";
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(26, 54);
            this.labelNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(79, 13);
            this.labelNote.TabIndex = 3;
            this.labelNote.Text = "Text poznámky";
            // 
            // buttonSave
            // 
            this.buttonSafe.Location = new System.Drawing.Point(330, 329);
            this.buttonSafe.Name = "buttonSafe";
            this.buttonSafe.Size = new System.Drawing.Size(134, 30);
            this.buttonSafe.TabIndex = 4;
            this.buttonSafe.Text = "Uložit poznámku";
            this.buttonSafe.UseVisualStyleBackColor = true;
            this.buttonSafe.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Poznamka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 373);
            this.Controls.Add(this.buttonSafe);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.richTextBoxNote);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Poznamka";
            this.Text = "Poznámka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Button buttonSafe;
    }
}