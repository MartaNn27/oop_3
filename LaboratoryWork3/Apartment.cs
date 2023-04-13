using System;

class Appartament
{
    double a, b, h;
    public static int windows;


    public double Width
    {
        get { return a; }
        set { a = value; }
    }
    public double Len
    {
        get { return b; }
        set { b = value; }
    }
    public double Height
    {
        get { return h; }
        set
        { h = value; }
    }
    public int Windows
    {
        get { return windows; }
        set { windows = value; }
    }

    public Appartament()
    {
        //a = 0;
        //b = 0;
        //h = 0;
        //windows = 0;
    }
    public Appartament(double Avalue, double Bvalue, double Hvalue, int v)
    {
        a = Avalue;
        b = Bvalue;
        h = Hvalue;
        windows = v;

    }
    public double Area()
    {
        return a * b;
    }
    public double Volume()
    {
        return a * b * h;
    }
    public override string ToString()
    {
        return " Width = " + Width + "\n" + " Lenght= " + Len + "\n" + " Height =  " + Height + "\n" + " Count of windows = " + Windows;
    }
}
