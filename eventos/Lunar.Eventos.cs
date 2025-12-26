using System;
using System.Windows.Forms;

namespace Lunar.Lib {
    public class SistemaEventos {
        public void VerificarVitoria(int xAtual, int xObjetivo) {
            if (xAtual >= xObjetivo) {
                MessageBox.Show("Missão Cumprida! Você venceu.");
                Environment.Exit(0);
            }
        }

        public void NotificarMorte(string quem) {
            MessageBox.Show(quem + " foi derrotado!");
        }
    }
}
