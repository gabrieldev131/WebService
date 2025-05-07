    
namespace WebRequestDto {    
    public class RequestDtoAluno{
    
        public int? Id { get; set; }          // Identificador do Aluno
        public string? Nome { get; set; }     // Nome do Aluno
        public string? Endereco { get; set; } // Endereço do Aluno

        // Construtor padrão
        public RequestDtoAluno() {}

        // Construtor opcional para facilitar a criação de instâncias
        public RequestDtoAluno(int id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }

        // Método opcional para exibir dados de Aluno (útil para testes)
        public override string ToString()
        {
            return $"Aluno ID: {Id}, Nome: {Nome}, Endereço: {Endereco}";
        }
    }
}