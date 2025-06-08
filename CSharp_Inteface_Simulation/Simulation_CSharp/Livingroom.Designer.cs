namespace Simulation_CSharp
{
    partial class Livingroom
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
            this.btn_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LIGHT = new System.Windows.Forms.Button();
            this.FAN = new System.Windows.Forms.Button();
            this.AIR_CONDITIONER = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TEMP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HUMID = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(322, 219);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(154, 52);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(91, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "HUMIDITY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(91, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "TEMPERATURE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "LIGHT";
            // 
            // LIGHT
            // 
            this.LIGHT.BackColor = System.Drawing.Color.Red;
            this.LIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIGHT.ForeColor = System.Drawing.SystemColors.Menu;
            this.LIGHT.Location = new System.Drawing.Point(40, 136);
            this.LIGHT.Margin = new System.Windows.Forms.Padding(6);
            this.LIGHT.Name = "LIGHT";
            this.LIGHT.Size = new System.Drawing.Size(172, 52);
            this.LIGHT.TabIndex = 7;
            this.LIGHT.Text = "CLOSE";
            this.LIGHT.UseVisualStyleBackColor = false;
            this.LIGHT.Click += new System.EventHandler(this.LIGHT_Click);
            // 
            // FAN
            // 
            this.FAN.BackColor = System.Drawing.Color.Red;
            this.FAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAN.ForeColor = System.Drawing.SystemColors.Menu;
            this.FAN.Location = new System.Drawing.Point(299, 136);
            this.FAN.Margin = new System.Windows.Forms.Padding(6);
            this.FAN.Name = "FAN";
            this.FAN.Size = new System.Drawing.Size(207, 52);
            this.FAN.TabIndex = 12;
            this.FAN.Text = "CLOSE";
            this.FAN.UseVisualStyleBackColor = false;
            this.FAN.Click += new System.EventHandler(this.FAN_Click);
            // 
            // AIR_CONDITIONER
            // 
            this.AIR_CONDITIONER.BackColor = System.Drawing.Color.Red;
            this.AIR_CONDITIONER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIR_CONDITIONER.ForeColor = System.Drawing.SystemColors.Menu;
            this.AIR_CONDITIONER.Location = new System.Drawing.Point(576, 136);
            this.AIR_CONDITIONER.Margin = new System.Windows.Forms.Padding(6);
            this.AIR_CONDITIONER.Name = "AIR_CONDITIONER";
            this.AIR_CONDITIONER.Size = new System.Drawing.Size(207, 52);
            this.AIR_CONDITIONER.TabIndex = 14;
            this.AIR_CONDITIONER.Text = "CLOSE";
            this.AIR_CONDITIONER.UseVisualStyleBackColor = false;
            this.AIR_CONDITIONER.Click += new System.EventHandler(this.AIR_CONDITIONER_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "FAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "AIR CONDITIONER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(402, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = " °C";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TEMP
            // 
            this.TEMP.AutoSize = true;
            this.TEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEMP.ForeColor = System.Drawing.Color.Tomato;
            this.TEMP.Location = new System.Drawing.Point(344, 327);
            this.TEMP.Name = "TEMP";
            this.TEMP.Size = new System.Drawing.Size(42, 32);
            this.TEMP.TabIndex = 19;
            this.TEMP.Text = "...";
            this.TEMP.Click += new System.EventHandler(this.TEMP_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(402, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "%";
            // 
            // HUMID
            // 
            this.HUMID.AutoSize = true;
            this.HUMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUMID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HUMID.Location = new System.Drawing.Point(344, 383);
            this.HUMID.Name = "HUMID";
            this.HUMID.Size = new System.Drawing.Size(42, 32);
            this.HUMID.TabIndex = 21;
            this.HUMID.Text = "...";
            this.HUMID.Click += new System.EventHandler(this.HUMID_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Livingroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 543);
            this.Controls.Add(this.HUMID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TEMP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AIR_CONDITIONER);
            this.Controls.Add(this.FAN);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIGHT);
            this.Name = "Livingroom";
            this.Text = "Livingroom";
            this.Load += new System.EventHandler(this.Livingroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LIGHT;
        private System.Windows.Forms.Button FAN;
        private System.Windows.Forms.Button AIR_CONDITIONER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TEMP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HUMID;
        private System.IO.Ports.SerialPort serialPort1;
    }
}