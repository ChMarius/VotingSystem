

namespace VotingSystem
{
    public struct CandidateParty
    {
        public string name;
        public int nrVotes;
        public double perVotes;

        public static implicit operator int(CandidateParty v)
        {
            throw new NotImplementedException();
        }

        public static explicit operator CandidateParty(string? v)
        {
            throw new NotImplementedException();
        }
    }
}