
namespace LayersOfMap
{
    partial class Message
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
            this.lbl = new System.Windows.Forms.Label();
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Location = new System.Drawing.Point(12, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(280, 400);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "label1";
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(701, 32);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(75, 23);
            this.BtnBrowser.TabIndex = 1;
            this.BtnBrowser.Text = "Browser";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // txtBoxFilePath
            // 
            this.txtBoxFilePath.Location = new System.Drawing.Point(432, 35);
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.Size = new System.Drawing.Size(263, 20);
            this.txtBoxFilePath.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(432, 80);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(263, 20);
            this.txtResult.TabIndex = 3;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtBoxFilePath);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.lbl);
            this.Name = "Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Button BtnBrowser;
        public System.Windows.Forms.TextBox txtBoxFilePath;
        public System.Windows.Forms.TextBox txtResult;
    }
}