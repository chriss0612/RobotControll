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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOutL = new System.Windows.Forms.Label();
            this.labelOutR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.PortName = "COM6";
            this.port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelOutL
            // 
            this.labelOutL.AutoSize = true;
            this.labelOutL.Location = new System.Drawing.Point(159, 280);
            this.labelOutL.Name = "labelOutL";
            this.labelOutL.Size = new System.Drawing.Size(13, 13);
            this.labelOutL.TabIndex = 0;
            this.labelOutL.Text = "L";
            // 
            // labelOutR
            // 
            this.labelOutR.AutoSize = true;
            this.labelOutR.Location = new System.Drawing.Point(537, 280);
            this.labelOutR.Name = "labelOutR";
            this.labelOutR.Size = new System.Drawing.Size(15, 13);
            this.labelOutR.TabIndex = 1;
            this.labelOutR.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.labelOutR);
            this.Controls.Add(this.labelOutL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelOutL;
        private System.Windows.Forms.Label labelOutR;
    }
}

