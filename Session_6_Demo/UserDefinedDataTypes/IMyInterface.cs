namespace Session_6_Demo.UserDefinedDataTypes
{
    internal interface IMyInterface
    {
        // can write 6 access modifiers inside interface :-

        //1] public [this is default if you don't write any access modifier] --> mean any project can access it 
        //2] private protected
        //3] protected
        //4] internal
        //5] internal protected
        //6] private [only used with Default implemented Method]

        // can write inside interface 1 of 3 or all 3 :-

        //1] Signature for Method
        void MyFun (int x , int y);
        //2] Signature for Property
        public int Id { get; set; }

        //3] Default implemented Method
        private void HelperPrint()
        {
            Console.WriteLine("Hello from Default implemented Method");
        }
        void Print()
        {
            HelperPrint();
            Console.WriteLine("Hello Ahmed");
        }
    }
}
