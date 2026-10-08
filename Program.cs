// int a = int.Parse(Console.ReadLine());
// int i;
// int b;
// for (i = 1; i <= 10; i++){
//     b = i * a;
//     Console.WriteLine("{0} * {1} = {2}", a, i, b);
// }



// int i;
// for (i = 10; i >= 1; i--){
//     Console.WriteLine("{0}", i);
// }

// int i;
// for (i = 2; i <= 50; i+=2){
//     Console.WriteLine("{0}", i);
// }

int a = 0;
int b = 0;
int i;
for (i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        a = a + i;
    }
    if (i % 7 == 0)
    {
        b = b + 1;
    }
}
Console.WriteLine("{0}", a);
Console.WriteLine("{0}", b);