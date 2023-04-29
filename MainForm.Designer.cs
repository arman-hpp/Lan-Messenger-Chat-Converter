
namespace LanMessengerChatConverter
{
    partial class MainForm
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.txtDesPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSrc = new System.Windows.Forms.Button();
            this.btnBrowseDes = new System.Windows.Forms.Button();
            this.ofdSelectSrc = new System.Windows.Forms.OpenFileDialog();
            this.ofdSelectDes = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(10, 83);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(397, 31);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(10, 11);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.ReadOnly = true;
            this.txtSrcPath.Size = new System.Drawing.Size(324, 21);
            this.txtSrcPath.TabIndex = 1;
            // 
            // txtDesPath
            // 
            this.txtDesPath.Location = new System.Drawing.Point(10, 49);
            this.txtDesPath.Name = "txtDesPath";
            this.txtDesPath.ReadOnly = true;
            this.txtDesPath.Size = new System.Drawing.Size(324, 21);
            this.txtDesPath.TabIndex = 3;
            // 
            // btnBrowseSrc
            // 
            this.btnBrowseSrc.Location = new System.Drawing.Point(340, 9);
            this.btnBrowseSrc.Name = "btnBrowseSrc";
            this.btnBrowseSrc.Size = new System.Drawing.Size(67, 23);
            this.btnBrowseSrc.TabIndex = 2;
            this.btnBrowseSrc.Text = "Browse";
            this.btnBrowseSrc.UseVisualStyleBackColor = true;
            this.btnBrowseSrc.Click += new System.EventHandler(this.btnBrowseSrc_Click);
            // 
            // btnBrowseDes
            // 
            this.btnBrowseDes.Location = new System.Drawing.Point(340, 49);
            this.btnBrowseDes.Name = "btnBrowseDes";
            this.btnBrowseDes.Size = new System.Drawing.Size(67, 23);
            this.btnBrowseDes.TabIndex = 4;
            this.btnBrowseDes.Text = "Browse";
            this.btnBrowseDes.UseVisualStyleBackColor = true;
            this.btnBrowseDes.Click += new System.EventHandler(this.btnBrowseDes_Click);
            // 
            // ofdSelectSrc
            // 
            this.ofdSelectSrc.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(414, 121);
            this.Controls.Add(this.btnBrowseDes);
            this.Controls.Add(this.btnBrowseSrc);
            this.Controls.Add(this.txtDesPath);
            this.Controls.Add(this.txtSrcPath);
            this.Controls.Add(this.btnConvert);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 160);
            this.MinimumSize = new System.Drawing.Size(430, 160);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lan Messenger Chats to HTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.TextBox txtDesPath;
        private System.Windows.Forms.Button btnBrowseSrc;
        private System.Windows.Forms.Button btnBrowseDes;
        private System.Windows.Forms.OpenFileDialog ofdSelectSrc;
        private System.Windows.Forms.FolderBrowserDialog ofdSelectDes;
    }
}

