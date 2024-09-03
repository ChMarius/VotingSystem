namespace VotingSystem
{
    public interface IHostManager
    {
        public void AssignElectionType(ElectionType electionType, Election election);
        public void RegisterCandidates(List<CandidateParty> listCandidates, Election election);
    }
}