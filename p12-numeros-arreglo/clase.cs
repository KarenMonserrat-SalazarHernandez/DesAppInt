// Bliblioteca de funciones estadisticas 

public static class clase{
        public static string imprime(int[] a)
    {
        return string.Join(",", a);
    }
    public static int suma(int[] a)
    {
        int suma = 0;
        foreach (int n in a)
        {
            suma += n;
        }
        return suma;
    }
    public static int divicion(int[] a)
    {
        int sumaDiv = 0;
        foreach (int n in a)
        {
            sumaDiv += n / 2;
        }
        return sumaDiv;
    }
    public static int[] inverso(int[] a)
    {
        int[] arreInv = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            arreInv[i] = a[a.Length - 1 - i];
        }
        return arreInv;
    }
       public static string imprimeinv(int[] arreInv)
    {
        return string.Join(",", arreInv);
    }
}
