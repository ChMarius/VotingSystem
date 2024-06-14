namespace VotingSystem
{
    public interface IVoteManager
    {
        public void ListCandidates();
        public void VoteForCandidate(Election election, CandidateParty votedCandidate);
        public void CalcAndListPercentage(Election election);
    }
}