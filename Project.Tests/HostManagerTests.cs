namespace VotingSystem.Tests
{
    public class HostManagerTests
    {
        private Election predictedElectionCandidateTest;
        private Election predictedElectionPartyTest;
        private Election electionTest;
        public HostManagerTests()
        {
            predictedElectionCandidateTest = new()
            {
                candidatesParties =
                [
                    new CandidateParty
                    {
                        name = "Mikkel Yappelson"
                    },
                    new CandidateParty
                    {
                        name = "Arnold Green"
                    },
                ]
            };
            predictedElectionPartyTest = new()
            {
                candidatesParties =
                [
                    new CandidateParty
                    {
                        name = "SDP"
                    },
                    new CandidateParty
                    {
                        name = "UFWP"
                    }
                ]
            };
        }
        readonly HostManager hostManagerTest = new();
        [Fact]
        public void AssignElectionType_CorrectElectionTypePresidential()
        {
            // Arrange
            ElectionType typeTest = ElectionType.Presidential;
            // Act
            hostManagerTest.AssignElectionType(typeTest, ref predictedElectionCandidateTest);
            // Assert
            Assert.Equal(ElectionType.Presidential,predictedElectionCandidateTest.type);
        }
        [Fact]
        public void RegisterCandidate_CorrectCandidateRegistration()
        {
            // Arrange
            electionTest = new();
            List<CandidateParty> listCandidatesTest = [
                new CandidateParty
                {
                    name = "Mikkel Yappelson"
                },
                new CandidateParty
                {
                    name = "Arnold Green"
                },
            ];
            // Act
            hostManagerTest.RegisterCandidates(listCandidatesTest, ref electionTest);
            // Assert
            Assert.Equal(predictedElectionCandidateTest.candidatesParties, electionTest.candidatesParties);
        }
        [Fact]
        public void RegisterParty_CorrectPartyRegistration()
        {
            // Arrange
            electionTest = new();
            List<CandidateParty> listPartiesTest = [
                new CandidateParty
                {
                    name = "SDP"
                },
                new CandidateParty
                {
                    name = "UFWP"
                },
            ];
            // Act
            hostManagerTest.RegisterCandidates(listPartiesTest, ref electionTest);
            // Assert
            Assert.Equal(predictedElectionPartyTest.candidatesParties, electionTest.candidatesParties);
        }
    }
}