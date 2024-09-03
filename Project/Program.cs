namespace VotingSystem
{
    class Program
    {       
       public static void Main()
       {
         VoteManager voteManager=new();
         HostManager hostManager=new();
         bool programActive=true;
         Console.WriteLine("Welcome to the National Voting System Management!");
          while(programActive==true)
          {
            Console.Write("Type whether you enter as a host or as a participant. 0 as a host or 1 as a participant. If you want to exit type 'x' \n> ");
            # pragma warning disable 
            string? personNr=Console.ReadLine().ToLower();
            # pragma warning restore
            if(personNr=="0")
            {
              Console.WriteLine("Password required to enter as a host");
              while(true)
              {
                Console.Write("> ");
                string? passWord=Console.ReadLine();
                if(passWord==HostManager.hostPassword)
                {
                  Console.Write("Here are the action you can do.\n 1.Calculate the results of the current election \n 2. Organise an election \n Type x in order to exit the program\n >");
                  string? hostChoice=Console.ReadLine();
                  if(hostChoice=="1")
                  {
                    Console.WriteLine("So far, these are the results:");
                    voteManager.CalcAndListPercentage(HostManager.currentElection);
                  }
                  else
                  {
                    Console.WriteLine("Choose an election type.\n1.Presidential\n2.Parliamentary\n3.Local\n> ");
                    while(true)
                    {
                      ElectionType electionType;
                      string? choice = Console.ReadLine();
                      switch(choice)
                      {
                        // Use a switch statement to choose between election types
                        case "1":
                          Console.WriteLine("You chose to host a presidential election");
                          electionType=ElectionType.Presidential;
                          break;
                        case "2":
                          Console.WriteLine("You chose to host a parliamentary election");
                          electionType=ElectionType.Parliamentary;
                          break;
                        case "3":
                          Console.WriteLine("You chose to host a local election");
                          electionType=ElectionType.Local;
                          break;
                        default:
                          Console.Write("Invalid Input. Type 1 for Presidential, 2 for Parliamentary or 3 for Local\n");
                          continue;
                      }
                      hostManager.AssignElectionType(electionType);
                      Console.WriteLine("Input the name of the candidates in order to register them in the election or type x to end the candidate registration.");
                      int i = 0;
                      while(true)
                      {
                        string? nameCandidate = Console.ReadLine();
                        HostManager.currentElection.candidatesParties[i] = (CandidateParty)nameCandidate;
                        ++i;
                        break;
                      }
                      break;
                    }
                  }
                }
                else if(passWord=="x") 
                { 
                  programActive = false; 
                  break; 
                }
                else 
                { 
                  Console.WriteLine("Invalid Password. Try Again!"); 
                } 
              }
            }

           else if(personNr=="1")
           {
            if(HostManager.currentElection.candidatesParties.Count==0)
            {
              Console.WriteLine("There is no election held at the moment!");
            }
            else
            {
            // Ability for the user to vote down below needs refactoring
             Console.WriteLine("Type the number next to the candidate you wish to vote for this election\n >");
             string? candidateNr = Console.ReadLine();
             voteManager.VoteForCandidate(candidateNr, HostManager.currentElection);
            }
           }
           else if(personNr=="x") { programActive=false; } 
         }
       }
    }
}
