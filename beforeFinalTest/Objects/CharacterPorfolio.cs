using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION:this is character class
 */

namespace beforeFinalTest.Objects
{
    public class CharacterPorfolio
    {
        //indentity
        public Identity Identity { get; set; }

        //charactieristics
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Endurance { get; set; }
        public string Intellect { get; set; }
        public string Education { get; set; }
        public string SocialStanding { get; set; }

        //Skill list
        List<Skill> Skills;

        CharacterPorfolio()
        {
            this.Skills = new List<Skill>();
            this.Identity = new Identity();

        }

    }
}