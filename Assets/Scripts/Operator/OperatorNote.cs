using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "World");
        Debug.Log("Hi" + " " + "EveryOne");

        Debug.Log("123" + "456");               // 123456         문자열 + 문자열 = 문자열 취급
        Debug.Log("123" + 456);                 // 123456         문자열 + 숫자 = 문자열 취급 
        Debug.Log(123 + "456" + 789 + 890);     // 123456789890   숫자 + 문자열 + 숫자 + 숫자 = 문자열 취급
        Debug.Log(123 + 456);                   // 579            숫자 + 숫자 = 산술 연산

        Debug.Log("123" + true);              //123True         문자열 + bool 형식 = 문자열 취급

        // Debug.Log("123" - "456");            오류
    }

  
}
