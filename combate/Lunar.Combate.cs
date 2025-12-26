using System.Drawing;

namespace Lunar.Lib {
    public class SistemaCombate {
        // Retorna 1 para dano no inimigo, 2 para dano no player, 0 para nada
        public int CalcularColisao(Rectangle p, Rectangle ini) {
            if (!p.IntersectsWith(ini)) return 0;

            // Lógica de pulo (se a base do player estiver acima do meio do inimigo)
            if (p.Y + p.Height < ini.Y + (ini.Height / 2)) {
                return 1; // Dano no Inimigo
            }
            return 2; // Dano no Player
        }
    }
}
