using UnityEngine;

// 데이터 값 (Literal) - 변수에 저장할 데이터 값의 종류
public class VariableLiteral : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수 만들기(선언)
        int num;    // i 이름으로 정수형 변수를 만든다, 그릇모양(타입) 그릇이름
        double su;  // 실수형 변수(3.141592)
        bool flag;  // 부울형 변수(참(true), 거짓(false)를 담는 그릇)
        string str; // 문자열 변수("안녕하세요", "Hello World")
        char c;     // 문자형 변수('a','김')

        // [2] 변수에 값을 저장
        num = 1234;
        su = 3.141592;
        flag = false;  // true
        str = "안녕하세요";
        c = 'b';

        // [3] 변수 사용하기
        Debug.Log("num:" + num);
        Debug.Log("su:" + su);
        Debug.Log("flag:" + flag);
        Debug.Log("str:" + str);
        Debug.Log("c:" + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
