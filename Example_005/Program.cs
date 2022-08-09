int[] array1 = { 2, 5, 3, 5, 1, 2 };
int[] array2 = { 4, 5, 3, 4, 2, 1};
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

