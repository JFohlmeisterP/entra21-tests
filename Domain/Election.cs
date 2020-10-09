using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Election
    {
        // Propriedade abaixo:
        // Sempre em PascalCase
        private List<Candidate> candidates { get; set; }

        public IReadOnlyCollection<Candidate> Candidates => candidates;
        
        public bool CreateCandidates(List<Candidate> candidateData, string password)
        {
            if (password == "Pa$$w0rd")
            {
                candidates = candidateData;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public Guid GetCandidateIdByName(string name)
        {
            return candidates.First(x => x.name == name).id;
        }

        public List<Candidate> GetCandidatesIdWithSameNames(string name)  
        {
            return candidates.Where(candidates => candidates.name == name).ToList();
        }

        public Guid GetCandidateIdByCPF(string cpf)
        {
            return candidates.First(x => x.cpf == cpf).id;
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{candidates[0]};

            for (int i = 1; i < candidates.Count; i++)
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