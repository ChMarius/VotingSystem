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
            voteManagertest.VoteForCandidate(choice, currentElectionTest);
            // Assert
            Assert.Equal(4,currentElectionTest.candidatesParties[0].nrVotes);
        }
        [Fact]
        public void CalcAndListPercentage_ReturnCorrectPercentageOfVotes()
        {
            // Arrange
            HostManager.currentElection.totatVotes = 9;
            // Act
            voteManagertest.CalcAndListPercentage(currentElectionTest);
            // Assert
            Assert.Equal(60,HostManager.currentElection.candidatesParties[1].perVotes);

        }
    }
}