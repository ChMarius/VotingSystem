namespace VotingSystem
{
    public interface IHostManager
    {
        public void AssignElectionType(Election election, ElectionType electionType);
        public void RegisterCandidates(Election election, List<CandidateParty> listCandidates);
    }
}