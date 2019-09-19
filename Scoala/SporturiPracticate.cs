using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scoala
{
    public class SporturiPracticate
    {
        public string fotbal;
        public string baschet;
        public string volei;
        public string handbal;

        public void SportPracticat ()
        {
            Console.WriteLine("Care este sportul de echipa practicat/favorit?");
            Console.WriteLine("Optiunile sunt fotbal, baschet, volei sau handbal.");
            string sport = Console.ReadLine();
            sport.ToLower();

            if (sport == fotbal)
            {              
                Console.WriteLine($"Sportul practicat de tine este fotbal");               
            }
            else if (sport == baschet)
            {
                Console.WriteLine($"Sportul practicat de tine este baschet"); 
                
            }
            else if (sport == volei)
            {
                Console.WriteLine($"Sportul practicat de tine este volei");                 
            }
            else if (sport == handbal)
            {
                Console.WriteLine($"Sportul practicat de tine este handbal");                 
            }
            else
            {
                Console.WriteLine($"Nu s-a inregistrat nici un sport");                
            }
            Console.ReadKey();
            
        }                        
    }
}
