
namespace WinFormsAsync
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
            this.btn_Synch = new System.Windows.Forms.Button();
            this.btn_Asynch = new System.Windows.Forms.Button();
            this.lbl_btn_Synch = new System.Windows.Forms.Label();
            this.lbl_btn_Asynch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Synch
            // 
            this.btn_Synch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Synch.ForeColor = System.Drawing.Color.Red;
            this.btn_Synch.Location = new System.Drawing.Point(207, 76);
            this.btn_Synch.Name = "btn_Synch";
            this.btn_Synch.Size = new System.Drawing.Size(334, 78);
            this.btn_Synch.TabIndex = 0;
            this.btn_Synch.Text = "Process Synchronously";
            this.btn_Synch.UseVisualStyleBackColor = true;
            this.btn_Synch.Click += new System.EventHandler(this.btn_Synch_Click);
            // 
            // btn_Asynch
            // 
            this.btn_Asynch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Asynch.ForeColor = System.Drawing.Color.OliveDrab;
            this.btn_Asynch.Location = new System.Drawing.Point(207, 256);
            this.btn_Asynch.Name = "btn_Asynch";
            this.btn_Asynch.Size = new System.Drawing.Size(334, 78);
            this.btn_Asynch.TabIndex = 1;
            this.btn_Asynch.Text = "Process Asynchronously";
            this.btn_Asynch.UseVisualStyleBackColor = true;
            this.btn_Asynch.Click += new System.EventHandler(this.btn_Asynch_Click);
            // 
            // lbl_btn_Synch
            // 
            this.lbl_btn_Synch.AutoSize = true;
            this.lbl_btn_Synch.Location = new System.Drawing.Point(207, 181);
            this.lbl_btn_Synch.Name = "lbl_btn_Synch";
            this.lbl_btn_Synch.Size = new System.Drawing.Size(0, 17);
            this.lbl_btn_Synch.TabIndex = 2;
            // 
            // lbl_btn_Asynch
            // 
            this.lbl_btn_Asynch.AutoSize = true;
            this.lbl_btn_Asynch.Location = new System.Drawing.Point(204, 368);
            this.lbl_btn_Asynch.Name = "lbl_btn_Asynch";
            this.lbl_btn_Asynch.Size = new System.Drawing.Size(0, 17);
            this.lbl_btn_Asynch.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_btn_Asynch);
            this.Controls.Add(this.lbl_btn_Synch);
            this.Controls.Add(this.btn_Asynch);
            this.Controls.Add(this.btn_Synch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Synch;
        private System.Windows.Forms.Button btn_Asynch;
        private System.Windows.Forms.Label lbl_btn_Synch;
        private System.Windows.Forms.Label lbl_btn_Asynch;
    }
}

