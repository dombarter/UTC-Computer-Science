namespace GraphApplication
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
            this.nodeBox = new System.Windows.Forms.TextBox();
            this.depthBtn = new System.Windows.Forms.Button();
            this.breadthBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nodeBox
            // 
            this.nodeBox.Enabled = false;
            this.nodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeBox.Location = new System.Drawing.Point(13, 13);
            this.nodeBox.Multiline = true;
            this.nodeBox.Name = "nodeBox";
            this.nodeBox.Size = new System.Drawing.Size(259, 217);
            this.nodeBox.TabIndex = 0;
            this.nodeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // depthBtn
            // 
            this.depthBtn.Location = new System.Drawing.Point(13, 236);
            this.depthBtn.Name = "depthBtn";
            this.depthBtn.Size = new System.Drawing.Size(75, 23);
            this.depthBtn.TabIndex = 1;
            this.depthBtn.Text = "Depth";
            this.depthBtn.UseVisualStyleBackColor = true;
            this.depthBtn.Click += new System.EventHandler(this.depthBtn_Click);
            // 
            // breadthBtn
            // 
            this.breadthBtn.Location = new System.Drawing.Point(197, 236);
            this.breadthBtn.Name = "breadthBtn";
            this.breadthBtn.Size = new System.Drawing.Size(75, 23);
            this.breadthBtn.TabIndex = 2;
            this.breadthBtn.Text = "Breadth";
            this.breadthBtn.UseVisualStyleBackColor = true;
            this.breadthBtn.Click += new System.EventHandler(this.breadthBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.breadthBtn);
            this.Controls.Add(this.depthBtn);
            this.Controls.Add(this.nodeBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nodeBox;
        private System.Windows.Forms.Button depthBtn;
        private System.Windows.Forms.Button breadthBtn;
    }
}

