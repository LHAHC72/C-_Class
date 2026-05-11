using UnityEngine;

public class ClassDemo : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정적(static) 메소드 호출: 클래스 이름.메서드 이름\\\\\\\\\\\\\\\
        // (클래스 이름).메서드 이름, (클래스 이름). 변수 이름
        ClassMember.StaticMethod();


        // [2] 인스턴스(Instance) 메서드 호출
        // 클래스의 객체를 생성 : new 키워드로 생성
        // (객체 이름).메서드이름 (객체이름). 변수이름

        ClassMember member = new ClassMember(); // Classmemeber 타입의 member라는 객체 생성
        member.InstanceMethod(); // (객체이름.메서드이름)
        
    }

}


/*
 
Class(클래스) : 하나의 이름으로 서로 다른 형식의 데이터들과 함수들을 묶어 관리하는 데이터 구조
, C#(닷넷)에서 사용하는 기본 구문

클래스 객체(개체, 인스턴스) 변수 선언 : 
new 키워드로 새로운 객체를 생성
(개발자가 만든 클래스이름) 객체이름 = new 클래스이름();


클래스 선언, 정의
class 클래스이름
{

}

클래스에 안에 있는 함수 (Funcion, 메서드) 사용
 
 
*/