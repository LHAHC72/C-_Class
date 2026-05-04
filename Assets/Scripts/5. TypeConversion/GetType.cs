using UnityEngine;

public class GetType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //변수의 타입 알아보기
        int i = 1234;               // 정수
        string s = "안녕하세요";    // 문자열
        char c = 'a';               // 문자
        double d = 3.14;            // 실수

        Debug.Log(i.GetType()); // i 변수의 타입을 콘솔창에 출력
        Debug.Log(s.GetType()); // s 변수의 타입을 콘솔창에 출력
        Debug.Log(c.GetType()); // c 변수의 타입을 콘솔창에 출력
        Debug.Log(d.GetType()); // d 변수의 타입을 콘솔창에 출력

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
