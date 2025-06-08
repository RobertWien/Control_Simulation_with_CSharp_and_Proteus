namespace Simulation_CSharp
{
    partial class Kitchen
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
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.FAN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LIGHT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_update = new System.Windows.Forms.Button();
            this.WARNING = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "CLOTHES LINE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FAN
            // 
            this.FAN.BackColor = System.Drawing.Color.Red;
            this.FAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAN.ForeColor = System.Drawing.SystemColors.Menu;
            this.FAN.Location = new System.Drawing.Point(330, 162);
            this.FAN.Margin = new System.Windows.Forms.Padding(6);
            this.FAN.Name = "FAN";
            this.FAN.Size = new System.Drawing.Size(287, 52);
            this.FAN.TabIndex = 31;
            this.FAN.Text = "PULL IN";
            this.FAN.UseVisualStyleBackColor = false;
            this.FAN.Click += new System.EventHandler(this.FAN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "LIGHT";
            // 
            // LIGHT
            // 
            this.LIGHT.BackColor = System.Drawing.Color.Red;
            this.LIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIGHT.ForeColor = System.Drawing.SystemColors.Menu;
            this.LIGHT.Location = new System.Drawing.Point(71, 162);
            this.LIGHT.Margin = new System.Windows.Forms.Padding(6);
            this.LIGHT.Name = "LIGHT";
            this.LIGHT.Size = new System.Drawing.Size(172, 52);
            this.LIGHT.TabIndex = 29;
            this.LIGHT.Text = "CLOSE";
            this.LIGHT.UseVisualStyleBackColor = false;
            this.LIGHT.Click += new System.EventHandler(this.LIGHT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(71, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "WARNING:";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(213, 256);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(154, 52);
            this.btn_update.TabIndex = 35;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // WARNING
            // 
            this.WARNING.AutoSize = true;
            this.WARNING.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WARNING.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.WARNING.Location = new System.Drawing.Point(280, 356);
            this.WARNING.Name = "WARNING";
            this.WARNING.Size = new System.Drawing.Size(164, 38);
            this.WARNING.TabIndex = 36;
            this.WARNING.Text = "NORMAL";
            this.WARNING.Click += new System.EventHandler(this.WARNING_Click);
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 573);
            this.Controls.Add(this.WARNING);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FAN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIGHT);
            this.Name = "Kitchen";
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LIGHT;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label WARNING;
    }
}