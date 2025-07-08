// make this becuase enum grade in another folder not same folder
// so should use namespace of this new folder inside this folder to access enum
using Session_6_Demo.Enums.Example_2;

namespace Session_6_Demo.Enums.Example_1
{
    internal class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public Grade Grade { get; set; }
    }
}
