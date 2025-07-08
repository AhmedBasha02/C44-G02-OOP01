namespace Session_6_Demo.UserDefinedDataTypes
{
    //if have namespace can write inside it 1 of 4 or all 4 :-

    //1]enum      --> Value Type
    //2]struct    --> Value Type
    //3]class     --> Reference Type
    //4]interface --> Reference Type

    //inside namespace can only write [2 access modifier]
    //1]internal --> [this is default]
    //2]public
    // if don't write access modifier then it will be by default that is [internal]
    internal class MyClass
    {
        // can write 6 access modifiers inside class :-

        //1] private [this is default if you don't write any access modifier] --> mean allow only inside his scope
        //2] private protected
        //3] protected
        //4] internal
        //5] internal protected
        //6] public

        // can write inside class 1 of 4 or all 4 :-

        //1] Attributes or Fields --> Member Variables [Must be Private]
        private int x;
        //2] Properties --> divided to 3 category [Automatic prop , full prop , indexer prop]
        public int Id { get; set; }
        //3] Functions or Methods
        internal void MyFun()
        {
            Console.WriteLine("Hello Basha");
        }
        //4] Events
    }
}
