using System.Collections.Generic;
using System.Linq;
using Xunit;
using Domain;

namespace Test
{
    public class ElectionTest
    {   
        [Fact]
        public void should_not_create_candidates_when_password_is_incorrect()
        {
            // Dado / Setup
            var election = new Election();
            var candidate = new List<Candidate> {new Candidate ("José", "009.923.970-14")};

            // Quando / Ação
            var created = election.CreateCandidates(candidate, "incorrect");

            // Deve / Asserções
            Assert.Null(election.Candidates);
            Assert.False(created);
        }

        [Fact]
        public void should_create_candidates_when_password_is_correct()
        {
            var election = new Election();
            var candidates = new List<Candidate> {new Candidate ("José", "009.923.970-14"), new Candidate ("Ana", "852.710.650-73")};

            var created = election.CreateCandidates(candidates, "Pa$$w0rd");

            var candidateJose = election.GetCandidateIdByName("José");
            var candidateAna = election.GetCandidateIdByName("Ana");

            Assert.True(created);
            
            Assert.Equal(2, election.Candidates.Count);
            Assert.NotEqual(candidateJose, candidateAna);
        }

        [Fact]
        public void should_not_generate_same_id_for_both_candidates()
        {
            var election = new Election();
            var candidates = new List<Candidate> {new Candidate ("José", "009.923.970-14"), new Candidate ("Ana", "852.710.650-73")};
            election.CreateCandidates(candidates, "Pa$$w0rd");
            
            // Quando / Ação
            var candidateJose = election.Candidates.ElementAt(0).Id;
            var candidateAna = election.Candidates.ElementAt(1).Id;

            // Deve / Asserções
            Assert.NotEqual(candidateAna, candidateJose);
        }

        [Fact]
        public void should_return_id_by_cpf()
        {
           var election = new Election();

           var candidates = new List<Candidate> {new Candidate ("José", "009.923.970-14"), new Candidate ("José", "852.710.650-73")};
           election.CreateCandidates(candidates, "Pa$$w0rd");

           var candidate = election.GetCandidateIdByCPF("852.710.650-73");

           Assert.Equal(candidate, election.Candidates.ElementAt(1).Id);
        }

        [Fact]
        public void should_return_differents_id_for_same_names()
        {
            var election = new Election();

            var candidates = new List<Candidate> {new Candidate ("José", "009.923.970-14"), new Candidate ("José", "852.710.650-73")};
            election.CreateCandidates(candidates, "Pa$$w0rd");

            var candidatesSameName = election.GetCandidatesIdWithSameNames("José");

            Assert.NotEqual(candidatesSameName[0], candidatesSameName[1]);
        }


        [Fact]
        public void should_vote_twice_in_candidate_José()
        {
            var election = new Election();

            var jose = new Candidate ("José", "009.923.970-14");
            var ana = new Candidate ("Ana", "852.710.650-73");

            var candidates = new List<Candidate>() {jose, ana};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            var joseId = election.GetCandidateIdByName(jose.Name);
            var anaId = election.GetCandidateIdByName(ana.Name);

            jose.Vote();
            jose.Vote();

            var candidateJose = election.Candidates.First(x => x.Id == joseId);
            var candidateAna = election.Candidates.First(x => x.Id == anaId);
            Assert.Equal(2, candidateJose.Votes);
            Assert.Equal(0, candidateAna.Votes);
        }

        [Fact]
        public void Should_return_false_and_not_vote_when_CPF_is_invalid()
        {
            // Dado / Setup
            // OBJETO election
            var election = new Election();
            var Jose = new Candidate("José", "895.456.214-78");
            var candidates = new List<Candidate>{Jose};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            // Quando / Ação
            var voteResult = election.Vote("1321");

            // Deve / Asserções
            var candidateJose = election.Candidates.First(x => x.Id == Jose.Id);
            Assert.Equal(0, candidateJose.Votes);
            Assert.False(voteResult);
        }

        [Fact]
        public void should_return_Ana_as_winner_when_only_Ana_receives_votes()
        {
            var election = new Election();

            var ana = new Candidate ("Ana", "852.710.650-73");
            var jose = new Candidate("José", "077.286.334-18");

            var candidates = new List<Candidate>() {ana, jose};

            election.CreateCandidates(candidates, "Pa$$w0rd");

            var anaId = election.GetCandidateIdByName("Ana");

            ana.Vote();
            ana.Vote();

            var winners = election.GetWinners();

            Assert.Equal(1, winners.Count);
            Assert.Equal(anaId, winners[0].Id);
        }

        [Fact]
        public void should_return_both_candidates_when_occurs_draw()
        {
            var election = new Election();
        
            var jose = new Candidate ("José", "009.923.970-14");
            var ana = new Candidate ("Ana", "852.710.650-73");

            var candidates = new List<Candidate> {jose, ana};

            election.CreateCandidates(candidates, "Pa$$w0rd");
            var joseId = election.GetCandidateIdByName("José");
            var anaId = election.GetCandidateIdByName("Ana");

            ana.Vote();
            jose.Vote();

            var winners = election.GetWinners();

            var candidateJose = winners.Find(x => x.Id == joseId);
            var candidateAna = winners.Find(x => x.Id == anaId);
            Assert.Equal(1, candidateJose.Votes);
            Assert.Equal(1, candidateAna.Votes);
        }
    }
}
