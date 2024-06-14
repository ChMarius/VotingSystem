namespace VotingSystem.Tests
{
    public class VoteManagerTests
    {
        private Election electionTest;
        public VoteManagerTests()
        {
            electionTest.candidatesParties = [ 
            new CandidateParty
            {
                name = "Ryan Gasoline",
                nrVotes = 3,
                perVotes = 0,
            },
            new CandidateParty
            {
                name = "Jack Black",
                nrVotes = 6,
                perVotes = 0,
            },
            ];
        }
        readonly VoteManager voteManagertest = new();
        [Fact]
        public void VoteForCandidate_NrVotesGetsIncrementedAfterVoting()
        {
            // Arrange
            electionTest = new();
            // Act
            voteManagertest.VoteForCandidate(electionTest, electionTest.candidatesParties[0]);
            // Assert
            Assert.Equal(4,electionTest.candidatesParties[0].nrVotes);
        }
        [Fact]
        public void CalcAndListPercentage_ReturnCorrectPercentageOfVotes()
        {
            // Arrange
            electionTest = new()
            {
                totatVotes = 9
            };
            // Act
            voteManagertest.CalcAndListPercentage(electionTest);
            // Assert
            Assert.Equal(60,electionTest.candidatesParties[1].perVotes);

        }
    }
}