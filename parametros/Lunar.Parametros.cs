using System.Collections.Generic;

namespace Lunar.Lib {
    public class SistemaParametros {
        public Dictionary<string, float> Valores = new Dictionary<string, float>();
        public Dictionary<string, float> Maximos = new Dictionary<string, float>();

        public void Criar(string nome, float valorInicial) {
            Valores[nome] = valorInicial;
            Maximos[nome] = valorInicial;
        }

        public void Modificar(string nome, float qtd) {
            if (Valores.ContainsKey(nome)) {
                Valores[nome] += qtd;
                if (Valores[nome] > Maximos[nome]) Valores[nome] = Maximos[nome];
                if (Valores[nome] < 0) Valores[nome] = 0;
            }
        }
    }
}
