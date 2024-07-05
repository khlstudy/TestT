namespace TestT
{
    partial class AnalyzeForm
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Location = new System.Drawing.Point(162, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(134, 50);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Вибрати файл";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnalyze.Location = new System.Drawing.Point(162, 140);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(134, 50);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Аналізувати числа";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(12, 196);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(458, 545);
            this.txtResults.TabIndex = 2;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(12, 112);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(458, 22);
            this.txtFilePath.TabIndex = 3;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.AliceBlue;
            this.lblPath.Location = new System.Drawing.Point(12, 93);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(39, 16);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Шлях";
            // 
            // AnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.btnBrowse);
            this.Name = "AnalyzeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аналіз чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblPath;
    }
}

