void CreateArray(int[] Collection) {
    int index=0;
    int length = Collection.Length;
    while (index < length) {
        Collection[index] = new Random().Next(0,10);
        index++;
    } 
}

void PrintArray(int[] Col) {
    int index = 0;
    int length = Col.Length;
    while (index<length) {
        Console.Write(Col[index]+" ");
        index++;
    }
}

int[] array1 = new int[20];
int[] array2 = new int[20];

CreateArray(array1);
CreateArray(array2);
PrintArray (array1);
PrintArray (array2);

int count = 0;

int size1 = array1.Length;
int size2 = array2.Length;

int index1 = 0;
int index2 = 0;

while (index1 < size1-1) {
    while (index2 < size2-1) {
        if (array1[index1] == array2[index2+1] &&
        array1[index1+1] == array2[index2] ||
        array1[index1] == array2[index2] &&
        array1[index1+1] == array1[index2+1]) 
        {
            count++;
        }
        index2++;
    }
    index1++;
    index2 = 0;
}
Console.WriteLine(count);

