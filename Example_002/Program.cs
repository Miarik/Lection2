int[] massive = {11,21,34,5,64,34,56,67,33,23};


void max(int[] array) {

int length = array.Length;
int index = 0;
int maximum = array[index];

while (index < length) {
    if (array[index]>maximum) {
        maximum = array[index];
    }
    index++;
}
Console.WriteLine(maximum);

}

max(massive);
