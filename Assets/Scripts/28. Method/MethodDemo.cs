using UnityEngine;


namespace Method
{

    public class MethodDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log($"MethodDemo 실행");


            // Dog 클래스의 인스턴스 생성
            Dog dog = new Dog();

            dog.Eat();
            // dog.digest();    불가능, private 인스턴스 메서드이기 때문


            // dog.Drink();     불가능, Static(정적)이기 때문
            Dog.Drink();        // 정적은 형식이 클래스.메서드()
            
        }


    }
}

/*
 
 Method(메서드, 함수, function) 
: 클래스가 수행하는 기능을 하나의 이름으로 묶어서 관리하는 코드블록
: 클래스의 기능 구현
 
= 메서스 네이밍
: 동사 + 명사
: GetName, SetName, GetHp


[1] 메서드 구성 요소
public(private) static(있거나 없거나) void(반환값, int/string/bool/float/object...) 메서드이름(매개변수)
{
    실행 명령문들...
}

 */