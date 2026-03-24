using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosqlPracticedfgegege
{
public class FakeDB
    {

       public List<User> list;
        public FakeDB()
        {
            list = new List<User>()
            {
            new User()
            {
                Id = 1,
            }
            



        };
        }
    }
}
