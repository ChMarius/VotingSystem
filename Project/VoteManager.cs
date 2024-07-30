namespace VotingSystem
{
    // IDEA : Pass the the HostManager.currentElection number as a parameter into methods
    public class VoteManager : IVoteManager
    {
        public void ListCandidates()
        {
            Console.WriteLine($"Here are the candidates for the {HostManager.currentElection.type} HostManager.currentElection\n");
            for(int i=0;i<HostManager.currentElection.candidatesParties.Count;++i)
            {
              Console.WriteLine($"{i+1}. {HostManager.currentElection.candidatesParties[i].name}");
            }
        }
        public void VoteForCandidate(CandidateParty candidateNr)
        {
           Console.WriteLine("You can vote only for one candidate. Type the number next to the candidate you want to vote for."); 
           for(int i=0;i<HostManager.currentElection.candidatesParties.Count;++i)
           {
              Console.WriteLine($"{i+1}. {HostManager.currentElection.candidatesParties[i].name}");
           }
           Console.Write("> "); string? choice=Console.ReadLine();
           switch(choice)
           {
             // This code needs refactoring, can't change the value of an element in a list
             /*
              case "1":
                HostManager.elections[0].candidates[0].nrVotes++;
                break;
              case "2":
                HostManager.elections[0].candidates[1].nrVotes++;
                break;
              case "3":
                HostManager.elections[0].candidates[2].nrVotes++;
                break;
              case "4":
                HostManager.elections[0].candidates[3].nrVotes++;
                break;
              case "5":
                HostManager.elections[0].candidates[0].nrVotes++;
                break;
             */
           }
        }
        public void CalcAndListPercentage()
        {
            for(int i=0;i<HostManager.currentElection.candidatesParties.Count;++i){
                //HostManager.elections[0].candidates[i].perVotes=HostManager.elections[0].candidates[i].nrVotes/HostManager.elections[0].totatVotes*100;
                Console.WriteLine($"{i+1}.{HostManager.currentElection.candidatesParties[i].name} - {HostManager.currentElection.candidatesParties[i].perVotes} %");
            }
        }
    }
}