namespace VotingSystem
{
    public interface IHostManager
    {
        public void AssignElectionType(ElectionType electionType, ref Election election);
        public void RegisterCandidates(List<CandidateParty> listCandidates, ref Election election);
    }
}