int[] array = {1,5,6,7,8,3,6,8,4,6,4,8};
int n = array.Length;
int find = 4;
int index = 0;
 while (index<n) {
    if(array[index] == find) {
        Console.WriteLine(index);
        break;
    }
    index++;
 }
