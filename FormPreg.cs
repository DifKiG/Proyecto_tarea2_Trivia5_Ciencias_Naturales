using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia5
{
    public partial class FormPreg : Form
    {
        public FormPreg()
        {
            InitializeComponent();
            panelPreg2.Hide();
            panelPreg3.Hide();
            panelFinalPuntaje.Hide();
        }

        int puntos = 0;
        
        void RespIncorrecta()
        {
            FormRespIncorrecta formRspInco = new FormRespIncorrecta();
            formRspInco.ShowDialog();
            restarPuntos();
        }

        void RspCorrecta()
        {
            FormRspCorrect formRsp = new FormRspCorrect();
            formRsp.ShowDialog();
            sumarPuntos();
        }

        #region Algoritmo que da la logica a la cantidad de puntos
        void sumarPuntos()
        {
            puntos = puntos + 100;
            CantidadPuntos.Text = puntos.ToString();
        }

        void restarPuntos() 
        {
            if (puntos >= 100)
            {
                puntos = puntos - 20;
            }
            CantidadPuntos.Text = puntos.ToString();
        }
        #endregion

        #region Paneles Preguntas 1, 2 y 3      
        private void btn1RespuIncorr_Click(object sender, EventArgs e)
        {
            RespIncorrecta();
        }

        private void btn2RespuCorrect_Click(object sender, EventArgs e)
        {
            RspCorrecta() ;
            panelPreg2.Show();
        }

        private void btn3RespuIncorr_Click(object sender, EventArgs e)
        {
            RespIncorrecta();
        }

        private void BtnCanabis_Click(object sender, EventArgs e)
        {
            RespIncorrecta();
        }

        private void BtnCoca_Click(object sender, EventArgs e)
        {
            RespIncorrecta();
        }

        private void BtnAmapola_Click(object sender, EventArgs e)
        {
            RspCorrecta();
            panelPreg3.Show();
        }

        private void ChinaIncorrect_Click(object sender, EventArgs e)
        {
            RespIncorrecta();
        }

        private void BrasilIncorrec_Click(object sender, EventArgs e)
        {
            RespIncorrecta();
        }

        private void ColombiaCorrect_Click(object sender, EventArgs e)
        {
            RspCorrecta();
            panelFinalPuntaje.Show();
            CantPuntosActual.Hide();
            CantidadPuntos.Hide();

            TotalPuntajeNumero.Text = puntos.ToString();
        }
        #endregion

        private void CerrarFormPreg_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
    }

}
