namespace VotingSystem
{
    public interface IHostManager
    {
        public void MakeElection();
        public void RegisterCandidatesParties();
        public void LiveResults();
    }
}