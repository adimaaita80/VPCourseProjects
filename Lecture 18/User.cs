using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_18
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImageLocation { get; set; }

        public string UserInfo()
        {
            return "Name: " + Name + "\n" +
                "Date of Birth: " + DateOfBirth.ToShortDateString() + "\n" +
                "Image Location: " + ImageLocation;
        }
    }
}
