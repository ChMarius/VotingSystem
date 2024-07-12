using System.Security.Cryptography.X509Certificates;

namespace VotingSystem
{
    public class HostManager : IHostManager
    {
        public static Election currentElection;
        public static string hostPassword="marius";        
        public void AssignElectionType(ElectionType electionType)
        {
           Console.Write("Choose a type of election you want to organise: 1 for Presidential, 2 for Parliamentary or 3 for Local\n> ");
           #pragma warning disable CS8602 // Dereference of a possibly null reference.
           while(true)
           {
             string? choice=Console.ReadLine();
             switch(choice)
             {
                 // Use a switch statement to choose between election types
                 case "1":
                   Console.WriteLine("You chose to host a presidential election");
                   currentElection.type=ElectionType.Presidential;
                   break;
                 case "2":
                   Console.WriteLine("You chose to host a parliamentary election");
                   currentElection.type=ElectionType.Parliamentary;
                   break;
                 case "3":
                   Console.WriteLine("You chose to host a local election");
                   currentElection.type=ElectionType.Local;
                   break;
                 default:
                   Console.Write("Invalid Input. Type 1 for Presidential, 2 for Parliamentary or 3 for Local\n");
                   continue;
               }
               break;
            } 
        } 
        public void RegisterCandidates(List<CandidateParty> listCandidates)
        {
          Console.WriteLine("Register the candidates");
          int i=0;
          while(true)
          {
            Console.Write("Type the name of the candidate and press enter to register the next candidate. Type exit to end the registration\n> ");
            string? choice=Console.ReadLine();
            if(choice=="exit") { break; }
            string[] name=choice.Split(' ');
            if(name.Length!=2 && name.Length!=3) { Console.WriteLine("Not valid name"); }
            else {
              // elections[0].candidates[i].name=name[0]+' '+name[1];
            }
            i++;
          }
        }
        public void RegisterParty(List<CandidateParty> listParties)
        {

        }
    }
}