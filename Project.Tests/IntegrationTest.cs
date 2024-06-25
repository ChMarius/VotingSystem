namespace VotingSystem.Tests
{
    public class IntegrationTest
    {
        HostManager hostManagerTest = new();
        VoteManager voteManagerTest = new();
        Election election = new();
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

        Election expectedElection = 
            new Election
            {
                totatVotes = 5,
                candidatesParties = candidatesPartiesTest,
                type = ElectionType.Presidential,
            };
        public void OrganizeElectionAndVoteCandidate_ExpectedVotes()
        {
            // Organizing the election
            hostManagerTest.AssignElectionType(election, electionType);
            hostManagerTest.RegisterCandidates(election, candidatesPartiesTest);
            // Voting for candidates
            voteManagerTest.VoteForCandidate(election, candidatesPartiesTest[0]);
            voteManagerTest.VoteForCandidate(election, candidatesPartiesTest[1]);
            voteManagerTest.VoteForCandidate(election, candidatesPartiesTest[0]);
            voteManagerTest.VoteForCandidate(election, candidatesPartiesTest[1]);
            voteManagerTest.VoteForCandidate(election, candidatesPartiesTest[1]);
            // Calculating results
            voteManagerTest.CalcAndListPercentage(election);

            // Assert
            Assert.Equal(expectedElection,election);
            Assert.Equal(2, candidatesPartiesTest[0].nrVotes);
            Assert.Equal(3, candidatesPartiesTest[1].nrVotes);
            Assert.Equal(40, candidatesPartiesTest[0].perVotes);
            Assert.Equal(60, candidatesPartiesTest[1].perVotes);
        }

    }
}