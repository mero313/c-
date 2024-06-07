 class Problem12_3{
    public static void BubbleSort(){
        
        Console.WriteLine("Input number of strings");
        int strsNum = Convert.ToInt32(Console.ReadLine());
        String[] arr = new string[strsNum];
        String temp = " ";
        String temp2 = " ";        
        Console.WriteLine("Input "+strsNum+" strings belows");
        for (int i = 0; i < strsNum; i++)
        {  
            arr[i] = Console.ReadLine();
        }

        for (int i = 0; i < strsNum-1; i++)
        {
            temp = arr[i];
            temp2 = arr[i+1];

            if(temp[0] > temp2[0]){
                arr[i+1] = temp;
                arr[i] = temp2;
            }

        }

        for (int i = 0; i < strsNum; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}




 