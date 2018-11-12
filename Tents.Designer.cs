namespace ShopNetwork
{
    partial class Tents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Upgrade = new System.Windows.Forms.Button();
            this.RemoveTent = new System.Windows.Forms.Button();
            this.AddTents = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 36);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наши предложения";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 414);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.Upgrade);
            this.panel2.Controls.Add(this.RemoveTent);
            this.panel2.Controls.Add(this.AddTents);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 367);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 83);
            this.panel2.TabIndex = 2;
            // 
            // Upgrade
            // 
            this.Upgrade.BackColor = System.Drawing.Color.DodgerBlue;
            this.Upgrade.FlatAppearance.BorderSize = 0;
            this.Upgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Upgrade.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Upgrade.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Upgrade.Image = ((System.Drawing.Image)(resources.GetObject("Upgrade.Image")));
            this.Upgrade.Location = new System.Drawing.Point(539, -3);
            this.Upgrade.Name = "Upgrade";
            this.Upgrade.Size = new System.Drawing.Size(91, 83);
            this.Upgrade.TabIndex = 1;
            this.Upgrade.Text = "Обновить";
            this.Upgrade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Upgrade.UseVisualStyleBackColor = false;
            // 
            // RemoveTent
            // 
            this.RemoveTent.BackColor = System.Drawing.Color.DodgerBlue;
            this.RemoveTent.FlatAppearance.BorderSize = 0;
            this.RemoveTent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTent.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveTent.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.RemoveTent.Image = ((System.Drawing.Image)(resources.GetObject("RemoveTent.Image")));
            this.RemoveTent.Location = new System.Drawing.Point(334, 0);
            this.RemoveTent.Name = "RemoveTent";
            this.RemoveTent.Size = new System.Drawing.Size(91, 83);
            this.RemoveTent.TabIndex = 1;
            this.RemoveTent.Text = "Удалить";
            this.RemoveTent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveTent.UseVisualStyleBackColor = false;
            // 
            // AddTents
            // 
            this.AddTents.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddTents.FlatAppearance.BorderSize = 0;
            this.AddTents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTents.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTents.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.AddTents.Image = ((System.Drawing.Image)(resources.GetObject("AddTents.Image")));
            this.AddTents.Location = new System.Drawing.Point(143, 0);
            this.AddTents.Name = "AddTents";
            this.AddTents.Size = new System.Drawing.Size(92, 83);
            this.AddTents.TabIndex = 0;
            this.AddTents.Text = "Добавить";
            this.AddTents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddTents.UseVisualStyleBackColor = false;
            this.AddTents.Click += new System.EventHandler(this.AddTents_Click);
            // 
            // Tents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tents";
            this.Text = "Tents";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Upgrade;
        private System.Windows.Forms.Button RemoveTent;
        private System.Windows.Forms.Button AddTents;
    }
}