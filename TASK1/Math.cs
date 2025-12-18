using System;
using Microsoft.VisualBasic;

namespace TASK1;

public class Math
{

public const double PI=3.14;
public const double E=2.71;


public double ABSOLUTE(double value)
    {
        if (value < 0)
        {
            value=value*(-1);
            return value;
        }
        return value;
    }

public float ABSOLUTE(float value)
    {
        if (value < 0)
        {
            value=value*(-1);
            return value;
        }
        return value;
    }

public int ABSOLUTE(int value)
    {
        if (value < 0)
        {
            value=value*(-1);
            return value;
        }
        return value;
    }

public double PowN(double x , double y)
    {
        if (y > 0)
        {
            double pow=1;
            for(int i=0 ; i<y ; i++)
            {
                pow*=x;
            }
            return pow;
        }
        else if(y<0)
        {
             double pow=1;
            for(int i=0 ; i<y ; i++)
            {
                pow/=x;
            }
            return pow;
        }
        return 1;
    }    

public double SQRT(int d)
    {
        double res=System.Math.Sqrt(d);
        return res;
    }

public int Max(int v1 , int v2)
    {
        if (v1 > v2)
        {
            return v1;
        }
        return v2;
    }

public int Min(int v1 , int v2)
    {
        if (v1 < v2)
        {
            return v1;
        }
        return v2;
    }


}
