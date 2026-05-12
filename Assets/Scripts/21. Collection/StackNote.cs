using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1]Stack 클래스의 객체(개체, 인스턴스)
        Stack stack = new Stack();

        // [2]데이터 입력
        stack.Push("첫번째");
        stack.Push("두번째");
        stack.Push("세번째");

        // [3]데이터 꺼내기
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());

        try
        {
            Debug.Log(stack.Pop());
        }
        catch(System.Exception ex)
        {
            Debug.Log($"에러내용: {ex.Message}");   // stack이 비어있다(stack empty)
        }
        

    }
   
}

/*
 

Queue : FIFO(Frist In Frist Out), 선입 선출 형태로 데이터를 저장, 관리하는 클래스

Stack : LIFO(Last In Frist Out), 후입 선출 형태로 데이터를 저장, 관리하는 클래스
Puch() : 스택 구조에서 데이터 넣기
Pop() : 스택 구조에서 데이터 꺼내기
Overflow : 스택이 가득 찼을 때 발생, 우물이 넘칠 때
Underflow : 스택이 비어있을 때 발생, 우물에 물이 없을 때 
 
 
 
 */
