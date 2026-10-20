namespace subject_10_assignment
{
    partial class FormComputerinfo
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
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.btnOP = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.imgInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPU
            // 
            this.btnCPU.BackColor = System.Drawing.Color.Green;
            this.btnCPU.ForeColor = System.Drawing.Color.Lime;
            this.btnCPU.Location = new System.Drawing.Point(12, 8);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(75, 23);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = false;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.BackColor = System.Drawing.Color.Green;
            this.btnRAM.ForeColor = System.Drawing.Color.Lime;
            this.btnRAM.Location = new System.Drawing.Point(93, 8);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(75, 23);
            this.btnRAM.TabIndex = 1;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = false;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.BackColor = System.Drawing.Color.Green;
            this.btnSSD.ForeColor = System.Drawing.Color.Lime;
            this.btnSSD.Location = new System.Drawing.Point(174, 8);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(75, 23);
            this.btnSSD.TabIndex = 2;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = false;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPSU
            // 
            this.btnPSU.BackColor = System.Drawing.Color.Green;
            this.btnPSU.ForeColor = System.Drawing.Color.Lime;
            this.btnPSU.Location = new System.Drawing.Point(255, 8);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Size = new System.Drawing.Size(75, 23);
            this.btnPSU.TabIndex = 3;
            this.btnPSU.Text = "PSU";
            this.btnPSU.UseVisualStyleBackColor = false;
            this.btnPSU.Click += new System.EventHandler(this.btnPSU_Click);
            // 
            // btnIP
            // 
            this.btnIP.BackColor = System.Drawing.Color.Green;
            this.btnIP.ForeColor = System.Drawing.Color.Lime;
            this.btnIP.Location = new System.Drawing.Point(336, 8);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 23);
            this.btnIP.TabIndex = 4;
            this.btnIP.Text = "Input";
            this.btnIP.UseVisualStyleBackColor = false;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnOP
            // 
            this.btnOP.BackColor = System.Drawing.Color.Green;
            this.btnOP.ForeColor = System.Drawing.Color.Lime;
            this.btnOP.Location = new System.Drawing.Point(417, 8);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(75, 23);
            this.btnOP.TabIndex = 5;
            this.btnOP.Text = "Output";
            this.btnOP.UseVisualStyleBackColor = false;
            this.btnOP.Click += new System.EventHandler(this.btnOP_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Lime;
            this.lblInfo.Location = new System.Drawing.Point(417, 37);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(371, 311);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Select a button to learn more about the component";
            // 
            // imgInfo
            // 
            this.imgInfo.Location = new System.Drawing.Point(12, 37);
            this.imgInfo.Name = "imgInfo";
            this.imgInfo.Size = new System.Drawing.Size(399, 311);
            this.imgInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInfo.TabIndex = 7;
            this.imgInfo.TabStop = false;
            // 
            // FormComputerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOP);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.btnPSU);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.Name = "FormComputerinfo";
            this.Text = "Computer Info";
            ((System.ComponentModel.ISupportInitialize)(this.imgInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnOP;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox imgInfo;
    }
}

