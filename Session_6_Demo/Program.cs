using Common;
// make this becuase enum Grade and Gender and class Person in another folder's not same folder
// so should use namespace of this new folder's inside this folder to access these enum's and class
using Session_6_Demo.Enums.Example_1;
using Session_6_Demo.Enums.Example_2;
// make this becuase enum Branch and class User in another folder's not same folder
// so should use namespace of this new folder's inside this folder to access this enum Branch and class User
using Session_6_Demo.Enums.Example_3;
// make this becuase class User2 in another folder not same folder
// so should use namespace of this new folder inside this folder to access this class User2
using Session_6_Demo.Enums.Example_4_PermissionEnum;
// make this becuase struct Pont in another folder not same folder
// so should use namespace of this new folder inside this folder to access this Struct Point
using Session_6_Demo.Struct;

namespace Session_6_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Libraries
            Product product = new Product(); // samll word product --> this is reference in heap 
                                             //// or
                                             //Product product1 = new ();
                                             //// or
                                             //Product product2;
                                             //product2 = new ();
                                             //// or
                                             //Product product3;
                                             //product3 = new Product();
                                             //// to initialize can make that 
                                             ////1.
                                             //Product product4 = new () 
                                             //{
                                             //    Id = 1,
                                             //    Name = "Test",
                                             //    Price = 100,
                                             //    Quantity = 1,
                                             //};
                                             ////2.
                                             //Product product5 = new Product() 
                                             //{
                                             //    Id = 2,
                                             //    Name = "Test",
                                             //    Price = 1000,
                                             //    Quantity = 2,
                                             //};
                                             ////3.
                                             //Product product6 = new Product();
                                             //product6.Id = 3;
                                             //product6.Name = "Test";
                                             //product6.Price = 10000;
                                             //product6.Quantity = 3;
                                             //Console.WriteLine(product6.Id);
                                             //Console.WriteLine(product6.Name);
                                             //Console.WriteLine(product6.Price);
                                             //Console.WriteLine(product6.Quantity);

            #endregion

            #region User defined data types
            #endregion

            #region Access Modifiers
            //TypeA typeA = new TypeA();
            //typeA.x = 15; // invalid becuase access modifier is [private] so you can not access x
            // private mean can't access it outside his scope
            // mean can't access it outside class TypeA
            // mean accessable only inside it's scope inside class TypeA only

            //typeA.y = 25; // invalid becuase access modifier is [internal] so you can not access y
            // internal mean you can access it inside it's scope inside class TypeA 
            // and mean you access it outside it's scope in any another scope
            // but have 1 condition which should any another scope should be inside
            // in same project
            // mean in same this project [Common] 
            // if any another scope outside this project [common]
            // then we can not access [y] 
            // and now we inside another project that called session_6_demo
            // then we can't access it 

            //typeA.z = 35; // valid to access [z] becuase modifier in class TypeA is [public]
            // mean you can access it inside it's scope inside class TypeA 
            // and mean you access it outside it's scope in any another scope
            // and if any another scope outside project [common] not inside same project
            // you can access it also becuase this access modifier [public] 
            // mean you can access [z] in any another scope inside same solution
            // in any project inside same solution
            // and if you make reference project inside another project ,
            // you can also access [z]
            #endregion

            #region Enum Ex 1 [Male - Female]
            // Make Reference that exist in [Stack] and save size 4 bytes for int
            // and string is reference type will save size when access it and insert data inside it
            // why make reference because Person is class and class is reference type so this is reference in stack 

            //Person p1; 

            //p1 = new Person();
            //or
            //p1 = new ();

            // new make 4 things :-
            //1] allocate num of bytes in heap
            //2] initialize with the default values
            //3] call user defines constructor [Ctor] [if exist]
            //4] assign reference to the instance in heap 

            //lets insert data 
            // i insert these data byself if any one insert it or take data from user
            // can enter wrong value in name or gender
            // so we will make do while loop it will be inside loop even write correct data 
            // and make geneder make it enum have 4 values only y female y male y f y m 
            //p1.Id = 1;
            //p1.Name = "Ahmed";
            //p1.Gender = "Males";

            // object initializer
            //Person person = new Person() 
            //{
            //    Id = 1,
            //    Name = "Mariam",
            //    Gender = Gender.F //or Gender.Female  /*or (Gender)1 */ 
            //};
            //Console.WriteLine(person.Gender);
            #endregion

            #region Enum Ex 2 [Grades]
            // this is not reference becuase Grade is enum and enum is value type not reference type
            // so this is variable or object like that when say int x ; === Grade g1 ;
            // and this value type have only 1 place in stack

            //Grade g1;
            //g1 = Grade.A /*or (Grade)0*/;
            //Console.WriteLine(g1);

            //Person person = new Person();

            // i am not give initialize value for name , Gender and Grade
            // so complier will give them default valuse 


            //Console.WriteLine(person.Name);  // for name this datatype is string
            // so string will be default value is empty string
            //o/p will be default value for string that is --> empty string


            //Console.WriteLine(person.Gender); // for Gender this is enum and enum default datatype is int
            // this mean default value for int is 0 
            // and 0 in enum gender have value male 
            // then o/p will be --> Male
            // but when update enum to start from 1 not 0 then 
            // o/p will be default value that is --> 0 not Male

            //Console.WriteLine(person.Grade); // for Grade this is enum and enum default datatype is int
            // this mean default value for int is 0 
            // and 0 in enum grade have value A 
            // then o/p will be --> A
            // but when update enum to start from 1 not 0 then 
            // o/p will be default value that is --> 0 not A

            //int num = Grade.C;  // invalid becuase grade is enum and have constant labels
            // to make num can show it or show data or assign data should make casting
            // make casting to int to be valid

            //int num1 = (int)Grade.D; // this valid becuase make casting to can see Grade.D as int
            //Console.WriteLine(num1);

            //Person person2 = new Person()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Gender = Gender.Male,
            //    Grade = Grade.A
            //};

            //if (person2.Grade == Grade.A /*or (Grade)1*/)
            //{
            //    Console.WriteLine("Bravooooo");
            //}
            //else
            //{
            //    Console.WriteLine("so bad :(");
            //}
            #endregion

            #region Enum Ex 3 [Grade , Gender , Branch]

            // if enter data byself

            // this is reference becuase we deal with class user that is reference type
            // but reserve only in stack not yet in heap 
            //User user;
            // to reseve in heap use new and initialize data
            //user = new User()
            //this initialize called object initializer
            //{
            //    Id = 1,
            //    Name = "Mona",
            //    Gender = Gender.Female,
            //    Grade = Grade.A,
            //    Branch = Branch.Dokki
            //};
            //Console.WriteLine(user.Id);
            //Console.WriteLine(user.Name);
            //Console.WriteLine(user.Gender);
            //Console.WriteLine(user.Grade);
            //Console.WriteLine(user.Branch);

            // if take data from user

            //User user = new User();

            //Console.WriteLine("Please Enter The Student Info : \n");

            //// make variable to recieve entered data from user when enter in id
            //int StdId;
            //bool IsParsed;
            //do
            //{
            //    Console.WriteLine("Please Enter The Valid Student Id : \n");
            //    // this is not valid to use property to recieve entered data from user this synatx is wrong and not valid 
            //    // should make variable and then receive entered data from user in this variable
            //    // then save variable in property user.Id

            //    //IsParsed = int.TryParse(Console.ReadLine(), out user.Id);

            //    // this is valid becuase use varibale StdId and then receive entered data from user
            //    // in this variable then save variable in property make this in the end user.Id = StdId

            //    IsParsed = int.TryParse(Console.ReadLine(), out StdId);
            //}
            //while (!IsParsed);

            //do
            //{
            //    Console.WriteLine("Please Enter The Valid Name : \n");
            //    user.Name = Console.ReadLine();

            //}
            //while (user.Name == ""); // make this condition to prevent enter empty string like press enter

            //// nullable object to recieve entered data from user when enter in enum Gender
            //object? gender;

            //do
            //{
            //    Console.WriteLine("Please Enter a Valid Gender [Male or M / Female or F] : \n");
            //    // we can't use int.tryparse with enum so C# make Tryparse inside object Enum to use it
            //    // Enum have 2 types of TryParse 
            //    //1] Non Generic for objects before Generic coming
            //    //and this not bext becuase make boxing and unboxing
            //    //2] Generic for Generics after coming and this is the best 

            //    //1] TryParse for NonGeneric take 4 parameters :-
            //    //1-1]type of enum type like Gender type of enum is Gender
            //    //1-2]take value from user by useing Console.ReadLine()
            //    //cast from string to enum Gender becuase Console.Readline return string then need to cast to enum
            //    //1-3]ignorecase by default is false to make case sensitive [Optional] if enter
            //    //like that femla and it is wrote in enum Female and have case sesitive mean both different
            //    //not same then it will be wrong
            //    //but if make ignorecase be true this mean tell ignore case sensitive mena
            //    //if enter female or Female both are true and same
            //    //1-4]output that recieve enter data on it must be object
            //    //becuase use TryParse for nonGeneric mean object
            //    //So make above do while --> nullable object to recieve data on it 
            //    IsParsed = Enum.TryParse(typeof(Gender) , Console.ReadLine() , true , out gender);
            //}
            //while (!IsParsed);

            //// make variable to recieve entered data from user when enter in enum grade
            //Grade grade;
            //do
            //{
            //    Console.WriteLine("Please Enter a Valid Grade [A , B , C , D , F] : \n");
            //    // this is not valid to use property to recieve entered data from user this synatx is wrong and not valid 
            //    // should make variable and then receive entered data from user in this variable
            //    // then save variable in property user.Grade

            //    //IsParsed = Enum.TryParse<Grade>(Console.ReadLine(), true, out user.Grade);

            //    // this is valid becuase use varibale grade and then receive entered data from user
            //    // in this variable then save variable in property make this in the end user.Grade = grade

            //    IsParsed = Enum.TryParse<Grade>(Console.ReadLine(), true, out grade);

            //    //2] TryParse for Generic take 4 parameters :-
            //    //2-1]between < > put type of enum like Grade
            //    //2-2]take value from user by useing Console.ReadLine()
            //    //and cast from string to enum Gender becuase Console.Readline return string then need to cast to enum
            //    //2-3]ignorecase by default is false to make case sensitive [Optional] if enter
            //    //like that femla and it is wrote in enum Female and have case sesitive mean both different
            //    //not same then it will be wrong
            //    //but if make ignorecase be true this mean tell ignore case sensitive mena
            //    //if enter female or Female both are true and same
            //    //2-4]output that recieve enter data on it like variable
            //    //becuase use TryParse for Generic
            //    //So make above do while --> variable to recieve data on it and then set this in property in the end

            //}
            //while (!IsParsed);

            //// make variable to recieve entered data from user when enter in enum branch
            //Branch branch;

            //do
            //{
            //    Console.WriteLine("Please Enter a Valid Branch [Dokki , Nasrcity , Maadi , Alex] : \n");
            //    // this is not valid to use property to recieve entered data from user this synatx is wrong and not valid 
            //    // should make variable and then receive entered data from user in this variable
            //    // then save variable in property user.Branch

            //    //IsParsed = Enum.TryParse<Branch>(Console.ReadLine(), true, out user.Branch);

            //    // this is valid becuase use varibale grade and then receive entered data from user
            //    // in this variable then save variable in property make this in the end user.Branch = branch

            //    IsParsed = Enum.TryParse<Branch>(Console.ReadLine(), true, out branch);
            //    //we can make it also
            //    // and it will undertand that we treat with generic Try parse
            //    //IsParsed = Enum.TryParse(Console.ReadLine(), true, out branch);

            //    //2] TryParse for Generic take 4 parameters :-
            //    //2-1]between < > put type of enum like Branch
            //    //2-2]take value from user by useing Console.ReadLine()
            //    //and cast from string to enum Gender becuase Console.Readline return string then need to cast to enum
            //    //2-3]ignorecase by default is false to make case sensitive [Optional]if enter
            //    //like that femla and it is wrote in enum Female and have case sesitive mean both different
            //    //not same then it will be wrong
            //    //but if make ignorecase be true this mean tell ignore case sensitive mena
            //    //if enter female or Female both are true and same
            //    //2-4]output that recieve enter data on it like variable
            //    //becuase use TryParse for Generic
            //    //So make above do while --> variable to recieve data on it and then set this in property in the end

            //}
            //while (!IsParsed);

            //Console.Clear();

            ////save variable in property when recieve entered data from user in variable StdId
            ////to save it in it and then save the value that entered in variable in property
            ////becuase we can't use directly property user.Id becuase this is synatx make error and wrong
            //user.Id = StdId;

            ////save variable in property when recieve entered data from user in variable grade
            ////to save it in it and then save the value that entered in variable in property
            ////becuase we can't use directly property user.Grade becuase this is synatx make error and wrong
            //user.Grade = grade;

            ////save variable in property when recieve entered data from user in variable branch
            ////to save it in it and then save the value that entered in variable in property
            ////becuase we can't use directly property user.Grade becuase this is synatx make error and wrong
            //user.Branch = branch;

            ////save variable in property when recieve entered data from user in object branch
            ////to save it in it and then save the value that entered in variable in property
            ////becuase we can't use directly property user.Grade becuase this is synatx make error and wrong
            //// we should make casting becuase this object and to tell him that return will be form enum Gender
            //user.Gender = (Gender)gender;

            //Console.WriteLine($"Hello your id is {user.Id} and your name is {user.Name}");
            //Console.WriteLine($"Your Gender is : {user.Gender}");
            //Console.WriteLine($"Your Grade is : {user.Grade}");
            //Console.WriteLine($"Your Branch is : {user.Branch}");


            // to make loop on labels or predefined constant and print it 


            ////iterator type must be type of enum like Branch 
            ////inside class Enum have functions called GetValues(typeof(type enum like Branch))
            //// function GetValues Return Array , this Array have labels or predefined constants inside it
            //foreach(Branch branch1 in Enum.GetValues( typeof( Branch ) ) )
            //{
            //    Console.WriteLine(branch1);
            //}

            ////iterator type must be string
            ////inside class Enum have functions called GetNames(typeof(type enum like Branch))
            //// function Names Return Array of string , so should type of iterrator is string
            ////this Array have labels or predefined constants inside it
            //foreach (string branch1 in Enum.GetNames(typeof(Branch)))
            //{
            //    Console.WriteLine(branch1);
            //}

            ////iterator type must be type of enum like Grade 
            ////inside class Enum have functions called GetValues(typeof(type enum like Grade))
            //// function GetValues Return Array , this Array have labels or predefined constants inside it
            //foreach (Grade grade1 in Enum.GetValues(typeof(Grade)))
            //{
            //    Console.WriteLine(grade1);
            //}

            ////iterator type must be string
            ////inside class Enum have functions called GetNames(typeof(type enum like Grade))
            //// function Names Return Array of string , so should type of iterrator is string
            ////this Array have labels or predefined constants inside it
            //foreach (string grade1 in Enum.GetNames(typeof(Grade)))
            //{
            //    Console.WriteLine(grade1);
            //}


            #endregion

            #region Permission Enum
            //User2 user1 = new User2();
            //user1.Id = 1;
            ////user1.Name = "Ahmed";
            //// now need to give him permissions like --> Write Read Delete Execute
            //// so need to access each element alone to give true or false
            //// depened on you need to give peremission or not
            //user1.Permissions[0] = true; // give permission for write
            //user1.Permissions[1] = false;// don't give permission for Read
            //user1.Permissions[2] = true; // give permission for Delete
            //user1.Permissions[3] = false;// don't give permission for Execute
            //// now we reserve 4 bytes for int that belong to id
            //// and reserve 4 bytes for each element in array
            //// becuase it's bool mean 1 byte and have 4 element mean 4 bytes
            //// then total 8 bytes are reserved 

            //// if we make another user 
            //User2 user2 = new User2();
            //user2.Id = 2;
            //user2.Permissions[0] = true; // give permission for write
            //user2.Permissions[1] = false;// don't give permission for Read
            //user2.Permissions[2] = true; // give permission for Delete
            //user2.Permissions[3] = false;// don't give permission for Execute
            //// now we also save 8 bytes in stack and heap like user above


            //// but i don't need to reserve all of this
            //// and the above code need for you to save the arrangement of permission
            //// to know which one is read , write , execute or delete  
            //// so this is so difficult to make this code above 

            //// for simplicity and clean code we will make enum for permissions instead of Array of bool for permissions
            //// put still take 1 permission only we can not give 2 permission in same time 
            //// So we will use Permission enum

            //User2 user = new User2();
            //user.Id = 1;
            //user.Permission = Permissions.Write;
            //Console.WriteLine(user.Permission);
            //user.Permission = Permissions.Read;
            //Console.WriteLine(user.Permission);

            //// So we will use Permission enum
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


            //Write = 1,
            //Read = 2,
            //Delete = 4,
            //Execute = 8

            User2 user = new User2();

            user.Id = 1;
            //user.Permission = (Permissions)1;
            //Console.WriteLine(user.Permission); // o / p-- > will be write
            //// if you need permission write and read make sum for decimal values 1 + 2 = 3 
            //user.Permission = (Permissions)3;
            //Console.WriteLine(user.Permission); // o/p --> will be write , read
            //// if you need permission write and delete make sum for decimal values 1 + 4 = 5 
            //user.Permission = (Permissions)5;
            //Console.WriteLine(user.Permission); // o/p --> will be write , delete
            //// if you need permission write and execute make sum for decimal values 1 + 8 = 9 
            //user.Permission = (Permissions)9;
            //Console.WriteLine(user.Permission); // o/p --> will be write , execute
            //// if you need permission read and delete make sum for decimal values 2 + 4 = 6 
            //user.Permission = (Permissions)6;
            //Console.WriteLine(user.Permission); // o/p --> will be read , delete
            //// if you need permission read and execute make sum for decimal values 2 + 8 = 10 
            //user.Permission = (Permissions)10;
            //Console.WriteLine(user.Permission); // o/p --> will be read , execute
            //// if you need permission delete and execute make sum for decimal values 4 + 8 = 12 
            //user.Permission = (Permissions)12;
            //Console.WriteLine(user.Permission); // o/p --> will be delete , execute
            //// if you need permission write and read and delete and execute
            //// make sum for decimal values 1+ 2 + 4 + 8 = 15
            //user.Permission = (Permissions)15;
            //Console.WriteLine(user.Permission); // o/p --> will be write , read , delete , execute
            //// and so on

            // instead of above we will use Bitwise Operator --> | or , & and , ^ xor

            // 1] --> | or --> will add peremission but if exist Keep it don't make any thing on it
            // 2] --> & and --> check if permission is exist or not
            // 3] --> ^ xor --> add permission if not exist and if exist remove it
            // --> if not exist --> xor will work as sumtion +
            // --> if exist --> xor will work as subtraction - 

            // if permission delete exist remove it and if not exist add it 
            //user.Permission = (Permissions)1;
            //user.Permission ^= Permissions.Delete;
            //Console.WriteLine(user.Permission); // o/p will be 2 permission write and delete

            // if we make above code again then delete is exist then xor will remove it 
            //user.Permission ^= Permissions.Delete;
            //Console.WriteLine(user.Permission); // o/p will be 1 permission write only
            // becuase delete is removed by xor
            // becuase delete is exist and make xor wil remove it

            // we need to check if permission delete is exist or not 
            // & --> check if permission is exist or not if exist will return permission it self 
            // so we compare it by same permission --> permission.Delete
            // if not exist it will return any number for any another permission not Permission Delete
            // but any another permission
            //if ((user.Permission & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("Permission Delete is exist");
            //}
            //else
            //{
            //    Console.WriteLine("Peremission Delete is added");
            //    user.Permission ^= Permissions.Delete;

            //}
            //Console.WriteLine(user.Permission);

            //or --> will add peremission but if exist Keep it don't make any thing on it
            //user.Permission = Permissions.Write;
            //Console.WriteLine(user.Permission); // --> o/p  will be Write 
            //user.Permission |= Permissions.Read;
            //Console.WriteLine(user.Permission); // --> o/p  will be Write , Read 
            //user.Permission |= Permissions.Read;
            //Console.WriteLine(user.Permission); // --> o/p still be Write , Read 

            // if add permission for user --> use | or 
            // if deny permission for user mean take permission from him that have it --> use ^ xor
            #endregion

            #region Struct Ex 1
            //Point P1; // --> this is variable becuase struct point is value type
            //P1 = new Point();
            //// this new for value type and make 1 thing only --> choose constractor [Constractor selection]

            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);

            //Point P2 = new Point(10,20);
            //Console.WriteLine(P2.X);
            //Console.WriteLine(P2.Y);
            
            //after update function Tostring make override 
            //Console.WriteLine(P2); //Performance [Better]
            //Console.WriteLine(P2.ToString()); // Value type ==> Object [Slower]
            #region Constructor [Ctor]
            #endregion

            #endregion

            #region Struct Ex 2
            //Point P1 = new Point() { X = 10 , Y = 20 };
            //Point P2 = new Point() { X = 30 , Y = 40 };
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);

            //P2 = P1;

            //Console.WriteLine();
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);

            //Console.WriteLine();
            //P1.X = 100;
            //P1.Y = 200;

            //Console.WriteLine();
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion

            
        }
    }
}
