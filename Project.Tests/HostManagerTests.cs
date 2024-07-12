namespace VotingSystem.Tests
{
    public class HostManagerTests
    {
        private Election predictedElectionCandidateTest;
        private Election predictedElectionPartyTest;
        private Election electionTest;
        private HostManagerTests()
        {
            predictedElectionCandidateTest.type = ElectionType.Presidential;
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
                        name = "Zeus Christ"
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
        private void AssignElectionType_CorrectElectionTypePresidential()
        {
            // Arrange
            ElectionType typeTest = ElectionType.Presidential;
            // Act
            hostManagerTest.AssignElectionType(typeTest);
            // Assert
            Assert.Equal(ElectionType.Presidential,predictedElectionCandidateTest.type);
        }
        [Fact]
        private void RegisterCandidate_CorrectCandidateRegistration()
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
            hostManagerTest.RegisterCandidates(listCandidatesTest);
            // Assert
            Assert.Equal(predictedElectionCandidateTest.candidatesParties, electionTest.candidatesParties);
        }
        [Fact]
        private void RegisterParty_CorrectPartyRegistration()
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
            hostManagerTest.RegisterCandidates(listPartiesTest);
            // Assert
            Assert.Equal(predictedElectionPartyTest.candidatesParties, electionTest.candidatesParties);
        }
    }
}