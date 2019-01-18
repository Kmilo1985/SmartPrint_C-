namespace SmartPrint
{
    partial class FrmDian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDian));
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResoucion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtInicial = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.BtnDian = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(304, 108);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(126, 48);
            this.BtnGuardar.TabIndex = 32;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(380, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Resolución de la Dian No:";
            // 
            // txtResoucion
            // 
            this.txtResoucion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResoucion.Location = new System.Drawing.Point(220, 36);
            this.txtResoucion.MaxLength = 20;
            this.txtResoucion.Name = "txtResoucion";
            this.txtResoucion.Size = new System.Drawing.Size(100, 24);
            this.txtResoucion.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "de Noviembre 11/2011";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 17);
            this.label6.TabIndex = 116;
            this.label6.Text = "Facturación Autorizada de";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 119;
            this.label7.Text = "a";
            // 
            // TxtInicial
            // 
            this.TxtInicial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInicial.Location = new System.Drawing.Point(230, 69);
            this.TxtInicial.MaxLength = 15;
            this.TxtInicial.Name = "TxtInicial";
            this.TxtInicial.Size = new System.Drawing.Size(100, 23);
            this.TxtInicial.TabIndex = 28;
            this.TxtInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInicial_KeyPress);
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(359, 71);
            this.txtFinal.MaxLength = 15;
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 23);
            this.txtFinal.TabIndex = 30;
            this.txtFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFinal_KeyPress);
            // 
            // BtnDian
            // 
            this.BtnDian.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDian.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDian.Image = ((System.Drawing.Image)(resources.GetObject("BtnDian.Image")));
            this.BtnDian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDian.Location = new System.Drawing.Point(114, 108);
            this.BtnDian.Name = "BtnDian";
            this.BtnDian.Size = new System.Drawing.Size(126, 48);
            this.BtnDian.TabIndex = 120;
            this.BtnDian.Text = "Rango";
            this.BtnDian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDian.UseVisualStyleBackColor = false;
            this.BtnDian.Click += new System.EventHandler(this.BtnDian_Click);
            // 
            // FrmDian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 237);
            this.Controls.Add(this.BtnDian);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResoucion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.TxtInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDian";
            this.Text = "Dian";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResoucion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtInicial;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button BtnDian;
    }
}