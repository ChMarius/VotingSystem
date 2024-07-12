
namespace VotingSystem
{
    public struct CandidateParty
    {
        public string name;
        public int nrVotes;
        public double perVotes;

        public static implicit operator CandidateParty(string? v)
        {
            throw new NotImplementedException();
        }
    }
}