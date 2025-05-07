using Factory;
using WebAluno;

namespace Factory {
    public class AlunoFabrica : AbstractFactory<Aluno>
    {
        public AlunoFabrica()
        {
            // Define o namespace específico para alunos
            this.pacoteBase += ".Aluno";
        }
    }
}