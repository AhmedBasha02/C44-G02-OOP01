namespace Session_6_Assignment.Enums.Q4_PermissionEnum
{
    [Flags]
    internal enum Permission : byte
    {
        //write in decimal
        Write = 1,
        Read = 2,
        Delete = 4,
        Execute = 8
        //or write in binary
        //Write = 0b_0000_0001,
        //Read = 0b_0000_0010,
        //Delete = 0b_0000_0100,
        //Execute = 0b_0000_1000

    }
}
