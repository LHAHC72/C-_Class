using UnityEngine;



public class IncrementNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정수형 변수의 값을 1씩 증가하기
        // 정수형 변수 num 선언하고 10으로 초기화
        int num = 10;
        // 정수형 변수 num 의 값을 1씩 증가하는 식, 증가 후 다시 num 에 저장
        num += 1; // num 1 증가식

        Debug.Log($"num: {num}"); // 11 


        // [2] 정수형 변수의 값을 1씩 감소하기
        // 정수형 변수 number 선언하고 10으로 초기화
        int number = 10;
        // 정수형 변수 num 의 값을 1씩 감소하는 식, 감소 후 다시 num 에 저장
        number -= 1; // num 1 감소식

        Debug.Log($"number: {number}"); // 9

        // [3] 증가식, 감소식 축약해서 사용하기
        // 2씩 증가하는 식
        int x = 3;
        x = x + 2; // 2씩 증가시켜주는 식
        Debug.Log($"x: {x}");

        // 2씩 증가하는 축약식
        int y = 3;
        // y = y + 2;
        y += 2;
        Debug.Log($"y: {y}");





    }

   
}
