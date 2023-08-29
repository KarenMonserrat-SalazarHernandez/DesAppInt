// Bliblioteca de funciones estadisticas 

public static class est {
    public static string imprime(double[] a){
        return string.Join(",", a);
       // for(int i=0; i<a.Length; i++)
            //Console.WriteLine(a[i]);//vertical
           // Console.Write($"{a[i]:f2} "); //horizontal
    }
    public static double Mayor(double[] a){
        double m=a[0];
        foreach(double n in a)
            if(n>m) m=n;
        return m;
    }
    public static double Menor(double[] a){
        double m=a[0];
        foreach(double n in a)
            if(n<m) m=n;
        return m;
    }
    public static double Promedio(double[] a){
        double p=0;
        foreach(double n in a)
            p += n;
        return p / a.Length;
    }
    public static double Varianza(double[] a, double p){
        double s=0;
        foreach(double n in a)
            s += Math.Pow(n - p,2);
        return s / a.Length;
    }
}