namespace daniel_humphreys_Ex_02
{
    partial class GradeBookForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(25, 41);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 238);
            this.listBox.TabIndex = 0;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(194, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(194, 83);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(100, 23);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Input";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(194, 127);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(194, 168);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(194, 212);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(100, 23);
            this.sumButton.TabIndex = 5;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(194, 256);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(100, 23);
            this.averageButton.TabIndex = 6;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // GradeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 328);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBox);
            this.Name = "GradeBookForm";
            this.Text = "Grade Book Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button averageButton;
    }
}

