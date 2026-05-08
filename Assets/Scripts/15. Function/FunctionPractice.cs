using UnityEngine;

// 두개의 정수를 입력받아 더하기, 빼기, 곱하기, 나누기, 나머지 값을 구하는 프로그램 구현
// 단, 0으로 계산하는 경우는 배제

public class FunctionPractice : MonoBehaviour
{
    public int a = 0;
    public int b = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"더하기:{Add(a,b)}");
        // Debug.Log($"빼기:{Sub(a, b)}");
        Debug.Log($"빼기:{Substract(a, b)}");
        Debug.Log($"곱하기:{Mul(a, b)}");
        Debug.Log($"나누기:{Div(a, b)}");
        Debug.Log($"나머지:{Remain(a, b)}");

    }

    int Add(int a, int b)
    {
        return a + b;
    }
    
    int Sub(int a, int b)
    {
        return a - b;
    }

    // 화살표 함수
    int Substract(int a, int b) => a - b;


    int Mul(int a, int b)
    {
        return a * b;
    }

    int Div(int a, int b)
    {
        // 0으로 나눌 때를 대비한 방어코드
        if(b == 0)
        {
            return 0;
        }

        return a / b;
    }

    int Remain(int a, int b)
    {
        // 0으로 나눌 때를 대비한 방어코드
        if (b == 0)
        {
            return 0;
        }
        return a % b;
    }


    
}
