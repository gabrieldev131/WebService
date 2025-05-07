using System.Collections.Generic;
using WebAluno;

namespace WebRequestDto {
    public class RequestAlunoXmlDto
    {
        // Lista de Alunos
        public List<Aluno> Alunos { get; set; }
        
        // Caminho para salvar o arquivo XML
        public string CaminhoArquivo { get; set; }

        // Construtor padrão
        public RequestAlunoXmlDto(){
            Alunos = [];
            CaminhoArquivo = string.Empty;
        }

        // Construtor com parâmetros
        public RequestAlunoXmlDto(List<Aluno> alunos, string caminhoArquivo){
            Alunos = alunos;
            CaminhoArquivo = caminhoArquivo;
        }
    }
}