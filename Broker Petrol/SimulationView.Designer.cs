
namespace Broker_Petrol
{
    partial class SimulationView
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
            this.spawnPoint3 = new System.Windows.Forms.Panel();
            this.spawnPoint2 = new System.Windows.Forms.Panel();
            this.spawnPoint = new System.Windows.Forms.Panel();
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.queue1Count = new System.Windows.Forms.Label();
            this.queue2Count = new System.Windows.Forms.Label();
            this.queue3Count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // spawnPoint3
            // 
            this.spawnPoint3.Location = new System.Drawing.Point(175, 313);
            this.spawnPoint3.Name = "spawnPoint3";
            this.spawnPoint3.Size = new System.Drawing.Size(36, 39);
            this.spawnPoint3.TabIndex = 9;
            // 
            // spawnPoint2
            // 
            this.spawnPoint2.Location = new System.Drawing.Point(175, 200);
            this.spawnPoint2.Name = "spawnPoint2";
            this.spawnPoint2.Size = new System.Drawing.Size(36, 39);
            this.spawnPoint2.TabIndex = 10;
            // 
            // spawnPoint
            // 
            this.spawnPoint.Location = new System.Drawing.Point(175, 92);
            this.spawnPoint.Name = "spawnPoint";
            this.spawnPoint.Size = new System.Drawing.Size(36, 39);
            this.spawnPoint.TabIndex = 8;
            // 
            // simulationTimer
            // 
            this.simulationTimer.Tick += new System.EventHandler(this.simulationTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Simulation view";
            // 
            // queue1Count
            // 
            this.queue1Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.queue1Count.ForeColor = System.Drawing.Color.White;
            this.queue1Count.Location = new System.Drawing.Point(-1, 92);
            this.queue1Count.Name = "queue1Count";
            this.queue1Count.Size = new System.Drawing.Size(143, 39);
            this.queue1Count.TabIndex = 18;
            this.queue1Count.Text = "Queue 1   ";
            this.queue1Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // queue2Count
            // 
            this.queue2Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.queue2Count.ForeColor = System.Drawing.Color.White;
            this.queue2Count.Location = new System.Drawing.Point(-1, 200);
            this.queue2Count.Name = "queue2Count";
            this.queue2Count.Size = new System.Drawing.Size(143, 39);
            this.queue2Count.TabIndex = 19;
            this.queue2Count.Text = "Queue 2   ";
            this.queue2Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // queue3Count
            // 
            this.queue3Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(204)))));
            this.queue3Count.ForeColor = System.Drawing.Color.White;
            this.queue3Count.Location = new System.Drawing.Point(-1, 313);
            this.queue3Count.Name = "queue3Count";
            this.queue3Count.Size = new System.Drawing.Size(143, 39);
            this.queue3Count.TabIndex = 20;
            this.queue3Count.Text = "Queue 3   ";
            this.queue3Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Vehicle waiting in:";
            // 
            // SimulationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 427);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.queue3Count);
            this.Controls.Add(this.queue2Count);
            this.Controls.Add(this.queue1Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spawnPoint3);
            this.Controls.Add(this.spawnPoint2);
            this.Controls.Add(this.spawnPoint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimulationView";
            this.Text = "SimulationView";
            this.Load += new System.EventHandler(this.SimulationView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel spawnPoint3;
        private System.Windows.Forms.Panel spawnPoint2;
        private System.Windows.Forms.Panel spawnPoint;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label queue1Count;
        private System.Windows.Forms.Label queue2Count;
        private System.Windows.Forms.Label queue3Count;
        private System.Windows.Forms.Label label5;
    }
}