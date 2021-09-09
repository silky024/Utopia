using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScripts : MonoBehaviour
{
    int width, height, result, i, a;
    float f;
    char c;
    bool b;
    double d;

    // Start is called before the first frame update
     void Start()
    {
        for (int i = 0; i <= 100; i++)
        {
            print(i);
        }
        int oddnum = 1;
        while (oddnum <= 100)
        {
            print(oddnum);
            oddnum += 2;
            
        }
        for (int i = 0; i <= 100; i++)
        {
            if ((i % 2) == 0)
            {
                print(i);
            }
            // if inside ( 9 % 2 => if reminder 0 even, if reminder 1 odd )
        float a = 4.0f;
        float r = circle(a);
        print(r);
        
        }
        float circle(float a)
        {
            float result;
            a = 4.0f;
            result = 3.14f * a;

            print(result);    
            return (result);
        }

    }   
}
