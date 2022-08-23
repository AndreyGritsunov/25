int[] arr = new int[2];
for(int i = 0; i < 2; i++)
{
    Console.WriteLine("Введите число " + Convert.ToString(i + 1) + ": ");
    arr[i] = Convert.ToInt32(Console.ReadLine());

    if(i == 1) {
        int index = 0;
        int sum = 1;
        while(index < arr[i]){
            sum = sum * arr[0];
            index++;
        }
        Console.Write(sum);
    } 
}   
