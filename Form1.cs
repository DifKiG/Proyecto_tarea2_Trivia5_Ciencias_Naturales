using System;
using System.Windows.Forms;

namespace Trivia5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /*Se crea el siguiente evento para establecer el inicio 
         * del juego y ademas cerrar la primera página de presentación*/
        private void BotonIniciarTrivia_Click(object sender, EventArgs e)
        {
            FormPreg formPreg = new FormPreg();
            formPreg.Show();
            this.Hide();

        }
        
        /*Este evento cierra la pagina de bienvenida del juego*/
        private void CerrarJuego_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
