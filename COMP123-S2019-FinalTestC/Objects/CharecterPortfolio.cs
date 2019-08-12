using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Student Name:
 * Student ID:
 * Description: This the  CharecterPortfolio Class to be used with the charecter
 * 
 */

namespace COMP123_S2019_FinalTestC.Objects
{
    public class CharecterPortfolio
    {
        //identity
        public Identity Identity {get; set;}
        
        
        //charater
        public string Strength { get; set; }
        public string Dexaterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        //skill list
        List<Skill> Skills;
        //constructer
        CharecterPortfolio()
        {
            Skills = new List<Skill>();
            this.Identity = new Identity();
        }
    }
}
