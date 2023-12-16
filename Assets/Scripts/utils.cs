using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class utils 
{
    public static float epsilon = 0.01f;
    public static bool ApproxEqual(float a , float b)
    {
        return  (Mathf.Abs(a-b)<epsilon);
    }

    public static float clamp (float value, float min , float max)
    {
        if(value< min)
            value = min;
        if(value > max)
            value = max;
        return value;
    }
    public static float AngleDiff (float a, float b){
        float diff = a - b;
        if (diff > 180)
            return diff - 360;
        else if(diff < - 180) 
            return diff + 360;
        return diff;
    }
    public static float Degree360(float angleDegree)
    {
        while (angleDegree>=360)
            angleDegree -=360;
        while (angleDegree < 0)
            angleDegree +=360;
        return angleDegree;
    }
}
