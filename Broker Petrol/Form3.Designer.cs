
namespace Broker_Petrol
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.endShift = new Broker_Petrol.Custom_button.roundedButton();
            this.timeIcon = new System.Windows.Forms.Panel();
            this.timePlaceHolder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dieselDispensedPlaceHolder = new System.Windows.Forms.Label();
            this.unleadedDispensedPlacceHolder = new System.Windows.Forms.Label();
            this.lpgDispensedPlaceHolder = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.commissionPlaceHolder = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicleLeftText = new System.Windows.Forms.Label();
            this.vehicleServicedText = new System.Windows.Forms.Label();
            this.totalFuelDispensedText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.simulationViewPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.endShift);
            this.panel1.Controls.Add(this.timeIcon);
            this.panel1.Controls.Add(this.timePlaceHolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 56);
            this.panel1.TabIndex = 0;
            // 
            // endShift
            // 
            this.endShift.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.endShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.endShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endShift.FlatAppearance.BorderSize = 0;
            this.endShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endShift.ForeColor = System.Drawing.Color.White;
            this.endShift.Location = new System.Drawing.Point(773, 8);
            this.endShift.Name = "endShift";
            this.endShift.Size = new System.Drawing.Size(95, 38);
            this.endShift.TabIndex = 4;
            this.endShift.Text = "End shift";
            this.endShift.UseVisualStyleBackColor = false;
            this.endShift.Click += new System.EventHandler(this.endShiftBtn_Click);
            // 
            // timeIcon
            // 
            this.timeIcon.BackgroundImage = global::Broker_Petrol.Properties.Resources.night_mode;
            this.timeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.timeIcon.Location = new System.Drawing.Point(25, 7);
            this.timeIcon.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.timeIcon.Name = "timeIcon";
            this.timeIcon.Size = new System.Drawing.Size(47, 41);
            this.timeIcon.TabIndex = 3;
            // 
            // timePlaceHolder
            // 
            this.timePlaceHolder.AutoSize = true;
            this.timePlaceHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePlaceHolder.Location = new System.Drawing.Point(72, 14);
            this.timePlaceHolder.Name = "timePlaceHolder";
            this.timePlaceHolder.Size = new System.Drawing.Size(70, 29);
            this.timePlaceHolder.TabIndex = 2;
            this.timePlaceHolder.Text = "Time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(654, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 496);
            this.panel2.TabIndex = 1;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(23, 62);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 17);
            this.date.TabIndex = 3;
            this.date.Text = "Today\'s date: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dieselDispensedPlaceHolder);
            this.panel3.Controls.Add(this.unleadedDispensedPlacceHolder);
            this.panel3.Controls.Add(this.lpgDispensedPlaceHolder);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.commissionPlaceHolder);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.vehicleLeftText);
            this.panel3.Controls.Add(this.vehicleServicedText);
            this.panel3.Controls.Add(this.totalFuelDispensedText);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 399);
            this.panel3.TabIndex = 2;
            // 
            // dieselDispensedPlaceHolder
            // 
            this.dieselDispensedPlaceHolder.AutoSize = true;
            this.dieselDispensedPlaceHolder.Location = new System.Drawing.Point(132, 185);
            this.dieselDispensedPlaceHolder.Name = "dieselDispensedPlaceHolder";
            this.dieselDispensedPlaceHolder.Size = new System.Drawing.Size(46, 17);
            this.dieselDispensedPlaceHolder.TabIndex = 13;
            this.dieselDispensedPlaceHolder.Text = "label8";
            // 
            // unleadedDispensedPlacceHolder
            // 
            this.unleadedDispensedPlacceHolder.AutoSize = true;
            this.unleadedDispensedPlacceHolder.Location = new System.Drawing.Point(132, 147);
            this.unleadedDispensedPlacceHolder.Name = "unleadedDispensedPlacceHolder";
            this.unleadedDispensedPlacceHolder.Size = new System.Drawing.Size(46, 17);
            this.unleadedDispensedPlacceHolder.TabIndex = 12;
            this.unleadedDispensedPlacceHolder.Text = "label8";
            // 
            // lpgDispensedPlaceHolder
            // 
            this.lpgDispensedPlaceHolder.AutoSize = true;
            this.lpgDispensedPlaceHolder.Location = new System.Drawing.Point(132, 106);
            this.lpgDispensedPlaceHolder.Name = "lpgDispensedPlaceHolder";
            this.lpgDispensedPlaceHolder.Size = new System.Drawing.Size(46, 17);
            this.lpgDispensedPlaceHolder.TabIndex = 11;
            this.lpgDispensedPlaceHolder.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fuel dispensed by type:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Diesel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unleaded";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "LPG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commissionPlaceHolder
            // 
            this.commissionPlaceHolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commissionPlaceHolder.AutoSize = true;
            this.commissionPlaceHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commissionPlaceHolder.ForeColor = System.Drawing.Color.Green;
            this.commissionPlaceHolder.Location = new System.Drawing.Point(150, 289);
            this.commissionPlaceHolder.Name = "commissionPlaceHolder";
            this.commissionPlaceHolder.Size = new System.Drawing.Size(39, 25);
            this.commissionPlaceHolder.TabIndex = 6;
            this.commissionPlaceHolder.Text = "0 $";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(19, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 6);
            this.panel4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total commision";
            // 
            // vehicleLeftText
            // 
            this.vehicleLeftText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleLeftText.AutoSize = true;
            this.vehicleLeftText.Location = new System.Drawing.Point(17, 261);
            this.vehicleLeftText.Name = "vehicleLeftText";
            this.vehicleLeftText.Size = new System.Drawing.Size(175, 17);
            this.vehicleLeftText.TabIndex = 3;
            this.vehicleLeftText.Text = "Vehicle left without fueling:";
            // 
            // vehicleServicedText
            // 
            this.vehicleServicedText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vehicleServicedText.AutoSize = true;
            this.vehicleServicedText.Location = new System.Drawing.Point(17, 231);
            this.vehicleServicedText.Name = "vehicleServicedText";
            this.vehicleServicedText.Size = new System.Drawing.Size(115, 17);
            this.vehicleServicedText.TabIndex = 2;
            this.vehicleServicedText.Text = "Vehicle serviced:";
            // 
            // totalFuelDispensedText
            // 
            this.totalFuelDispensedText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalFuelDispensedText.AutoSize = true;
            this.totalFuelDispensedText.Location = new System.Drawing.Point(17, 53);
            this.totalFuelDispensedText.Name = "totalFuelDispensedText";
            this.totalFuelDispensedText.Size = new System.Drawing.Size(140, 17);
            this.totalFuelDispensedText.TabIndex = 1;
            this.totalFuelDispensedText.Text = "Total fuel dispensed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Service analysis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back!\r\n";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // simulationViewPanel
            // 
            this.simulationViewPanel.Location = new System.Drawing.Point(0, 56);
            this.simulationViewPanel.Name = "simulationViewPanel";
            this.simulationViewPanel.Size = new System.Drawing.Size(663, 496);
            this.simulationViewPanel.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 552);
            this.Controls.Add(this.simulationViewPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timePlaceHolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vehicleLeftText;
        private System.Windows.Forms.Label vehicleServicedText;
        private System.Windows.Forms.Label totalFuelDispensedText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel timeIcon;
        private Custom_button.roundedButton endShift;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel simulationViewPanel;
        private System.Windows.Forms.Label commissionPlaceHolder;
        private System.Windows.Forms.Label dieselDispensedPlaceHolder;
        private System.Windows.Forms.Label unleadedDispensedPlacceHolder;
        private System.Windows.Forms.Label lpgDispensedPlaceHolder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date;
    }
}