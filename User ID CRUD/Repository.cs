using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosqlPracticedfgegege
{
    public class Repository
    {

        public FakeDB db;

        public Repository() {
            db = new FakeDB();
        }



        public List<User> getAll()
        {
            return db.list;
        }
        public void Add(User user) { 
        
          db.list.Add(user);
        }


        public void Update(int index,User user)
        {
            
            db.list[index] = user;
        }

        public void delete(User user)
        {

            db.list.RemoveAll(users => user.Id  == users.Id);

        }
        






    }
}
