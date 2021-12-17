using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_ADVENTURE.Classes
{
    public abstract class Narrator
    {
        ////Not sure if these will come into play, holding them here as a reminder
        //public string CurrentDescription { get; set; }

        //public string CurrentQuestion { get; set; }

        //public List<string> validInputs { get; private set; }



        public abstract Scene GetNextScene();


    }
}
