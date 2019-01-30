using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730263_ConsoleApp1
{
    class Program
    {
     
        class Village
        {
            //Node is an ADT
            //What KIND of DATA do we need in a NODE? 
            public Village nextVillage;
            public Village previousVillage;
            public String VillageName;
            public bool isAstrildeHere = false; 

            
        }
        class Countryside
        {
            Village Maple = new Village();
            Village Toronto = new Village();
            Village Ajax = new Village();
            Village First;
            Village last;
            Village Temp;
            public void Launch()
            {
                Maple.VillageName = "Maple";
                Maple.nextVillage = Toronto;
                Maple.previousVillage = null;
                Toronto.VillageName = "Toronto" ;
                Toronto.previousVillage = Maple;
                Toronto.nextVillage = Ajax;
                Ajax.VillageName = "Ajax";
                Ajax.nextVillage = null;
                Ajax.nextVillage = Toronto;
                

            }
            public string displayMap()
            {
                String listofCities = "";
                //We need to print all the cities in our area
                while(true)
                {
                    listofCities = listofCities + First.VillageName;
                    Temp = First.nextVillage;
                    listofCities = listofCities + Temp.VillageName;

                    return listofCities;
                    
                }
            }
        }
    }
}
