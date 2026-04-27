//[1] 네임스페이스 선언부
using UnityEngine;  // 현재 cs(C# Script) 파일에서 UnityEngine 네임스페이스를 사용

//[2] 클래스 선언부
public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // [3] Start 메소드 정의(선언) : 프로그램 시작할 때 1번만 실행
    void Start()
    {
        //[5] 명령문 : 콘솔창에 출력하라
        Debug.Log("Hello, World");
    }

    // Update is called once per frame
    //[4] Update 메소드 정의(선언) : 프로그램 시작 후에 매 프레임마다 실행
    void Update()
    {
        
    }
}
