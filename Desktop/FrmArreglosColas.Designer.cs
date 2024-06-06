namespace Desktop
{
    partial class FrmArreglosColas
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
            txtDatos = new TextBox();
            btnObtenerDatos = new Button();
            btnEliminar = new Button();
            btnIniciar = new Button();
            btnAgregar = new Button();
            txtAgregar = new TextBox();
            txtElementos = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(399, 25);
            txtDatos.Multiline = true;
            txtDatos.Name = "txtDatos";
            txtDatos.ReadOnly = true;
            txtDatos.ScrollBars = ScrollBars.Vertical;
            txtDatos.Size = new Size(389, 209);
            txtDatos.TabIndex = 11;
            txtDatos.TabStop = false;
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(28, 193);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(94, 29);
            btnObtenerDatos.TabIndex = 14;
            btnObtenerDatos.Text = "Obtener datos";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(28, 148);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(267, 58);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 9;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(270, 105);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(139, 105);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(125, 27);
            txtAgregar.TabIndex = 10;
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(255, 25);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(125, 27);
            txtElementos.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 7;
            label2.Text = "Dato a agregar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 8;
            label1.Text = "Introduce el numero de elementos";
            // 
            // FrmArreglosColas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDatos);
            Controls.Add(btnObtenerDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnIniciar);
            Controls.Add(btnAgregar);
            Controls.Add(txtAgregar);
            Controls.Add(txtElementos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmArreglosColas";
            Text = "FrmArreglosColas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDatos;
        private Button btnObtenerDatos;
        private Button btnEliminar;
        private Button btnIniciar;
        private Button btnAgregar;
        private TextBox txtAgregar;
        private TextBox txtElementos;
        private Label label2;
        private Label label1;
    }
}