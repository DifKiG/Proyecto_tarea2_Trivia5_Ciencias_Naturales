namespace Trivia5
{
    partial class FormRspCorrect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRspCorrect));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BotonCerrarRespusesta = new System.Windows.Forms.Button();
            this.CaraFelizRsCorrect = new System.Windows.Forms.PictureBox();
            this.TituloRespCorrect = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.youWin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CaraFelizRsCorrect)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BotonCerrarRespusesta
            // 
            this.BotonCerrarRespusesta.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BotonCerrarRespusesta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrarRespusesta.Location = new System.Drawing.Point(404, 0);
            this.BotonCerrarRespusesta.Name = "BotonCerrarRespusesta";
            this.BotonCerrarRespusesta.Size = new System.Drawing.Size(27, 30);
            this.BotonCerrarRespusesta.TabIndex = 0;
            this.BotonCerrarRespusesta.Text = "X";
            this.BotonCerrarRespusesta.UseVisualStyleBackColor = false;
            this.BotonCerrarRespusesta.Click += new System.EventHandler(this.BotonCerrarRespusesta_Click);
            // 
            // CaraFelizRsCorrect
            // 
            this.CaraFelizRsCorrect.Image = ((System.Drawing.Image)(resources.GetObject("CaraFelizRsCorrect.Image")));
            this.CaraFelizRsCorrect.Location = new System.Drawing.Point(143, 98);
            this.CaraFelizRsCorrect.Name = "CaraFelizRsCorrect";
            this.CaraFelizRsCorrect.Size = new System.Drawing.Size(146, 130);
            this.CaraFelizRsCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CaraFelizRsCorrect.TabIndex = 1;
            this.CaraFelizRsCorrect.TabStop = false;
            // 
            // TituloRespCorrect
            // 
            this.TituloRespCorrect.AutoSize = true;
            this.TituloRespCorrect.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloRespCorrect.Location = new System.Drawing.Point(89, 46);
            this.TituloRespCorrect.Name = "TituloRespCorrect";
            this.TituloRespCorrect.Size = new System.Drawing.Size(252, 35);
            this.TituloRespCorrect.TabIndex = 2;
            this.TituloRespCorrect.Text = "¡Respuesta Correcta!";
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 292);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(433, 27);
            this.panelInferior.TabIndex = 5;
            // 
            // youWin
            // 
            this.youWin.AutoSize = true;
            this.youWin.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youWin.Location = new System.Drawing.Point(156, 241);
            this.youWin.Name = "youWin";
            this.youWin.Size = new System.Drawing.Size(122, 35);
            this.youWin.TabIndex = 6;
            this.youWin.Text = "¡You Win!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(406, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 265);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(27, 265);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.BotonCerrarRespusesta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 27);
            this.panel3.TabIndex = 9;
            // 
            // FormRspCorrect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(433, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.youWin);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.TituloRespCorrect);
            this.Controls.Add(this.CaraFelizRsCorrect);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRspCorrect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRspCorrect";
            ((System.ComponentModel.ISupportInitialize)(this.CaraFelizRsCorrect)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox CaraFelizRsCorrect;
        private System.Windows.Forms.Button BotonCerrarRespusesta;
        private System.Windows.Forms.Label TituloRespCorrect;
        private System.Windows.Forms.Label youWin;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}