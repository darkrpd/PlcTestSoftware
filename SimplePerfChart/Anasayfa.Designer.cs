namespace SimplePerfChart
{
    partial class Anasayfa
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Vibration = new System.Windows.Forms.Button();
            this.btn_Temperature = new System.Windows.Forms.Button();
            this.btn_Impulse = new System.Windows.Forms.Button();
            this.btn_Leak = new System.Windows.Forms.Button();
            this.btn_Aging = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Vibration, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Temperature, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Impulse, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Leak, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Aging, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Vibration
            // 
            this.btn_Vibration.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Vibration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Vibration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Vibration.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Vibration.Location = new System.Drawing.Point(4, 4);
            this.btn_Vibration.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Vibration.Name = "btn_Vibration";
            this.btn_Vibration.Size = new System.Drawing.Size(312, 105);
            this.btn_Vibration.TabIndex = 0;
            this.btn_Vibration.Text = "Vibration";
            this.btn_Vibration.UseVisualStyleBackColor = false;
            this.btn_Vibration.Click += new System.EventHandler(this.btn_Vibration_Click);
            // 
            // btn_Temperature
            // 
            this.btn_Temperature.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Temperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Temperature.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Temperature.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Temperature.Location = new System.Drawing.Point(324, 4);
            this.btn_Temperature.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Temperature.Name = "btn_Temperature";
            this.btn_Temperature.Size = new System.Drawing.Size(312, 105);
            this.btn_Temperature.TabIndex = 1;
            this.btn_Temperature.Text = "Temperature Pressure";
            this.btn_Temperature.UseVisualStyleBackColor = false;
            this.btn_Temperature.Click += new System.EventHandler(this.btn_Temperature_Click);
            // 
            // btn_Impulse
            // 
            this.btn_Impulse.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Impulse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Impulse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Impulse.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Impulse.Location = new System.Drawing.Point(4, 117);
            this.btn_Impulse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Impulse.Name = "btn_Impulse";
            this.btn_Impulse.Size = new System.Drawing.Size(312, 105);
            this.btn_Impulse.TabIndex = 2;
            this.btn_Impulse.Text = "Impulse Pressure";
            this.btn_Impulse.UseVisualStyleBackColor = false;
            this.btn_Impulse.Click += new System.EventHandler(this.btn_Impulse_Click);
            // 
            // btn_Leak
            // 
            this.btn_Leak.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Leak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Leak.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Leak.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Leak.Location = new System.Drawing.Point(324, 117);
            this.btn_Leak.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Leak.Name = "btn_Leak";
            this.btn_Leak.Size = new System.Drawing.Size(312, 105);
            this.btn_Leak.TabIndex = 3;
            this.btn_Leak.Text = "Leak Tight";
            this.btn_Leak.UseVisualStyleBackColor = false;
            this.btn_Leak.Click += new System.EventHandler(this.btn_Leak_Click);
            // 
            // btn_Aging
            // 
            this.btn_Aging.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_Aging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Aging.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Aging.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Aging.Location = new System.Drawing.Point(4, 230);
            this.btn_Aging.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aging.Name = "btn_Aging";
            this.btn_Aging.Size = new System.Drawing.Size(312, 107);
            this.btn_Aging.TabIndex = 4;
            this.btn_Aging.Text = "Pre-Aging";
            this.btn_Aging.UseVisualStyleBackColor = false;
            this.btn_Aging.Click += new System.EventHandler(this.btn_Aging_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Anasayfa_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Vibration;
        private System.Windows.Forms.Button btn_Temperature;
        private System.Windows.Forms.Button btn_Impulse;
        private System.Windows.Forms.Button btn_Leak;
        private System.Windows.Forms.Button btn_Aging;
    }
}