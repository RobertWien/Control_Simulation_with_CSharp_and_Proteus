namespace Simulation_CSharp
{
    partial class Bedroom
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
            this.HUMID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TEMP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FAN = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LIGHT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AIR_CONDITIONER = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HUMID
            // 
            this.HUMID.AutoSize = true;
            this.HUMID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HUMID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.HUMID.Location = new System.Drawing.Point(365, 411);
            this.HUMID.Name = "HUMID";
            this.HUMID.Size = new System.Drawing.Size(42, 32);
            this.HUMID.TabIndex = 32;
            this.HUMID.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(423, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "%";
            // 
            // TEMP
            // 
            this.TEMP.AutoSize = true;
            this.TEMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEMP.ForeColor = System.Drawing.Color.Tomato;
            this.TEMP.Location = new System.Drawing.Point(365, 355);
            this.TEMP.Name = "TEMP";
            this.TEMP.Size = new System.Drawing.Size(42, 32);
            this.TEMP.TabIndex = 30;
            this.TEMP.Text = "...";
            this.TEMP.Click += new System.EventHandler(this.TEMP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(423, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = " °C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "FAN";
            // 
            // FAN
            // 
            this.FAN.BackColor = System.Drawing.Color.Red;
            this.FAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAN.ForeColor = System.Drawing.SystemColors.Menu;
            this.FAN.Location = new System.Drawing.Point(371, 146);
            this.FAN.Margin = new System.Windows.Forms.Padding(6);
            this.FAN.Name = "FAN";
            this.FAN.Size = new System.Drawing.Size(207, 52);
            this.FAN.TabIndex = 27;
            this.FAN.Text = "CLOSE";
            this.FAN.UseVisualStyleBackColor = false;
            this.FAN.Click += new System.EventHandler(this.FAN_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(112, 229);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(154, 52);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(112, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "HUMIDITY:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(112, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "TEMPERATURE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "LIGHT";
            // 
            // LIGHT
            // 
            this.LIGHT.BackColor = System.Drawing.Color.Red;
            this.LIGHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIGHT.ForeColor = System.Drawing.SystemColors.Menu;
            this.LIGHT.Location = new System.Drawing.Point(112, 146);
            this.LIGHT.Margin = new System.Windows.Forms.Padding(6);
            this.LIGHT.Name = "LIGHT";
            this.LIGHT.Size = new System.Drawing.Size(172, 52);
            this.LIGHT.TabIndex = 22;
            this.LIGHT.Text = "CLOSE";
            this.LIGHT.UseVisualStyleBackColor = false;
            this.LIGHT.Click += new System.EventHandler(this.LIGHT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "AIR CONDITIONER";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AIR_CONDITIONER
            // 
            this.AIR_CONDITIONER.BackColor = System.Drawing.Color.Red;
            this.AIR_CONDITIONER.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AIR_CONDITIONER.ForeColor = System.Drawing.SystemColors.Menu;
            this.AIR_CONDITIONER.Location = new System.Drawing.Point(635, 146);
            this.AIR_CONDITIONER.Margin = new System.Windows.Forms.Padding(6);
            this.AIR_CONDITIONER.Name = "AIR_CONDITIONER";
            this.AIR_CONDITIONER.Size = new System.Drawing.Size(207, 52);
            this.AIR_CONDITIONER.TabIndex = 33;
            this.AIR_CONDITIONER.Text = "CLOSE";
            this.AIR_CONDITIONER.UseVisualStyleBackColor = false;
            this.AIR_CONDITIONER.Click += new System.EventHandler(this.AIR_CONDITIONER_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(422, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 32);
            this.label8.TabIndex = 37;
            this.label8.Text = "...";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(470, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 32);
            this.label9.TabIndex = 36;
            this.label9.Text = "UNIT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(302, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 32);
            this.label10.TabIndex = 35;
            this.label10.Text = "SPEED:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownHeight = 120;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "NO SELECTION",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(652, 293);
            this.comboBox1.MaxDropDownItems = 12;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 38;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(575, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(316, 32);
            this.label11.TabIndex = 39;
            this.label11.Text = "SELECT SPEED UNIT";
            // 
            // Bedroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 587);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AIR_CONDITIONER);
            this.Controls.Add(this.HUMID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TEMP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FAN);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIGHT);
            this.Name = "Bedroom";
            this.Text = "Bedroom";
            this.Load += new System.EventHandler(this.Bedroom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HUMID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TEMP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FAN;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LIGHT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AIR_CONDITIONER;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
    }
}