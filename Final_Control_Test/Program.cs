int SizeArray(string[] array) {
    int n = 0;
    for (int i = 0; i < array.Length; i++) {  
        if (array[i].Length <= 3) {  
            n++;
        }
    }
    return n;
}

string[] CreateArray(string[] array, string[] newArray) {   
    int index = 0;
    for (int i = 0; i < array.Length; i++) {  
        if (array[i].Length <= 3) {  
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void ShowArray(string[] newArray) {
    for (int i = 0; i < newArray.Length; i++) {
        Console.Write($"{newArray[i]} ");
    }
}

string[] array = {"-2", "Geek Brains","hello", ";-)", "13", "world", "cat"};  
string[] newArray = new string[SizeArray(array)];  


CreateArray(array, newArray);
ShowArray(newArray);
Console.WriteLine();