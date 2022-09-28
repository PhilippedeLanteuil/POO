using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtor_aula_12
{
    class Funcionario
    {
        private int matricula;
        private string nome;
        public Funcionario()
        {
            matricula = 00;
            nome = "Nome";
        }
        public Funcionario(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getMatricula()
        {
            return this.matricula;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void ImprimeValores()
        {
            Console.WriteLine("Nome funcionário: " + nome);
            Console.WriteLine("Matrícula funcionário: " + matricula);
        }
        ~Funcionario()
        {
            Console.WriteLine("Método Destrutor");
            Console.ReadKey();
        }
    }
}
