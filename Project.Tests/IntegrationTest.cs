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
                nrVotes = 0,
                perVotes = 0
            },
            new CandidateParty
            {
                name = "Franz Beckenbauer",
                nrVotes = 0,
                perVotes = 0
            }
        ];

        Election expectedElectionTest = 
            new Election
            {
                totatVotes = 5,
                candidatesParties = candidatesPartiesTest,
                type = ElectionType.Presidential,
            };
        public void OrganizeElectionAndVoteCandidate_ExpectedVotes()
        {
            // Organizing the election
            hostManagerTest.AssignElectionType(electionType, electionTest);
            hostManagerTest.RegisterCandidates(candidatesPartiesTest, electionTest);
            // Voting for candidates
            string choice = "1";
            voteManagerTest.VoteForCandidate(choice, electionTest);
            choice = "2";
            voteManagerTest.VoteForCandidate(choice, electionTest);
            choice ="1";
            voteManagerTest.VoteForCandidate(choice, electionTest);
            choice = "2";
            voteManagerTest.VoteForCandidate(choice, electionTest);
            choice ="2";
            voteManagerTest.VoteForCandidate(choice, electionTest);
            // Calculating results
            voteManagerTest.CalcAndListPercentage(electionTest);

            // Assert
            Assert.Equal(expectedElectionTest,electionTest);
            Assert.Equal(2, candidatesPartiesTest[0].nrVotes);
            Assert.Equal(3, candidatesPartiesTest[1].nrVotes);
            Assert.Equal(40, candidatesPartiesTest[0].perVotes);
            Assert.Equal(60, candidatesPartiesTest[1].perVotes);
        }

    }
}