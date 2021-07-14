using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.PrincipioDeSegregacionDeInterfaz
{
    public class UserRepository : IReadable, IWriteable, IRemovable
    {
        public void Create() { }
        public void Update() { }
        public void Remove(int id) { }
        public void Get(int id) { }
        public void GetAll() { }
    }
}
