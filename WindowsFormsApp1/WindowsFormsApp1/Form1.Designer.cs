namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.cBBL = new System.Windows.Forms.CheckBox();
            this.cBBR = new System.Windows.Forms.CheckBox();
            this.cBHUPE = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.PortName = "COM4";
            // 
            // speedBar
            // 
            this.speedBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.speedBar.Location = new System.Drawing.Point(0, 0);
            this.speedBar.Maximum = 31;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(420, 45);
            this.speedBar.TabIndex = 0;
            this.speedBar.Value = 10;
            this.speedBar.Scroll += new System.EventHandler(this.speedBar_Scroll);
            this.speedBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.speedBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADC:  ";
            // 
            // cBBL
            // 
            this.cBBL.AutoSize = true;
            this.cBBL.Location = new System.Drawing.Point(12, 78);
            this.cBBL.Name = "cBBL";
            this.cBBL.Size = new System.Drawing.Size(86, 17);
            this.cBBL.TabIndex = 2;
            this.cBBL.Text = "Blinker Links";
            this.cBBL.UseVisualStyleBackColor = true;
            this.cBBL.CheckedChanged += new System.EventHandler(this.cBBL_CheckedChanged);
            this.cBBL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.cBBL.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // cBBR
            // 
            this.cBBR.AutoSize = true;
            this.cBBR.Location = new System.Drawing.Point(313, 78);
            this.cBBR.Name = "cBBR";
            this.cBBR.Size = new System.Drawing.Size(95, 17);
            this.cBBR.TabIndex = 3;
            this.cBBR.Text = "Blinker Rechts";
            this.cBBR.UseVisualStyleBackColor = true;
            this.cBBR.CheckedChanged += new System.EventHandler(this.cBBR_CheckedChanged);
            this.cBBR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.cBBR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // cBHUPE
            // 
            this.cBHUPE.AutoSize = true;
            this.cBHUPE.Location = new System.Drawing.Point(161, 78);
            this.cBHUPE.Name = "cBHUPE";
            this.cBHUPE.Size = new System.Drawing.Size(52, 17);
            this.cBHUPE.TabIndex = 4;
            this.cBHUPE.Text = "Hupe";
            this.cBHUPE.UseVisualStyleBackColor = true;
            this.cBHUPE.CheckedChanged += new System.EventHandler(this.cBHUPE_CheckedChanged);
            this.cBHUPE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.cBHUPE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 107);
            this.Controls.Add(this.cBHUPE);
            this.Controls.Add(this.cBBR);
            this.Controls.Add(this.cBBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBBL;
        private System.Windows.Forms.CheckBox cBBR;
        private System.Windows.Forms.CheckBox cBHUPE;
    }
}

