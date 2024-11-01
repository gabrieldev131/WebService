
namespace WebRequestDto {
    public class RequestDtoDisciplina
    {
        public int? Id { get; set; }          // Identificador do Aluno
        public string? Nome { get; set; }     // Nome do Aluno
        public string? Descricao { get; set; } // Endereço do Aluno

        // Construtor padrão
        public RequestDtoDisciplina() {}

        // Construtor opcional para facilitar a criação de instâncias
        public RequestDtoDisciplina(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

        // Método opcional para exibir dados de Aluno (útil para testes)
        public string DisciplinaToString()
        {
            return $"Aluno ID: {Id}, Nome: {Nome}, Endereço: {Descricao}";
        }
    }
}