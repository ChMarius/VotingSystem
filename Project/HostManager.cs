using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace VotingSystem
{
    public class HostManager : IHostManager
    {
        public static Election currentElection;
        public static string hostPassword="marius";        
        public void AssignElectionType(ElectionType electionType)
        {
           while(true)
           {
             switch(electionType)
             {
                // Use a switch statement to choose between election types
                case ElectionType.Presidential:
                  Console.WriteLine("You chose to host a presidential election");
                  currentElection.type=ElectionType.Presidential;
                  break;
                case ElectionType.Parliamentary:
                  Console.WriteLine("You chose to host a parliamentary election");
                  currentElection.type=ElectionType.Parliamentary;
                  break;
                case ElectionType.Local:
                  Console.WriteLine("You chose to host a local election");
                  currentElection.type=ElectionType.Local;
                  break;
               }
               break;
            } 
        } 
        public void RegisterCandidates(List<CandidateParty> listCandidates)
        {
          for(int i=0;i<=listCandidates.Count;++i)
          {
            CandidateParty candidate = currentElection.candidatesParties[i];
            candidate.name = listCandidates[i];
            currentElection.candidatesParties[i] = candidate.name;
          }
        }
        public void RegisterParty(List<CandidateParty> listParties)
        {

        }
    }
}