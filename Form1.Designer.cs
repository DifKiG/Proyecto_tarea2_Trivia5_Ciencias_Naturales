namespace Trivia5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textoBienvenida = new System.Windows.Forms.Label();
            this.cerrarJuego = new System.Windows.Forms.Label();
            this.tematicaTrivia = new System.Windows.Forms.Label();
            this.ImagenLogoTrivia = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.BotonIniciarTrivia = new System.Windows.Forms.Button();
            this.MoverFormulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogoTrivia)).BeginInit();
            this.panelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoBienvenida
            // 
            this.textoBienvenida.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textoBienvenida.AutoSize = true;
            this.textoBienvenida.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBienvenida.Location = new System.Drawing.Point(125, 58);
            this.textoBienvenida.Name = "textoBienvenida";
            this.textoBienvenida.Size = new System.Drawing.Size(500, 48);
            this.textoBienvenida.TabIndex = 0;
            this.textoBienvenida.Text = "Juego de Trivias Bienvenidos";
            // 
            // cerrarJuego
            // 
            this.cerrarJuego.AutoSize = true;
            this.cerrarJuego.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cerrarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarJuego.Location = new System.Drawing.Point(-4, 0);
            this.cerrarJuego.Name = "cerrarJuego";
            this.cerrarJuego.Size = new System.Drawing.Size(27, 25);
            this.cerrarJuego.TabIndex = 1;
            this.cerrarJuego.Text = "X";
            this.cerrarJuego.Click += new System.EventHandler(this.CerrarJuego_Click);
            // 
            // tematicaTrivia
            // 
            this.tematicaTrivia.AutoSize = true;
            this.tematicaTrivia.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tematicaTrivia.Location = new System.Drawing.Point(173, 121);
            this.tematicaTrivia.Name = "tematicaTrivia";
            this.tematicaTrivia.Size = new System.Drawing.Size(407, 42);
            this.tematicaTrivia.TabIndex = 2;
            this.tematicaTrivia.Text = "Temática Ciencias Naturales";
            // 
            // ImagenLogoTrivia
            // 
            this.ImagenLogoTrivia.Image = ((System.Drawing.Image)(resources.GetObject("ImagenLogoTrivia.Image")));
            this.ImagenLogoTrivia.Location = new System.Drawing.Point(263, 166);
            this.ImagenLogoTrivia.Name = "ImagenLogoTrivia";
            this.ImagenLogoTrivia.Size = new System.Drawing.Size(225, 187);
            this.ImagenLogoTrivia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenLogoTrivia.TabIndex = 3;
            this.ImagenLogoTrivia.TabStop = false;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 426);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(750, 24);
            this.panelInferior.TabIndex = 4;
            // 
            // BotonIniciarTrivia
            // 
            this.BotonIniciarTrivia.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BotonIniciarTrivia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonIniciarTrivia.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIniciarTrivia.Location = new System.Drawing.Point(285, 368);
            this.BotonIniciarTrivia.Name = "BotonIniciarTrivia";
            this.BotonIniciarTrivia.Size = new System.Drawing.Size(184, 39);
            this.BotonIniciarTrivia.TabIndex = 6;
            this.BotonIniciarTrivia.Text = "Iniciar Juego";
            this.BotonIniciarTrivia.UseVisualStyleBackColor = false;
            this.BotonIniciarTrivia.Click += new System.EventHandler(this.BotonIniciarTrivia_Click);
            // 
            // MoverFormulario
            // 
            this.MoverFormulario.Fixed = true;
            this.MoverFormulario.Horizontal = true;
            this.MoverFormulario.TargetControl = this;
            this.MoverFormulario.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 426);
            this.panel1.TabIndex = 7;
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelDerecho.Controls.Add(this.cerrarJuego);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(727, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(23, 426);
            this.panelDerecho.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(23, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 24);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotonIniciarTrivia);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.ImagenLogoTrivia);
            this.Controls.Add(this.tematicaTrivia);
            this.Controls.Add(this.textoBienvenida);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de preguntas";
            ((System.ComponentModel.ISupportInitialize)(this.ImagenLogoTrivia)).EndInit();
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoBienvenida;
        private System.Windows.Forms.Label cerrarJuego;
        private System.Windows.Forms.Label tematicaTrivia;
        private System.Windows.Forms.PictureBox ImagenLogoTrivia;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button BotonIniciarTrivia;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal Bunifu.Framework.UI.BunifuDragControl MoverFormulario;
    }
}

