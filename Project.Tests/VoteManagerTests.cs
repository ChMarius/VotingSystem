namespace VotingSystem.Tests
{
    public class VoteManagerTests
    {
        Election currentElectionTest;
        public VoteManagerTests()
        {
            currentElectionTest.candidatesParties = [ 
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
            string choice = "1";
            // Arrange & Act
            voteManagertest.VoteForCandidate(choice, ref currentElectionTest);
            // Assert
            Assert.Equal(4,currentElectionTest.candidatesParties[0].nrVotes);
        }
        [Fact]
        public void CalcAndListPercentage_ReturnCorrectPercentageOfVotes()
        {
            // Arrange
            currentElectionTest.totatVotes = 9;
            // Act
            voteManagertest.CalcAndListPercentage(ref currentElectionTest);
            // Assert
            Assert.Equal(66,(int)currentElectionTest.candidatesParties[1].perVotes);
            Assert.Equal(33,(int)currentElectionTest.candidatesParties[0].perVotes);

        }
    }
}