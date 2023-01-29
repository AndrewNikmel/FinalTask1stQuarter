


string [] CreateArray(int length){
    string [] array = new string[length];
    for(int i = 0; i < length; i++){
        Console.WriteLine($"Введите элемент массива под индексом {i}: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

// void ShowArray(string [] array){
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// void CountSymbols(string [] array){
//     for(int i = 0; i < array.Length; i++){
//         int amountOfSymbols = 3;
//         int count = array[i].Length;
//         if(count <= amountOfSymbols){
//             Console.Write(array[i] + " ");
//             }
//         else{
//             Console.Write(" ");
//         }

//     }
// }


// Console.WriteLine("Введите количество элементов массива: ");
// int length = Convert.ToInt32(Console.ReadLine());
// string [] newArray = CreateArray(length);
// ShowArray(newArray);
// Console.WriteLine();
// Console.WriteLine("Указанные ниже элементы массива строк состоят из 3х и менее символов:");
// CountSymbols(newArray);
