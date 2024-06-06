namespace Desktop
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnArreglosPilas = new Button();
            btnListas = new Button();
            btnArreglosColas = new Button();
            SuspendLayout();
            // 
            // btnArreglosPilas
            // 
            btnArreglosPilas.Location = new Point(60, 53);
            btnArreglosPilas.Name = "btnArreglosPilas";
            btnArreglosPilas.Size = new Size(94, 29);
            btnArreglosPilas.TabIndex = 0;
            btnArreglosPilas.Text = "Pilas";
            btnArreglosPilas.UseVisualStyleBackColor = true;
            btnArreglosPilas.Click += btnArreglos_Click;
            // 
            // btnListas
            // 
            btnListas.Location = new Point(60, 122);
            btnListas.Name = "btnListas";
            btnListas.Size = new Size(94, 29);
            btnListas.TabIndex = 0;
            btnListas.Text = "Listas";
            btnListas.UseVisualStyleBackColor = true;
            // 
            // btnArreglosColas
            // 
            btnArreglosColas.Location = new Point(199, 53);
            btnArreglosColas.Name = "btnArreglosColas";
            btnArreglosColas.Size = new Size(94, 29);
            btnArreglosColas.TabIndex = 0;
            btnArreglosColas.Text = "Colas";
            btnArreglosColas.UseVisualStyleBackColor = true;
            btnArreglosColas.Click += this.btnArreglos_Click1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListas);
            Controls.Add(btnArreglosColas);
            Controls.Add(btnArreglosPilas);
            Name = "FrmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnArreglosPilas;
        private Button btnListas;
        private Button btnArreglosColas;
    }
}
