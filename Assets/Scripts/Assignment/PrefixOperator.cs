using UnityEngine;

//PrefixOperator(전위 증감연산자) : 앞에 위치하는 증감연산자, 같은 라인에서 연산하는 순위가 가장 높음
//PostfixOperator(후위 증감연산자) : 뒤에 위치하는 증감연산자, 같은 라인에서 연산하는 순위가 가장 낮음

public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 전위 증감연산자
        int i = 3;
        int j = ++i;
        Debug.Log($"i: {i}"); // 4
        Debug.Log($"j: {j}"); // 4

        // [2] 후위 증감연산자
        int x = 3;
        int y = x++;
        Debug.Log($"x: {x}"); // 4
        Debug.Log($"y: {y}"); // 3

        // [3] 누적식
        int a = 3;
        int b = 5;

        // 누적: b변수에 a변수의 값을 누적
        b += a;
        Debug.Log($"b: {b}");

        // 누적: b변수에 a변수의 감산 값을 누적
        b -= a;
        Debug.Log($"b: {b}");

    }



 
}
