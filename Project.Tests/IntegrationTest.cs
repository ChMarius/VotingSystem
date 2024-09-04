namespace VotingSystem.Tests
{
    public class IntegrationTest
    {
        HostManager hostManagerTest = new();
        VoteManager voteManagerTest = new();
        Election electionTest = new();
        ElectionType electionType = ElectionType.Presidential;
        private static List<CandidateParty> candidatesPartiesTest = [

            new CandidateParty
            {
                name = "Arda Calhanoglu",
            },
            new CandidateParty
            {
                name = "Franz Beckenbauer",
            }
        ];
        Election expectedElectionTest = 
            new Election
            {
                totatVotes = 5,
                candidatesParties = candidatesPartiesTest,
                type = ElectionType.Presidential,
            };
        [Fact]
        public void OrganizeElectionAndVoteCandidate_ExpectedVotes()
        {
            // Organizing the election
            hostManagerTest.AssignElectionType(electionType, ref electionTest);
            hostManagerTest.RegisterCandidates(candidatesPartiesTest, ref electionTest);
            // Voting for candidates
            string choice = "1";
            voteManagerTest.VoteForCandidate(choice, ref electionTest);
            choice = "2";
            voteManagerTest.VoteForCandidate(choice, ref electionTest);
            choice ="1";
            voteManagerTest.VoteForCandidate(choice, ref electionTest);
            choice = "2";
            voteManagerTest.VoteForCandidate(choice, ref electionTest);
            choice ="2";
            voteManagerTest.VoteForCandidate(choice, ref electionTest);
            // Calculating results
            voteManagerTest.CalcAndListPercentage(ref electionTest);

            // Assert
            Assert.Equal(expectedElectionTest.totatVotes,electionTest.totatVotes);
            Assert.Equal(2, electionTest.candidatesParties[0].nrVotes);
            Assert.Equal(3, electionTest.candidatesParties[1].nrVotes);
            Assert.Equal(40, electionTest.candidatesParties[0].perVotes);
            Assert.Equal(60, electionTest.candidatesParties[1].perVotes);
        }

    }
}