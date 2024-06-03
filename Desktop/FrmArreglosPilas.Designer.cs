namespace Desktop
{
    partial class FrmArreglosPilas
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
            label1 = new Label();
            txtElementos = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnObtenerDatos = new Button();
            textBox1 = new TextBox();
            txtDatos = new TextBox();
            btnIniciar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduce el numero de elementos";
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(255, 18);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(125, 27);
            txtElementos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(270, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(28, 141);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(28, 186);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(94, 29);
            btnObtenerDatos.TabIndex = 5;
            btnObtenerDatos.Text = "Obtener datos";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(399, 18);
            txtDatos.Multiline = true;
            txtDatos.Name = "txtDatos";
            txtDatos.ReadOnly = true;
            txtDatos.ScrollBars = ScrollBars.Vertical;
            txtDatos.Size = new Size(389, 209);
            txtDatos.TabIndex = 3;
            txtDatos.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(267, 51);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 0;
            label2.Text = "Dato a agregar";
            // 
            // FrmArreglosPilas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDatos);
            Controls.Add(btnObtenerDatos);
            Controls.Add(btnEliminar);
            Controls.Add(btnIniciar);
            Controls.Add(btnAgregar);
            Controls.Add(textBox1);
            Controls.Add(txtElementos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmArreglosPilas";
            Text = "1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtElementos;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnObtenerDatos;
        private TextBox textBox1;
        private TextBox txtDatos;
        private Button btnIniciar;
        private Label label2;
    }
}