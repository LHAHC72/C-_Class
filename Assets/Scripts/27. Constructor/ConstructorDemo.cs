using UnityEngine;

namespace Constructor
{
    public class ConstructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Student 클래스의 (생성자를 호출해서) 인스턴스(객체)를 생성
            Student student = new Student();

            // Dog 클래스의 객체(인스턴스) 를 생성
            // 매개변수가 있는 생성자를 이용하여 객체 생성
            Dog happy = new Dog("해피");
            Debug.Log($"강아지 이름은 {happy.GetName()}");

            Dog worry = new Dog("워리");
            Debug.Log($"옆집 강아지 이름은 {worry.GetName()}");

            // User 클래스의 인스턴스(객체) 생성
            // [1] 기본 생성자 호출
            User user1 = new User();
            user1.ShowUserInfo();

            // [2] 매개변수가 있는 생성자 호출
            User user2 = new User("백두산");
            user2.ShowUserInfo();

            User user3 = new User("장길산", 25);
            user3.ShowUserInfo();



            

        }    
    }

}

/*
 
 Constructor(생성자) 
: 클래스가 사용될 떄 제일 먼저 호출되는 메서드
: 객체를 생성할 때 호출된다.
: 클래스의 필드의 기본값을 설정하는 역할 (필드 초기화), 인스턴스(객체) 초기화

 Constructor(생성자) 형식 - 메서드
: 클래스 이름과 동일한 이름으로 함수 이름을 사용
: 접근 제한자는 Public으로 사용한다 
: 반환값도 없고 void란 키워드도 없음
 
- C#에서는 생성자를 만들지 않으면 기본 생성자를 자동으로 만들어줌
기본 생성자 예시)

public Dog()
{
}

- 모든 필드는 기본값으로 초기화 된다. : 값형 - 0, 참조형 - null

-----------------

생성자 예시)

class Dog
{
    // 생성자
    public void Dog()
    {
       
    }
}

 */

