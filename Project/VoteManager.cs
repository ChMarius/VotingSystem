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
      public void VoteForCandidate(string candidateNr, Election election)
      {
        int i;
        while(true)
        {
          if (int.TryParse(candidateNr, out i) && i>=1 && i<=election.candidatesParties.Count)
          {
            var party = election.candidatesParties[i-1];
            party.nrVotes++;
            election.candidatesParties[i-1] = party;
            break;
          }
          else
          {
            Console.WriteLine("Error occured! Try Again!");
          }
        }
      }
      public void CalcAndListPercentage(Election election)
      {
        for(int i=0;i<election.candidatesParties.Count;++i)
        {
          var percentage =  election.candidatesParties[i];
          percentage.perVotes = (election.candidatesParties[i].nrVotes/election.totatVotes)*100;
          election.candidatesParties[i] = percentage;
          Console.WriteLine($"{i+1}.{election.candidatesParties[i].name} - {election.candidatesParties[i].perVotes} %");
        }
      }
    }
}