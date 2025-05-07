using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebAluno;
using WebDisciplina;

namespace WebEscolaService {
    public class EscolaService
    {
        private static EscolaService? _instance;
        private static readonly object _lock = new object(); // Para garantir segurança em multithread
        private static readonly string BaseUrl = "http://localhost:3000/";
        private static HttpClient? _httpClient;

        // Construtor privado para impedir a criação direta de instâncias
        private EscolaService()
        {
            _httpClient = new HttpClient();
        }

        // Método para obter a única instância (Singleton)
        public static EscolaService GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)  // Garantir que uma única instância seja criada em um ambiente multithread
                {
                    if (_instance == null)
                    {
                        _instance = new EscolaService();
                    }
                }
            }
            return _instance;
        }

        // Método para obter a lista de alunos
        public async Task<List<Aluno>?> ObterAlunosAsync()
        {
            try
            {
                _httpClient = new HttpClient();
                HttpResponseMessage response = await _httpClient.GetAsync($"{BaseUrl}alunos");
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<Aluno>? alunos = JsonConvert.DeserializeObject<List<Aluno>>(jsonResponse);
                return alunos;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter alunos: {ex.Message}");
                return null;
            }
        }

        // Método para obter a lista de disciplinas
        public async Task<List<Disciplina>?> ObterDisciplinasAsync()
        {
            try
            {
                _httpClient = new HttpClient();
                HttpResponseMessage response = await _httpClient.GetAsync($"{BaseUrl}disciplinas");
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<Disciplina>? disciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(jsonResponse);
                return disciplinas;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter disciplinas: {ex.Message}");
                return null;
            }
        }
    }
}