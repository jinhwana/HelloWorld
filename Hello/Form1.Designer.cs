namespace Hello
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
            this.txtName = new System.Windows.Forms.Label();
            this.cmdHello = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(12, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(99, 12);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Enter your name";
            // 
            // cmdHello
            // 
            this.cmdHello.Location = new System.Drawing.Point(3, 28);
            this.cmdHello.Name = "cmdHello";
            this.cmdHello.Size = new System.Drawing.Size(223, 21);
            this.cmdHello.TabIndex = 1;
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(3, 55);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(223, 39);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // lblHello
            // 
            this.lblHello.Font = new System.Drawing.Font("Gulim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHello.Location = new System.Drawing.Point(3, 85);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(269, 132);
            this.lblHello.TabIndex = 3;
            this.lblHello.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.cmdHello);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Hello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox cmdHello;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label lblHello;
    }
}

