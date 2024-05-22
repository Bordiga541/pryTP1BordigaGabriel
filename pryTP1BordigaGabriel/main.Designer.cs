namespace pryTP1BordigaGabriel
{
    partial class main
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
            this.cmdReservar = new System.Windows.Forms.Button();
            this.cmdVerReservas = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdReservar
            // 
            this.cmdReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdReservar.Location = new System.Drawing.Point(36, 37);
            this.cmdReservar.Name = "cmdReservar";
            this.cmdReservar.Size = new System.Drawing.Size(311, 77);
            this.cmdReservar.TabIndex = 0;
            this.cmdReservar.Text = "RESERVAR";
            this.cmdReservar.UseVisualStyleBackColor = true;
            this.cmdReservar.Click += new System.EventHandler(this.cmdReservar_Click);
            // 
            // cmdVerReservas
            // 
            this.cmdVerReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerReservas.Location = new System.Drawing.Point(36, 160);
            this.cmdVerReservas.Name = "cmdVerReservas";
            this.cmdVerReservas.Size = new System.Drawing.Size(311, 77);
            this.cmdVerReservas.TabIndex = 0;
            this.cmdVerReservas.Text = "VER RESERVAS";
            this.cmdVerReservas.UseVisualStyleBackColor = true;
            this.cmdVerReservas.Click += new System.EventHandler(this.cmdVerReservas_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(36, 284);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(311, 77);
            this.cmdSalir.TabIndex = 0;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 403);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdVerReservas);
            this.Controls.Add(this.cmdReservar);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdReservar;
        private System.Windows.Forms.Button cmdVerReservas;
        private System.Windows.Forms.Button cmdSalir;
    }
}