using System;
using System.Collections.Generic;

namespace Zoo
{
    
    public class Predator
    {
              
        public Predator()
        {

        }

        public static int builtCage()
        {
            Console.WriteLine("There isn't enough space. We have to built new cages.");
            Console.WriteLine("How many cages do we need to built?");
            int numCages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Building...");
            return numCages;
        }

    }


    public class Outdoor 
    {
        public string name;
        public  Outdoor()
        {
            

        }
    
}
  public  class Lion : Predator
    {
     
       
        private string name;
        public Lion(string name)
        {
            this.name = name;
            
        }
        public string getName { get { return name; } }
      

    }
    public class Antelopes : Outdoor
    {


        private string name;
        public Antelopes(string name)
        {
            this.name = name;

        }
        public string getName { get { return name; } }
    }
        public class Gazelles : Outdoor
        {

            private string name;
            public Gazelles(string name)
            {
                this.name = name;

            }
            public string getName { get { return name; } }

        }

   
  
        class Program
        {
        
            static void Main(string[] args)
            {
                List<Lion> lions = new List<Lion>();
                List<Antelopes> antelopes = new List<Antelopes>();
                List<Gazelles> gazelles = new List<Gazelles>();

                lions.Add(new Lion("Lion1"));
                lions.Add(new Lion("Lion2"));

                antelopes.Add(new Antelopes("Antelope1"));
                antelopes.Add(new Antelopes("Anteloppe2"));
                antelopes.Add(new Antelopes("Anteloppe3"));

                gazelles.Add(new Gazelles("Gazelle1"));
                gazelles.Add(new Gazelles("Gazelle2"));

           
            Console.WriteLine("What would you like to do?\n" +
                "1: Add new Animal\n" +
                "2: Inventory\n" +
                "3: End\n\n");
                int num1 = Convert.ToInt32(Console.ReadLine());
             //num1 is first choice - what do we want to do
                if (num1 == 1)
                {
                    Console.WriteLine("Please choose an animal:\n" +
                        "1: Lions\n" +
                        "2: Antelopes\n" +
                        "3: Gazelles\n" +
                        "0: End\n\n");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                //num2 is second choice - select an animal to add
                    if (num2 == 1)
                    {
                    int maxLionsInCage = lions.Count;
                    if (lions.Count >= maxLionsInCage)
                    {
                        //build Cage
                        int numberOfCages = Lion.builtCage();
                        Console.WriteLine("Building {0} cages.", numberOfCages);
                        for(int i=0; i<numberOfCages; i++)
                        {
                            Console.WriteLine("Name of the animal:");
                            string str1 = Console.ReadLine();
                            lions.Add(new Lion(str1));
                        }
                        
                        //print all lions
                        foreach (var item in lions)
                            Console.WriteLine("Name of the animal:  {0}", item.getName);
                    }
                    }
                    else if (num2 == 2)
                    {
                        Console.WriteLine("Name of the animal: ");
                        string str1 = Console.ReadLine();
                        antelopes.Add(new Antelopes(str1));
                    //print all antelopes
                    foreach (var item in antelopes)
                        Console.WriteLine("Name of the animal:  {0}", item.getName);
                }
                    else if (num2 == 3)
                    {
                        Console.WriteLine("Name of the animal: ");
                        string str2 = Console.ReadLine();
                        gazelles.Add(new Gazelles(str2));
                    //print all gazelles
                    foreach (var item in gazelles)
                        Console.WriteLine("Name of the animal:  {0}", item.getName);

                }
                    else
                    {
                    Environment.Exit(0);
                    }

                }
                else if (num1 == 2) 
                //print inventory
                {
                    foreach(var item in lions)
                        Console.WriteLine("Name:  {0}" ,item.getName );
                Console.WriteLine("Total number of lions: {0}", lions.Count);
                    foreach (var item in antelopes)
                        Console.WriteLine("Name:  {0}", item.getName);
                Console.WriteLine("Total number of antellopes: {0}", antelopes.Count);
                    foreach (var item in gazelles)
                        Console.WriteLine("Name:  {0}", item.getName);
                Console.WriteLine("Total number of gazelles: {0}", gazelles.Count);
                }
                else if (num1 == 3)
                {
                Environment.Exit(0);
                }

                else { Environment.Exit(0);  };
            }

        }
    }
    
    

