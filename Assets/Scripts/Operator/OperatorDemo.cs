using UnityEngine;

//Operator: 연산자, +,-,*,/, .....

public class OperatorDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // [1] UneryOperator(단항 연산자) : + , -
        int value = 0; // 정수형 변수 value 선언하고 0으로 초기화

        value = 8;          // 정수형 변수 value에 8을 저장
        value = +value;     // 정수형 변수 value에 + value 값을 저장

        Debug.Log(value);   // 8 출력

        value = -8;         // 정수형 변수 value에 -8을 저장
        value = +value;     // 정수형 변수 value에 + value 값을 저장 
        Debug.Log(value);   // -8 출력

        value = -8;         // 정수형 변수 value에 8을 저장
        value = +value;     // 정수형 변수 value에 - value 값을 저장 
        Debug.Log(value);   // -8 출력

        value = -8;         // 정수형 변수 value에 -8을 저장
        value = +value;     // 정수형 변수 value에 - value 값을 저장 
        Debug.Log(value);   // -8 출력

        // [2] (이항)연산자: +, -, *, /, %

        int i = 5;
        int j = 3;

        int k;

        k = i + j;
        Debug.Log(k);

        k = i - j;
        Debug.Log(k);

        k = i * j;
        Debug.Log(k);

        k = i / j;
        Debug.Log(k);

        k = i % j;
        Debug.Log(k);


    }

}
