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

        public bool Vote(string cpf)
        {
            var candidate = candidates.FirstOrDefault(x => x.Cpf == cpf);
            if(candidate == null)
            {
                return false;
            }

            candidate.Vote();
            return true;
        }
        
        public Guid GetCandidateIdByName(string name)
        {
            return candidates.First(x => x.Name == name).Id;
        }

        public List<Candidate> GetCandidatesIdWithSameNames(string name)  
        {
            return candidates.Where(candidates => candidates.Name == name).ToList();
        }

        public Guid GetCandidateIdByCPF(string cpf)
        {
            return candidates.First(x => x.Cpf == cpf).Id;
        }

        public List<Candidate> GetWinners()
        {
            var winners = new List<Candidate>{candidates[0]};

            for (int i = 1; i < candidates.Count; i++)
            {
                if (candidates[i].Votes > winners[0].Votes)
                {
                    winners.Clear();
                    winners.Add(candidates[i]);
                }
                else if (candidates[i].Votes == winners[0].Votes)
                {
                    winners.Add(candidates[i]);
                }
            }
            return winners;
        }
    }
}