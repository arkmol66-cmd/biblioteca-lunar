using System.Collections.Generic;
using System.Drawing;

namespace Lunar.Lib {
    public class SistemaFisica {
        public float Gravidade = 0.9f;
        public float VelocidadeQueda = 0;

        public Rectangle ProcessarGravidade(Rectangle obj, List<Rectangle> plataformas) {
            VelocidadeQueda += Gravidade;
            Rectangle proximoPos = obj;
            proximoPos.Y += (int)VelocidadeQueda;

            foreach (var chao in plataformas) {
                if (proximoPos.IntersectsWith(chao)) {
                    proximoPos.Y = chao.Y - obj.Height;
                    VelocidadeQueda = 0;
                }
            }
            return proximoPos;
        }
    }
}
