Console.Write("Массив из восьми рандомных элементов: ");

int Randy() {
    Random rd = new Random();
    int rand = rd.Next(1, 9);
    return rand;
}

int[] arr = {Randy(), Randy(), Randy(), Randy(), Randy(), Randy(), Randy(), Randy()};
int lngth = arr.Length;

Console.Write("[");
for (int i = 0; i < lngth; i ++) {
    Console.Write(arr[i] + (i < lngth - 1 ? ", " : ""));
}
Console.Write("]");