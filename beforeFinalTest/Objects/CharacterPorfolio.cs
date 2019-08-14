using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * STUDENT NAME:Thi Thu Ha Nguyen
 * STUDENT ID:301017727
 * DESCRIPTION:this is character porfolio class which contains in4 of character.
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
        public List<Skill> SkillsList;

        public CharacterPorfolio()
        {
            this.SkillsList = new List<Skill>();
            this.Identity = new Identity();

        }

    }       
}
