using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebRequestDto;
using WebAluno;
using WebDisciplina;
//using WebServiceException;
using Factory;
using WebEscolaService;
using WebXmlService;

public class Program {
    public static async Task Main(string[] args) {
        // Instanciar o serviço da Escola usando Singleton
        EscolaService escolaService = EscolaService.GetInstance();

        // Obter lista de alunos a partir da API
        List<Aluno>? alunos = await escolaService.ObterAlunosAsync();
        if (alunos != null)
        {
            // Criação do RequestAlunoXmlDto para passar a lista de alunos e o caminho do arquivo XML
            RequestAlunoXmlDto requestAluno = new RequestAlunoXmlDto
            {
                Alunos = alunos,
                CaminhoArquivo = "alunos.xml" // Caminho do arquivo XML
            };

            // Instanciar o serviço de XML e salvar os alunos
            XmlService xmlService = new();
            xmlService.SalvarAlunosEmXml(requestAluno);
        }
        else {
            Console.WriteLine("Não foi possível obter a lista de alunos.");
        }

        // Obter lista de disciplinas a partir da API
        List<Disciplina>? disciplinas = await escolaService.ObterDisciplinasAsync();
        if (disciplinas != null) {
            // Criação do RequestDisciplinaXmlDto para passar a lista de disciplinas e o caminho do arquivo XML
            RequestDisciplinaXmlDto requestDisciplina = new RequestDisciplinaXmlDto
            {
                Disciplina = disciplinas,
                CaminhoArquivo = "disciplinas.xml" // Caminho do arquivo XML
            };

            // Salvar as disciplinas em XML
            XmlService xmlService = new XmlService();
            xmlService.SalvarDisciplinasEmXml(requestDisciplina);
        }
        else {
            Console.WriteLine("Não foi possível obter a lista de disciplinas.");
        }
    }
}
