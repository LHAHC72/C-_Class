using UnityEngine;



public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 4! 값을 구하는 프로그램을 구현
        // 4! 값은 ?

        int n = 4;
        int fac = 1;
        for (int i = 1; i <= n; i++)
        {
            fac = fac * i;
        }
        Debug.Log($"{n}! 값은 {fac} ");

    }

  
}

/*
 
factorial
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3

n! = 1 * 2 * 3 .... (n-1) * n
 
 */