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
              while(true){
              Console.Write("> "); string? passWord=Console.ReadLine();
              if(passWord==HostManager.hostPassword)
              {
                Console.Write("Do you want to organise a new election or see the results of the current one?. Type 0 for new election and 1 for the results. \n>");
                string? hostChoice=Console.ReadLine();
                if(hostChoice=="1")
                {
                  Console.WriteLine("So far, these are the results:");
                  //voteManager.CalcAndListPercentage();
                }
                else
                {
                  Election election = new();
                  for(int i=0;i<=4;++i)
                  {
                    Console.WriteLine($"{i+1}.{election.candidates[i].name}");
                  }
                  break;
                }
              }
              else if(passWord=="x") { programActive=false; break; }
              else { Console.WriteLine("Invalid Password. Try Again!"); } 
              }
            }

           else if(personNr=="1")
           {
            // Ability for the user to vote down below needs refactoring
            if(HostManager.elections.Count!=0 && HostManager.elections[0].candidates.Count>=2)
            {
            }
            else {Console.WriteLine("There is no election held.");}
           }
           else if(personNr=="x") { programActive=false; } 
         }
       }
    }
}
