namespace Session_6_Demo.Struct
{
    internal struct Point
    {
        #region Atrributes
        public int X;
        public int Y;
        #endregion

        #region Constructors
        // Constructor is Special  Method [Function]
        // 1] Name [Struct , Class]
        // 2] No return type

        //Constructor overloading
        public Point() // --> Parameterless Constructor , [default]
        {
            X = default;
            Y = default;
        }
        public Point(int x, int y) // --> Parameterized Ctor
        {
            this.X = x;
            this.Y = y;
        }
        public Point(int num)
        {
            X=Y= num;
        }
        #endregion
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }
    }
}
