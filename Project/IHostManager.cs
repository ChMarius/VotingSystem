namespace VotingSystem
{
    public interface IHostManager
    {
        public void AssignElectionType(ElectionType electionType);
        public void RegisterCandidates(List<CandidateParty> listCandidates);
    }
}