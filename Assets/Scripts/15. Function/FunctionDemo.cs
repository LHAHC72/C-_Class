using UnityEngine;

public class FunctionDemo : MonoBehaviour
{
    // [1-1] 매개변수 없는 함수 만들기(선언, 정의)
    void Hi()
    {
        Debug.Log("안녕하세요");
    }

    // [1-2] 매개변수(Parameter) 있는 함수 만들기
    void ShowMessage(string message)
    {
        Debug.Log(message);
    }

    // [1-3] 반환값(return)이 있는 함수 만들기(매개변수 없는)
    // 문자열을 반환하는 함수
    // 반환값과 같은 데이터 타입의 변수로 반환값 저장
    // 반환값을 받아줄 변수 선언해 값을 받아옴
    string GetString()
    {
        // return 키워드로 (데이터 타입에 맞게) 반환
        return "반환값(return Value)";
    }


    void Start()
    {
        // [2] 함수 사용하기, 호출하기, call
        Hi();
        // Hi();
        // Hi();
        
        ShowMessage("누구냐 넌");

        GetString(); // 이렇게 하면 반환이 안됨. 데이터 타입이 없기 때문임

        string reValue = GetString(); // 반환 값과 같은 데이터 타입의 변수로 반환
        Debug.Log(reValue);

    }

}

/*
     
    - 함수(Function, 메서드, Method)
    : 반복해서 사용하도록 만들어진 하나 이상의 명령문을 포함하고 있는 코드 블록
    : 가장 작은 단위에 프로그래밍
    : 입력 -> 연산 -> 출력

    - 함수의 종류
    : 내장 함수 - C#(닷넷)에서 제공하는 함수, 유니티에서 제공하는 함수
    : 사용자 함수 - 유저(개발자)가 만드는 함수

    - 함수의 분류
    : 매개 변수가 없는 함수
    : 매개 변수가 있는 함수
    : 반환 값이 있는 함수


    


    1. 매개변수가 없는 함수
    void 함수이름()
    {
        하나 이상의 명령문...
    }


    2. 매개변수가 있는 함수
    void 함수이름 (매개변수)
    {
        하나 이상의 명령문...
    }


    3. 반환값이 있는 함수
    (데이터타입) 함수이름(매개변수 있을수도 없을수도)
    {
        하나 이상의 명령문...

        return (데이터타입)변수;
    }


    * void 가 붙으면 반환값이 없는 함수
     
     */
