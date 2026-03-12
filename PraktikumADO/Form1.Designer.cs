namespace PraktikumADO
{
    partial class Form1
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitungData = new System.Windows.Forms.Button();
            this.btnUpdateMk = new System.Windows.Forms.Button();
            this.btnInsertProgramStudi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(24, 315);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 48);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(142, 315);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(96, 60);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(253, 315);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(97, 60);
            this.btnHitungMK.TabIndex = 2;
            this.btnHitungMK.Text = "Hitung MK";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(365, 314);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 61);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(264, 103);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(192, 26);
            this.txtHasil.TabIndex = 5;
            // 
            // btnHitungData
            // 
            this.btnHitungData.Location = new System.Drawing.Point(465, 315);
            this.btnHitungData.Name = "btnHitungData";
            this.btnHitungData.Size = new System.Drawing.Size(89, 60);
            this.btnHitungData.TabIndex = 6;
            this.btnHitungData.Text = "Hitung Data";
            this.btnHitungData.UseVisualStyleBackColor = true;
            this.btnHitungData.Click += new System.EventHandler(this.btnHitungDosen_Click);
            // 
            // btnUpdateMk
            // 
            this.btnUpdateMk.Location = new System.Drawing.Point(560, 315);
            this.btnUpdateMk.Name = "btnUpdateMk";
            this.btnUpdateMk.Size = new System.Drawing.Size(92, 60);
            this.btnUpdateMk.TabIndex = 7;
            this.btnUpdateMk.Text = "Update MK";
            this.btnUpdateMk.UseVisualStyleBackColor = true;
            this.btnUpdateMk.Click += new System.EventHandler(this.btnUpdateMK_Click);
            // 
            // btnInsertProgramStudi
            // 
            this.btnInsertProgramStudi.Location = new System.Drawing.Point(678, 315);
            this.btnInsertProgramStudi.Name = "btnInsertProgramStudi";
            this.btnInsertProgramStudi.Size = new System.Drawing.Size(91, 60);
            this.btnInsertProgramStudi.TabIndex = 8;
            this.btnInsertProgramStudi.Text = "Insert";
            this.btnInsertProgramStudi.UseVisualStyleBackColor = true;
            this.btnInsertProgramStudi.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertProgramStudi);
            this.Controls.Add(this.btnUpdateMk);
            this.Controls.Add(this.btnHitungData);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitungData;
        private System.Windows.Forms.Button btnUpdateMk;
        private System.Windows.Forms.Button btnInsertProgramStudi;
    }
}

