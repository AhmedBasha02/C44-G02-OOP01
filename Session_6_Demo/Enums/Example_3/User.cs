// make this becuase enum Grade and Gender in another folder's not same folder
// so should use namespace of this new folder's inside this folder to access these enum's
using Session_6_Demo.Enums.Example_1;
using Session_6_Demo.Enums.Example_2;

namespace Session_6_Demo.Enums.Example_3
{
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public Grade Grade { get; set; }
        
        // don't need to use namespace for branch because branch and user in same folder
        // mean in same namespace so 2 of them can see each other and access each other 
        public Branch Branch { get; set; }

    }
}
