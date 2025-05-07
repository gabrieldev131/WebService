using Factory;
using WebDisciplina;

namespace Factory {
    public class DisciplinaFabrica : AbstractFactory<Disciplina>
    {
        public DisciplinaFabrica()
        {
            // Define o namespace específico para disciplinas
            this.pacoteBase += ".WebDisciplina";
        }
    }
}
