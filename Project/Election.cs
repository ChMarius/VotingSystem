namespace VotingSystem
{
    public enum ElectionType {Presidential, Parliamentary, Local};
    public struct Election
    {
        // public CandidateBase[] candidates=new CandidateBase[5];
        public int totatVotes;
        public List<Candidate> candidates =  new();
        public ElectionType type;
        public Election(){}
    }
}