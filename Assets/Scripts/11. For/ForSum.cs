using UnityEngine;

public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 20까지의 합을 구하는 프로그램 구현
        /*int n = 20;
        int sum1 = 0; // 합

        for(int i = 1; i <= n; i++)
        {
            sum1 += i; // 누적식
        }

        Debug.Log($"합은 {sum1}");*/

        
        // 1부터 n(10)까지의 정수 중 짝수의 합을 구하는 프로그램 구현
        
        /*int n = 10;
        int sum2 = 0;
        for(int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum2 += i;
            }
        }

        Debug.Log($"합은 {sum2}");*/
        

        // 카운트 다운1

        for(int i = 1; i <= 5; i++)
        {
            Debug.Log($"Count: {i}");
        }

        Debug.Log("------------");

        // 카운트 다운2

        for (int i = 5; i >= 1; i--)
        {
            Debug.Log($"CountDown: {i}");
        }



    }



}
