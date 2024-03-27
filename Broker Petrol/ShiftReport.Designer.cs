
namespace Broker_Petrol
{
    partial class ShiftReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.totalFuel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lpg = new System.Windows.Forms.Label();
            this.unleaded = new System.Windows.Forms.Label();
            this.diesel = new System.Windows.Forms.Label();
            this.income = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleServiced = new System.Windows.Forms.Label();
            this.vehicleLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commission = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shift Report Summary";
            // 
            // totalFuel
            // 
            this.totalFuel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalFuel.AutoSize = true;
            this.totalFuel.Location = new System.Drawing.Point(36, 106);
            this.totalFuel.Name = "totalFuel";
            this.totalFuel.Size = new System.Drawing.Size(144, 17);
            this.totalFuel.TabIndex = 3;
            this.totalFuel.Text = "Total fuel dispensed: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fuel dispensed by type: ";
            // 
            // lpg
            // 
            this.lpg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lpg.AutoSize = true;
            this.lpg.Location = new System.Drawing.Point(133, 186);
            this.lpg.Name = "lpg";
            this.lpg.Size = new System.Drawing.Size(113, 17);
            this.lpg.TabIndex = 5;
            this.lpg.Text = "LPG dispensed: ";
            // 
            // unleaded
            // 
            this.unleaded.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unleaded.AutoSize = true;
            this.unleaded.Location = new System.Drawing.Point(133, 224);
            this.unleaded.Name = "unleaded";
            this.unleaded.Size = new System.Drawing.Size(146, 17);
            this.unleaded.TabIndex = 6;
            this.unleaded.Text = "Unleaded dispensed: ";
            // 
            // diesel
            // 
            this.diesel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diesel.AutoSize = true;
            this.diesel.Location = new System.Drawing.Point(133, 269);
            this.diesel.Name = "diesel";
            this.diesel.Size = new System.Drawing.Size(124, 17);
            this.diesel.TabIndex = 7;
            this.diesel.Text = "Diesel dispensed: ";
            // 
            // income
            // 
            this.income.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.income.AutoSize = true;
            this.income.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income.ForeColor = System.Drawing.Color.Green;
            this.income.Location = new System.Drawing.Point(35, 535);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(148, 24);
            this.income.TabIndex = 8;
            this.income.Text = "Income earned: ";
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(493, 71);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(46, 17);
            this.date.TabIndex = 9;
            this.date.Text = "Date: ";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(39, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 187);
            this.dataGridView1.TabIndex = 10;
            // 
            // vehicleServiced
            // 
            this.vehicleServiced.AutoSize = true;
            this.vehicleServiced.Location = new System.Drawing.Point(493, 106);
            this.vehicleServiced.Name = "vehicleServiced";
            this.vehicleServiced.Size = new System.Drawing.Size(119, 17);
            this.vehicleServiced.TabIndex = 11;
            this.vehicleServiced.Text = "Vehicle serviced: ";
            // 
            // vehicleLeft
            // 
            this.vehicleLeft.AutoSize = true;
            this.vehicleLeft.Location = new System.Drawing.Point(493, 146);
            this.vehicleLeft.Name = "vehicleLeft";
            this.vehicleLeft.Size = new System.Drawing.Size(192, 17);
            this.vehicleLeft.TabIndex = 12;
            this.vehicleLeft.Text = "Vehicle left without refueling: ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "LPG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Unleaded";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Diesel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Pump Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Total Fuel dispensed (Litre)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "LPG Dispensed (Litre)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Unleaded Dispensed (Litre)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diesel Dispensed (Litre)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // commission
            // 
            this.commission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.commission.AutoSize = true;
            this.commission.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commission.ForeColor = System.Drawing.Color.Green;
            this.commission.Location = new System.Drawing.Point(35, 502);
            this.commission.Name = "commission";
            this.commission.Size = new System.Drawing.Size(140, 17);
            this.commission.TabIndex = 16;
            this.commission.Text = "Commission earned: ";
            // 
            // ShiftReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.commission);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vehicleLeft);
            this.Controls.Add(this.vehicleServiced);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.income);
            this.Controls.Add(this.diesel);
            this.Controls.Add(this.unleaded);
            this.Controls.Add(this.lpg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalFuel);
            this.Controls.Add(this.label1);
            this.Name = "ShiftReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShiftReport_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalFuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lpg;
        private System.Windows.Forms.Label unleaded;
        private System.Windows.Forms.Label diesel;
        private System.Windows.Forms.Label income;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label vehicleServiced;
        private System.Windows.Forms.Label vehicleLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label commission;
    }
}