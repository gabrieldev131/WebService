namespace WebAluno {
    
    public class Aluno
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }

        public Aluno() { }
        
        public Aluno(int id, string nome, string endereco)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}