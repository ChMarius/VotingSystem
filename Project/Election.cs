namespace VotingSystem
{
    public enum ElectionType {Presidential, Parliamentary, Local};
    public struct Election
    {
        public int totatVotes;
        public List<CandidateParty> candidatesParties =  new();
        public ElectionType type;
        public Election(){}
    }
}