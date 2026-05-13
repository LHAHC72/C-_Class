using UnityEngine;

public class ClassNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 다른 클래스의 맴버 호출
        // [1] 정적(static) 맴버 호출: 클래스이름.메서드이름
        ClassOne.Hi();
        ClassTwo.Hi();

        // [2] 인스턴스 맴버 호출 :
        // 맴버가 속한 클래스의 인스턴스(객체) 생성: 인스턴스이름.메서드이름()

        ClassTwo ct = new ClassTwo();
        ct.Hello();


    }

    
}
