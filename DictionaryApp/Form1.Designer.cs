namespace DictionaryApp
{
    partial class Form1
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
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.detailsTextBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.searchInfoButton = new System.Windows.Forms.Button();
            this.showAllInformatiomButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(291, 157);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(75, 23);
            this.saveInfoButton.TabIndex = 0;
            this.saveInfoButton.Text = "Save";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Details";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(107, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(163, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // detailsTextBox
            // 
            this.detailsTextBox.Location = new System.Drawing.Point(107, 88);
            this.detailsTextBox.Multiline = true;
            this.detailsTextBox.Name = "detailsTextBox";
            this.detailsTextBox.Size = new System.Drawing.Size(163, 92);
            this.detailsTextBox.TabIndex = 4;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(107, 206);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(163, 20);
            this.idBox.TabIndex = 5;
            // 
            // searchInfoButton
            // 
            this.searchInfoButton.Location = new System.Drawing.Point(291, 206);
            this.searchInfoButton.Name = "searchInfoButton";
            this.searchInfoButton.Size = new System.Drawing.Size(75, 23);
            this.searchInfoButton.TabIndex = 6;
            this.searchInfoButton.Text = "Find";
            this.searchInfoButton.UseVisualStyleBackColor = true;
            this.searchInfoButton.Click += new System.EventHandler(this.searchInfoButton_Click);
            // 
            // showAllInformatiomButton
            // 
            this.showAllInformatiomButton.Location = new System.Drawing.Point(116, 256);
            this.showAllInformatiomButton.Name = "showAllInformatiomButton";
            this.showAllInformatiomButton.Size = new System.Drawing.Size(129, 23);
            this.showAllInformatiomButton.TabIndex = 7;
            this.showAllInformatiomButton.Text = "Show All Information";
            this.showAllInformatiomButton.UseVisualStyleBackColor = true;
            this.showAllInformatiomButton.Click += new System.EventHandler(this.showAllInformatiomButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.showAllInformatiomButton);
            this.Controls.Add(this.searchInfoButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.detailsTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveInfoButton);
            this.Name = "Form1";
            this.Text = "DictionaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox detailsTextBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button searchInfoButton;
        private System.Windows.Forms.Button showAllInformatiomButton;
        private System.Windows.Forms.Label label3;
    }
}

