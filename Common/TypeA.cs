namespace Common
{
    // convert access modifier for class TypeA from internal to public
    // to access it in another scope in another project in same solution or taked refence from it
    // when convert to public now you can access it in project session_6_Demo in file program.cs

    /*internal*/ public class TypeA
    {
        //Attributes or fields and by default access modifier inside class is private
        //these 3 attributes are accessable inside this scope mean inside this class
        private int x;
        internal int y;
        public int z;

        //making constructor to set value for each attribute
        // can set value for each attribute and access it because they are accessable
        // because they inside the same scope mean inside this class
        public TypeA()
        {
            x = 1;
            y = 2;
            z = 3;
        }
    }
}
