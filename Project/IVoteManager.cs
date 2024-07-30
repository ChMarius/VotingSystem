namespace VotingSystem
{
    public interface IVoteManager
    {
        public void ListCandidates();
        public void VoteForCandidate(CandidateParty votedCandidate);
        public void CalcAndListPercentage();
    }
}