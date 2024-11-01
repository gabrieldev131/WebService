using System.Collections.Generic;
using WebDisciplina;

namespace WebRequestDto {

    public class RequestDisciplinaXmlDto{
        // Lista de Alunos
        public List<Disciplina>? Disciplina { get; set; }

        // Caminho para salvar o arquivo XML
        public string? CaminhoArquivo { get; set; }

        // Construtor padrão
        public void RequestAlunoXmlDto() {
            Disciplina = [];
            CaminhoArquivo = string.Empty;
        }

        // Construtor com parâmetros
        public void RequestAlunoXmlDto(List<Disciplina> disciplina, string caminhoArquivo) {
            Disciplina = disciplina;
            CaminhoArquivo = caminhoArquivo;
        }
    }
}