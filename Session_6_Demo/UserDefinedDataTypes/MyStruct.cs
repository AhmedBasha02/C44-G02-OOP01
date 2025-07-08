

namespace Session_6_Demo.UserDefinedDataTypes
{
    internal struct MyStruct
    {
        // can write 3 access modifiers inside struct :-

        //1] private [this is default if you don't write any access modifier] --> mean allow only inside his scope
        //2] internal
        //3] public

        // can write inside struct 1 of 4 or all 4 :-

        //1] Attributes or Fields --> Member Variables [Must be Private]
        private int x;
        //2] Properties --> divided to 3 category [Automatic prop , full prop , indexer prop]
        public int Id { get; set; }
        //3] Functions or Methods
        internal int sum (int x , int y)
        {
            return x + y;
        }
        //4] Events
    }
}
