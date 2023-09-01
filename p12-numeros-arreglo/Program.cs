// Programa que: 
// Cree un arreglo con los siguientes elementos: 100, 123, 456, 222, 999, 895, 325, 234, 322, 988.
// Después:
// • Muestre los elementos
// • Calcule y muestra la suma de los elementos
// • Divida entre 2 cada elemento, calcule y muestra la suma
// • Muestre el arreglo en orden inverso
// Nota: Cada operación deberá programarse como una función, y estas deben estar en una biblioteca (clase).

int[] arreglo = {100, 123, 456, 222, 999, 895, 325, 234, 322, 988};
int sum=0, sumDiv=0;
int[] aInv;

Console.Clear();
sum = clase.suma(arreglo);
sumDiv = clase.divicion(arreglo);
aInv = clase.inverso(arreglo);
clase.imprimeinv(aInv);

Console.WriteLine($"Los elementos del arreglo son         : {clase.imprime(arreglo)} ");
Console.WriteLine($"Suma de los elementos                 : {sum} ");
Console.WriteLine($"Suma de los elementos divididos       : {sumDiv} ");
Console.WriteLine($"Los elementos del arreglo inverso son : {clase.imprime(aInv)} ");

