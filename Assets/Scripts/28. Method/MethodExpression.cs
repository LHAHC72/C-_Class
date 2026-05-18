using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


namespace Mehotd
{
    public class MethodExpression : MonoBehaviour
    {
        // 메소드 축약형
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();
            Debug.Log(DoubleValue(4));
            Debug.Log(DoubleSum(3,5));


        }

        // [1] 메서드 - 기본 형식 
        void Work()
        {
            Debug.Log("Work 실행");
        }

        // [2] 메서드 축약형 - 실행명령문 1줄
        void Hello() => Debug.Log("Hello 실행");

        // 매개변수를 입력받은 정수 값을 두배로 반환하는  함수
        int DoubleValue(int value) => value * 2;

        // 매개변수로 입력받은 두 정수의 합을 반환하는 함수 만들기 - 축약형으로
        int DoubleSum(int a, int b) => a + b;

    }
}