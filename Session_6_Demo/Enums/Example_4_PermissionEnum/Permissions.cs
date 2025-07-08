namespace Session_6_Demo.Enums.Example_4_PermissionEnum
{
    // Normal Enum
    //internal enum Permissions
    //{
    //    Write = 1,
    //    Read ,
    //    Delete , 
    //    Execute
    //}

    // Permission Enum

    //// Permission enum can access for you to reserve more than 1 value 
    //// Permission enum will reduce size that you reserve for data 
    //// defualt type for enum is int but we will convert it to be byte 
    //// mean all enum will reserve in 1 byte 
    //// and make attribute called [Flags] and Flags is Class
    //// we will joke [ned7k 3aleh] on it , treat with label inside enum as number of bits 
    //// each label will treat with it as 8 bits becuase datatype converted to byte
    //// now if you need permission for write and read 
    //// then make opertion on bits that realted to write and read and will get 2 permissions
    //// if you need permission for write and read and delete
    //// then make opertion on bits that realted to write and read and delete and will get 3 permissions
    //// and so on
    //// and if you need to remove permission we will make operation to remove it and so on
    [Flags]
    internal enum Permissions : byte
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
