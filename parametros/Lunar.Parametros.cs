using System;
using System.Collections.Generic;

namespace Lunar.Lib {
    public class SistemaParametros {
        public Dictionary<string, float> Atributos = new Dictionary<string, float>();
        public Dictionary<string, float> AtributosMax = new Dictionary<string, float>();

        // Comando: parametro [nome] = [valor]
        public void Definir(string nome, float valor) {
            Atributos[nome] = valor;
            AtributosMax[nome] = valor;
        }

        public void Modificar(string nome, float quantidade) {
            if (Atributos.ContainsKey(nome)) {
                Atributos[nome] = Math.Clamp(Atributos[nome] + quantidade, 0, AtributosMax[nome]);
            }
        }

        public float Consultar(string nome) => Atributos.ContainsKey(nome) ? Atributos[nome] : 0;
    }
}
