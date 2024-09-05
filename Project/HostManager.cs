namespace VotingSystem
{
    public class HostManager : IHostManager
    {
      public static Election currentElection = new();
      public static string hostPassword="marius";        
      public void AssignElectionType(ElectionType electionType, ref Election election)
      {
          while(true)
          {
            switch(electionType)
            {
              // Use a switch statement to choose between election types
              case ElectionType.Presidential:
                Console.WriteLine("You chose to host a presidential election");
                election.type=ElectionType.Presidential;
                break;
              case ElectionType.Parliamentary:
                Console.WriteLine("You chose to host a parliamentary election");
                election.type=ElectionType.Parliamentary;
                break;
              case ElectionType.Local:
                Console.WriteLine("You chose to host a local election");
                election.type=ElectionType.Local;
                break;
              }
              break;
          } 
      } 
      public void RegisterCandidates(List<CandidateParty> listCandidates, ref Election election)
      {
        for(int i=0;i<listCandidates.Count;++i)
        {
          election.candidatesParties.Add(listCandidates[i]);
        }
      }
    }
}