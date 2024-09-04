namespace VotingSystem
{
    public interface IVoteManager
    {
        public void ListCandidates(Election election);
        public void VoteForCandidate(string votedCandidate, ref Election election);
        public void CalcAndListPercentage(ref Election election);
    }
}