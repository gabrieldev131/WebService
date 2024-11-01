namespace WebDisciplina {   
    public class Disciplina
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }

        public Disciplina() { }
        
        public Disciplina(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}