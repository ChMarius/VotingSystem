namespace VotingSystem
{
    public interface IVoteManager
    {
        public void ListCandidates();
        public void VoteForCandidate(Election election, Candidate votedCandidate);
        public void CalcAndListPercentage();
    }
}