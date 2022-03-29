using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        private int capacidadeMax;
        private int ttAndares;
        private int quantPessoas = 0;
        private int andarAtual = 1;

        public void Inicializar(int capacidade, int andares)
        {
            this.capacidadeMax = capacidade;
            this.ttAndares = andares;
        }

        public void Entrar()
        {
            if (this.quantPessoas == this.capacidadeMax)
            {
                Console.WriteLine("CAPACIDADE MÁXIMA ATINGIDA");
            }else
            {
                this.quantPessoas += 1;
                Console.WriteLine($"Pessoas no Elevador: {this.quantPessoas}");
            }
        }

        public void Sair()
        {
            if (this.quantPessoas == 0)
            {
                Console.WriteLine("ELEVADOR VAZIO");
            }else
            {
                this.quantPessoas -= 1;
                Console.WriteLine($"Pessoas no Elevador: {this.quantPessoas}");
            }
        }

        public void Subir()
        {
            if (this.andarAtual == this.ttAndares)
            {
                Console.WriteLine("LIMITE ATINGIDO");
            }else
            {
                this.andarAtual += 1;
                Console.WriteLine($"Andar Atual: {this.andarAtual}");
            }
        }

        public void Descer()
        {
            if (this.andarAtual == 1)
            {
                Console.WriteLine("NÃO EXISTE ANDARES ABAIXO");
            } else
            {
                this.andarAtual += 1;
                Console.WriteLine($"Andar Atual: {this.andarAtual}");
            }
        }

    }
}
