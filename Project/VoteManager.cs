namespace VotingSystem
{
    public class VoteManager : IVoteManager
    {
      public void ListCandidates(Election election)
      {
        Console.WriteLine($"Here are the candidates for the {election.type} election\n");
        for(int i=0;i<election.candidatesParties.Count;++i)
        {
          Console.WriteLine($"{i+1}. {election.candidatesParties[i].name}");
        }
      }

      public void VoteForCandidate(string candidateNr, ref Election election)
      {
        while(true)
        {
          if (int.TryParse(candidateNr, out int i) && i>=1 && i<=election.candidatesParties.Count)
          {
            var party = election.candidatesParties[i-1];
            party.nrVotes++;
            election.totatVotes++;
            election.candidatesParties[i-1] = party;
            break;
          }
          else
          {
            Console.WriteLine("Error occured! Try Again!");
          }
        }
      }

      public void CalcAndListPercentage(ref Election election)
      {
        for(int i=0;i<election.candidatesParties.Count;++i)
        {
          var candidate =  election.candidatesParties[i];
          candidate.perVotes = (election.candidatesParties[i].nrVotes*100)/election.totatVotes;
          election.candidatesParties[i] = candidate;
          Console.WriteLine($"{i+1}.{election.candidatesParties[i].name} - {election.candidatesParties[i].perVotes} %");
        }
      }
    }
}