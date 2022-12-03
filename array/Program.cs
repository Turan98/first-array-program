
int a;
int sum =0;
Console.Write("Enter amount of array: ");
a = Convert.ToInt32(Console.ReadLine());
int [] array1 = new int [a];
for (int i = 0; i < array1.Length; i++)
{
    Console.Write("Enter element of array under index " + i + ": ");
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
 Console.WriteLine("Enter our array");
for (int i = 0; i < array1.Length; i++)
{
   
   Console.WriteLine(array1[i]);
   if (array1[i] % 2 ==0)
{
    sum = sum + array1[i];

}
}
Console.WriteLine("Sum of evens elements of array: " + sum);
Console.WriteLine("\nElements of array since end to begin: ");
for (int i = array1.Length -1 ; i >= 0; i--)
{
    Console.WriteLine(array1[i]);
}







