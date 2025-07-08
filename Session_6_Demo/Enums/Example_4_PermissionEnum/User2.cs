using System.Security;

namespace Session_6_Demo.Enums.Example_4_PermissionEnum
{
    internal class User2
    {
        public int Id { get; set; }
        //public string? Name { get; set; }

        //have permission like --> Write read delete execute
        //and makking Array of boolean and if have permission write put true 
        //and if don't have permission read put false and so on

        // if write this only this is not data but this is reference
        // public bool[] Permissions;
        // tb 3ayez a22loh 2bd2a 27gzly 4 2makn fe el heap we el 4 2mkan dol initialized by defualt value
        
        //public bool[] Permissions = new bool[4];

        // using Enum Permissions
        public Permissions Permission { get; set; }
    }
}
