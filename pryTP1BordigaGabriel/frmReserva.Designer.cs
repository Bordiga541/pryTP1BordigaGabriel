namespace pryTP1BordigaGabriel
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.label1 = new System.Windows.Forms.Label();
            this.cmdQuenaken = new System.Windows.Forms.Button();
            this.cmdOnas = new System.Windows.Forms.Button();
            this.cmdTobas = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local al cual se quiere reservar:";
            // 
            // cmdQuenaken
            // 
            this.cmdQuenaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQuenaken.Location = new System.Drawing.Point(100, 64);
            this.cmdQuenaken.Name = "cmdQuenaken";
            this.cmdQuenaken.Size = new System.Drawing.Size(194, 49);
            this.cmdQuenaken.TabIndex = 1;
            this.cmdQuenaken.Text = "Local Quenaken";
            this.cmdQuenaken.UseVisualStyleBackColor = true;
            this.cmdQuenaken.Click += new System.EventHandler(this.cmdQuenaken_Click);
            // 
            // cmdOnas
            // 
            this.cmdOnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOnas.Location = new System.Drawing.Point(100, 142);
            this.cmdOnas.Name = "cmdOnas";
            this.cmdOnas.Size = new System.Drawing.Size(194, 49);
            this.cmdOnas.TabIndex = 1;
            this.cmdOnas.Text = "Local Onas";
            this.cmdOnas.UseVisualStyleBackColor = true;
            this.cmdOnas.Click += new System.EventHandler(this.cmdOnas_Click);
            // 
            // cmdTobas
            // 
            this.cmdTobas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTobas.Location = new System.Drawing.Point(100, 219);
            this.cmdTobas.Name = "cmdTobas";
            this.cmdTobas.Size = new System.Drawing.Size(194, 49);
            this.cmdTobas.TabIndex = 1;
            this.cmdTobas.Text = "Local Tobas";
            this.cmdTobas.UseVisualStyleBackColor = true;
            this.cmdTobas.Click += new System.EventHandler(this.cmdTobas_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Image = ((System.Drawing.Image)(resources.GetObject("cmdVolver.Image")));
            this.cmdVolver.Location = new System.Drawing.Point(353, 247);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(34, 37);
            this.cmdVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdVolver.TabIndex = 2;
            this.cmdVolver.TabStop = false;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 288);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdTobas);
            this.Controls.Add(this.cmdOnas);
            this.Controls.Add(this.cmdQuenaken);
            this.Controls.Add(this.label1);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReserva";
            ((System.ComponentModel.ISupportInitialize)(this.cmdVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdQuenaken;
        private System.Windows.Forms.Button cmdOnas;
        private System.Windows.Forms.Button cmdTobas;
        private System.Windows.Forms.PictureBox cmdVolver;
    }
}