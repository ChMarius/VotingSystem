
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

        public static implicit operator string(CandidateParty v)
        {
            throw new NotImplementedException();
        }
    }
}