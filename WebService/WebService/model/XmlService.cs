using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using WebRequestDto;
using WebAluno;
using WebDisciplina;

namespace WebXmlService {
    public class XmlService
    {
        // Método para salvar a lista de alunos em um arquivo XML
        public void SalvarAlunosEmXml(RequestAlunoXmlDto requestAluno)
        {
            try
            {
                if (string.IsNullOrEmpty(requestAluno.CaminhoArquivo))
                {
                    throw new ArgumentException("O caminho do arquivo não pode ser nulo ou vazio.", nameof(requestAluno.CaminhoArquivo));
                }
                // Serializador para a lista de Alunos
                XmlSerializer serializer = new(typeof(List<Aluno>));

                // Usar o caminho do arquivo fornecido pelo objeto requestAluno
                using (StreamWriter writer = new(requestAluno.CaminhoArquivo))
                {
                    // Serializando a lista de alunos
                    serializer.Serialize(writer, requestAluno.Alunos);
                }

                Console.WriteLine($"Arquivo XML de alunos salvo em: {requestAluno.CaminhoArquivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar alunos em XML: {ex.Message}");
            }
        }

        // Método para salvar a lista de disciplinas em um arquivo XML
        public void SalvarDisciplinasEmXml(RequestDisciplinaXmlDto requestDisciplina)
        {
            try
            {
                if (string.IsNullOrEmpty(requestDisciplina.CaminhoArquivo))
                {
                    throw new ArgumentException("O caminho do arquivo não pode ser nulo ou vazio.", nameof(requestDisciplina.CaminhoArquivo));
                }

                // Serializador para a lista de Disciplinas
                XmlSerializer serializer = new(typeof(List<Disciplina>));
                
                // Usar o caminho do arquivo fornecido pelo objeto requestDisciplina
                using (StreamWriter writer = new(requestDisciplina.CaminhoArquivo))
                {
                    // Serializando a lista de disciplinas
                    serializer.Serialize(writer, requestDisciplina.Disciplina);
                }
                
                Console.WriteLine($"Arquivo XML de disciplinas salvo em: {requestDisciplina.CaminhoArquivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar disciplinas em XML: {ex.Message}");
            }
        }

    }
}