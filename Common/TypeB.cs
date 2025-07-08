namespace Common
{
    internal class TypeB
    {
        //making instructor and try to access data x,y,z that inside class TypeA
       public TypeB()
        {
            TypeA typeA = new TypeA();
            //typeA.x = 10; // invalid to access [x] becuase x in class TypeA is [private]
                          // mean can't access it outside his scope
                          // mean can't access it outside class TypeA
                          // mean accessable only inside it's scope inside class TypeA only

            typeA.y = 20; // valid to access [y] becuase access modifier in class TypeA is [internal]
                          // mean you can access it inside it's scope inside class TypeA 
                          // and mean you access it outside it's scope in any another scope
                          // but have 1 condition which should any another scope should be inside
                          // in same project
                          // mean in same this project [Common] 
                          // if any another scope outside this project [common]
                          // then we can not access [y] 

            typeA.z = 30; // valid to access [z] becuase modifier in class TypeA is [public]
                          // mean you can access it inside it's scope inside class TypeA 
                          // and mean you access it outside it's scope in any another scope
                          // and if any another scope outside project [common] not inside same project
                          // you can access it also becuase this access modifier [public] 
                          // mean you can access [z] in any another scope inside same solution
                          // in any project inside same solution
                          // and if you make reference project inside another project ,
                          // you can also access [z]
        }
    }
}
