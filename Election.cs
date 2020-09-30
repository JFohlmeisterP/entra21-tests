using System;
using System.Collections.Generic;
using System.Linq;

namespace entra21_tests
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        private List<(Guid id, string name, int votes, string cpf)> candidates { get; set; }

        private IReadOnlyCollection<(Guid id, string name, int votes, string cpf)> Candidates => candidates;
        
        public bool CreateCandidates(List<(string name, string cpf)> candidateData, string password)
        {
            if (password == "Pa$$w0rd")
            {
                candidates = candidateData.Select(candidate => {
                    return (Guid.NewGuid(), candidate.name, 0, candidate.cpf);
                }).ToList();

                return true;
            }
            else
            {
                return false;
            }
        }

        // ToDo: Criar método que retorne um Guid que represente o candidato pesquisado por CPF

        // ToDo: Este método deve retornar a lista de candidatos que tem o mesmo nome informado
        public Guid GetCandidateIdByName(string name)
        {
            return Candidates.First(x => x.name == name).id;
        }

         public List<(Guid id, string name, int votes, string cpf)> GetCandidatesIdWithSameNames(string name) => 
            Candidates.Where(candidates => candidates.name == name).ToList();

        public Guid GetCandidateIdByCPF(string cpf)
        {
            return Candidates.First(x => x.cpf == cpf).id;
        }

        public void Vote(Guid id)
        {
            candidates = Candidates.Select(candidate => {
                return candidate.id == id
                    ? (candidate.id, candidate.name, candidate.votes + 1, candidate.cpf)
                    : candidate;
            }).ToList();
        }

        public List<(Guid id, string name, int votes, string cpf)> GetWinners()
        {
            var winners = new List<(Guid id, string name, int votes, string cpf)>{candidates[0]};

            for (int i = 1; i < Candidates.Count; i++)
            {
                if (candidates[i].votes > winners[0].votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].votes == winners[0].votes)
                {
                    winners.Add(candidates[i]);
                }
            }
            return winners;
        }
    }
}