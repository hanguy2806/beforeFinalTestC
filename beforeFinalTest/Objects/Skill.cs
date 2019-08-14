using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * STUDENT NAME: Thi Thu Ha Nguyen
 * STUDENT ID:301017727
 * DESCRIPTION: this is skill class
 */

namespace beforeFinalTest.Objects
{
    public class Skill
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public Skill(string name)
        {
            this.Name = name;
        }
    }
}
