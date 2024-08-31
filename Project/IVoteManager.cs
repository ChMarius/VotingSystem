namespace VotingSystem
{
    public interface IVoteManager
    {
        public void ListCandidates(Election election);
        public void VoteForCandidate(string votedCandidate, Election election);
        public void CalcAndListPercentage(Election election);
    }
}