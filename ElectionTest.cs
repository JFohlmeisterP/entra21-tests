using System.Collections.Generic;
using Xunit;

namespace entra21_tests
{
    public class ElectionTest
    {
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var candidateData = new List<(string name, string cfp)>{("José", "009.923.970-14"), ("José", "852.710.650-73")};

            // Quando / Ação
            var created = election.CreateCandidates(candidateData, "incorrect");

            // Deve / Asserções
            Assert.Null(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            string candidate = "José";
            var candidateData = new List<(string name, string cpf)>{("José", "009.923.970-14"), ("José", "852.710.650-73")};

            // Quando / Ação

            // Estamos acessando o MÉTODO CreateCandidates do OBJETO election
            var created = election.CreateCandidates(candidateData, "Pa$$w0rd");

            // Deve / Asserções
            Assert.True(created);
            
            // Estamos acessando a PROPRIEDADE Candidates, que faz parte do ESTADO do OBJETO election
            Assert.Equal(2, election.Candidates.Count);
            Assert.Equal(candidate, election.Candidates[0].name);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();
            var candidateData = new List<(string name, string cpf)>{("José", "009.923.970-14"), ("Ana", "852.710.650-73")};
            election.CreateCandidates(candidateData, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateJose = election.GetCandidateIdByName("José");
            var candidateAna = election.GetCandidateIdByName("Ana");

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }

        [Fact]
        public void should_return_id_by_cpf()
        {
           var election = new Election();

           var candidateData = new List<(string name, string cpf)>{("José", "009.923.970-14"), ("José", "852.710.650-73")};
           election.CreateCandidates(candidateData, "Pa$$w0rd");

           var candidate = election.GetCandidateIdByCPF("852.710.650-73");

           Assert.Equal(candidate, election.Candidates[1].id);
        }

        [Fact]
        public void should_return_differents_id_for_same_names()
        {
            // Dado / Setup

            // OBJETO election
            var election = new Election();

            var candidates = new List<(string name, string cpf)> { ("josé", "123.456.761-00"), ("josé", "856.876.32-23") };
            election.CreateCandidates(candidates, "Pa$$w0rd");

            // Quando / Ação
            var candidatesSameName = election.GetCandidatesIdWithSameNames("josé");

            // Deve / Asserções
            Assert.NotEqual(candidatesSameName[0], candidatesSameName[1]);
        }


        [Fact]
        public void should_vote_twice_in_candidate_José()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();

            var candidateData = new List<(string name, string cpf)>{("José", "009.923.970-14"), ("Ana", "852.710.650-73")};

            election.CreateCandidates(candidateData, "Pa$$w0rd");

            var joseId = election.GetCandidateIdByName("José");

            var anaId = election.GetCandidateIdByName("Ana");

            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(joseId);
            election.Vote(joseId);

            // Deve / Asserções
            var candidateJose = election.Candidates.Find(x => x.id == joseId);
            var candidateAna = election.Candidates.Find(x => x.id == anaId);
            Assert.Equal(2, candidateJose.votes);
            Assert.Equal(0, candidateAna.votes);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var candidateData = new List<(string name, string cpf)>{("José", "009.923.970-14"), ("Ana", "852.710.650-73")};
            election.CreateCandidates(candidateData, "Pa$$w0rd");
            var anaId = election.GetCandidateIdByName("Ana");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(anaId);
            var winners = election.GetWinners();

            // Deve / Asserções
            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].id);
            Assert.Equal(2, winners[0].votes);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var candidateData = new List<(string name, string cpf)>{("José", "009.923.970-14"), ("Ana", "852.710.650-73")};
            election.CreateCandidates(candidateData, "Pa$$w0rd");
            var joseId = election.GetCandidateIdByName("José");
            var anaId = election.GetCandidateIdByName("Ana");
            
            // Quando / Ação
            // Estamos acessando o MÉTODO ShowMenu do OBJETO election
            election.Vote(anaId);
            election.Vote(joseId);
            var winners = election.GetWinners();

            // Deve / Asserções
            var candidateJose = winners.Find(x => x.id == joseId);
            var candidateAna = winners.Find(x => x.id == anaId);
            Assert.Equal(1, candidateJose.votes);
            Assert.Equal(1, candidateAna.votes);
        }
    }
}
