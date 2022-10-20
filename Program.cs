int update =0; 

Timer myTimer = new Timer(test,null,0,2000); 
Timer timer2 = new Timer(test2,null,0,2000); 
Timer timer3 = new Timer(test3,null,0,2000);

void test(object o)
{ 
    Console.WriteLine(update); 
    update++; 
}

void test2(object o)
{
    Console.WriteLine("Test 2 running "); 
}

void test3(object o )
{
    Console.WriteLine(" Blah "); 
}

Console.ReadKey(); 

