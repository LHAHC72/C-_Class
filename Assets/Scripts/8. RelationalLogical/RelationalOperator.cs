using UnityEngine;

//RelationalOperator(관계형 연산자, 비교연산자)
// <(작음), <= (작거나 같음),>(큼), >=(크거나 같음), == (같음), !=(다름)
// 연산 결과: 참(true), 거짓(false)

public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;

        Debug.Log(a < b); // a는 b보다 작으냐?
        Debug.Log(a <= b); // a는 b보다 작거나 같으냐?
        Debug.Log(a > b); // a는 b보다 크냐?
        Debug.Log(a >= b); // a는 b보다 크거나 같으냐?
        Debug.Log(a == b); // a는 b와 같으냐?
        Debug.Log(a != b); // a는 b와 다르냐?

        Debug.Log("AAA" == "aaa"); // false, 대소문자 구분함



    }

   
}
