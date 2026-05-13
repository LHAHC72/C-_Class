using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Stack<T> 클래스 인스턴스 생성 : 문자열 전용
        Stack<string> stack = new Stack<string>();

        /*
        // [2] 데이터 넣기
        stack.Push("Ten");
        stack.Push("10");

        // [3] 데이터 꺼내기
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        */

        // [1] 컬렉션
        Stack st1 = new Stack();
        st1.Push(1234);
        int number1 = (int)st1.Pop();   // Object타입이기 때문에 명시적 변환 필요
        Debug.Log(number1);

        // [2] 제네릭 사용: int 전용
        Stack<int> st2 = new Stack<int>();
        st2.Push(4567);
        int number2 = st2.Pop();
        Debug.Log(number2);

        // [3] 제네릭 클래스의 장점
        // 1. 형식의 안정성
        Stack o = new Stack();  // 일반 스택
        o.Push(9871);
        o.Push("Hello");
        Debug.Log(o.Pop()); 
        // 일반 스택은 다른 형식이 들어왔을 경우 object 형식으로 들어오기 때문에
        // 하나하나 is이나 as문으로 추가로 명시적 형식변환이 필요함
        // 번거로움

        Stack<int> i = new Stack<int>();
        i.Push(1);
        // i.Push("One");  // 제네릭은 형식을 먼저 지정하기 때문에 문자열을 넣으려 하면 오류가 남
        Debug.Log(i.Pop());

        // 2. 성능 최적화
        o.Push(1234);   // 1234는 값형 -> 이 1234라는 값형을 Object형식에 저장(박싱)
        int number3 = (int)o.Pop(); // Object형을 number3 라는 값형에 꺼내 넣음(언박싱)
        Debug.Log(number3); 
        // Object 형은 자료형중에 가장 큰 그릇, 단 콜렉션은 대부분 대량의 데이터를 관리하기에
        // int형을 저장하는데에 Object형을 사용하는건 낭비.

    }

    
}

/*
 클래스(class) : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조

제네릭 클래스(Generic Class) : 형식 매개 변수 T에 지정한 형식으로 클래스의 맴버의 성질을 결정
: Cup.<T> 컵어브티, 전용컵
 
 
 */