using System;
using System.Media;
using System.Windows.Forms;

namespace Trivia5
{
    public partial class FormRespIncorrecta : Form
    {
        public FormRespIncorrecta()
        {
            InitializeComponent();
            Sonido();
        }

        private void BotonCerrarRespusesta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para establecer ruta de sonido incorrecto
        String rutaSonido = "C:/Proyecto_tarea2_Trivia5_Ciencias_Naturales/Proyecto_tarea2_Trivia5_Ciencias_Naturales/sonidos/incorrecto.wav";
                                
        private void Sonido() 
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = rutaSonido;
            player.Play();
        }
    }
}
