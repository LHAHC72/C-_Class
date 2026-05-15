using UnityEngine;
namespace Method
{

    public class ParameterIn : MonoBehaviour
    {
        void Start()
        {
            int num = 10;
            Debug.Log($"[1]: {num}");   // [1] ? = 10 

            PrintNumber(num);   
            Debug.Log($"[3]: {num}"); // [3] ? = 10
        }


        // 매개변수로 전달된 정수값을 출력하는 함수

        // [1] 값 전달 방법 : (int num)

        private void PrintNumber(int num)
        {
            num = 20;
            Debug.Log($"[2]: {num}");   // [2] ? = 20
        }


        // [2] 참조 전달 방식 : (ref int num)



    }
}

/*
 
Parameter(매개변수) : 연산에 필요한 데이터를 함수 호출시 전달해줌.
= 매개변수 전달 방법으로 메서드 분류

[1] 값 전달 방식
: (int num)

[2] 참조 전달 방식
: (ref int num)

[3] 반환형 전달 방식
: (out int num)


[4] 가변형 전달 방식 (1~3번이랑 살짝 성격 틀림)
: (params int[] numbers)
 
 */