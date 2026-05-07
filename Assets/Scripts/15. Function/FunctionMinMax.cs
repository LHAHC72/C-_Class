using UnityEngine;

// 두개의 정수를 입력받아 두 수 중 작은 수, 큰 수를 찾는 프로그램 구현

// 입력받은 정수의 절대값을 구하는 프로그램

public class FunctionMinMax : MonoBehaviour
{

    // 인스펙터창 입력
    public int a = 0;
    public int b = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int result = Min(-5, -3);
        Debug.Log(result);

        Debug.Log(Max(5,3));*/

        // a,b의 작은 값 구하기, 큰 값 구하기
        int minValue = Min(a , b);
        Debug.Log($"작은 값은 {minValue}");

        int maxValue = Max(a, b);
        Debug.Log($"큰 값은 {maxValue}");

        // Debug.Log(Abs(a));
        Debug.Log(Mathf.Abs(a)); // C#(닷넷에서 제공하는 절대값 구하는 내부함수 Mathf)


    }

    // 매개변수로 입력받은 두 수 중 작은 수를 반환하는 함수
    int Min(int x, int y)
    {
        if(x < y) // x가 작으면 
        {
            return x; // x 반환 
        }
        else // y 가 작으면
        {
            return y; // y 반환
        }
    }


    // 매개변수로 입력받은 두 수 중 큰 수를 반환하는 함수
    int Max(int x, int y)
    {
        /*int maxValue = 0;

        if (x >= y) // x가 크면
        {
            maxValue = x; // x 반환 
        }
        else  // y 가 크면
        {
            maxValue = y; // y 반환
        }
        return maxValue;*/


        /*
        // 3항 연산자
        // (조건식) ? 참일 때 반환값 : 거짓일 때 반환값
        int maxValue = ( x > y ) ? x : y; 

        return maxValue;
        */

        return (x > y) ? x : y; 

    }

    // 매개변수로 입력받은 정수의 절대값을 반환하는 함수
    int Abs(int number)
    {
        /*if(number < 0)
        {
            return -number;
        }

        else
        {
            return number;
        }*/

        return number < 0 ? -number : number;
    }
}
