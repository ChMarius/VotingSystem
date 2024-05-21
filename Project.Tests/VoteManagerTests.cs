namespace VotingSystem.Tests
{
    public class VoteManagerTests
    {
        private Election electionTest;
            [Fact]
        public void VoteForCandidate_NrVotesGetsIncrementedAfterVoting()
        {
            // Arrange
            electionTest = new();
            electionTest.candidates = [ 
            new Candidate
            {
                name = "Ryan Gasoline",
                nrVotes = 3,
                perVotes = 0,
            },
            new Candidate
            {
                name = "Adolf Stalin",
                nrVotes = 6,
                perVotes = 0,
            },
            ];
            VoteManager voteManagertest = new();
            // Act
            voteManagertest.VoteForCandidate(electionTest, electionTest.candidates[0]);
            // Assert
            Assert.Equal(4,electionTest.candidates[0].nrVotes);
        }
    }
}