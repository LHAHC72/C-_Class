using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        void Start()
        {
            /*

            Person person = new Person();

            // 메서드 이용
            person.SetName("홍길동");
            Debug.Log($"이름은 {person.GetName()}");

            // Property 이용 - 사용시 변수와 동일한 방법으로 사용한다.
            person.Name = "백두산";
            Debug.Log($"이름은 {person.Name}");    // name, Name 대소문자 구분 이유는 변수랑 구분하기 위함.

            // Truck 클래스의 인스턴스 생성
            Truck truck1 = new Truck();
            truck1.Name = "덤프트럭";
            Debug.Log(truck1.Name);

            Truck truck2 = new Truck();
            truck2.Name = "카고트럭";
            truck2.Color = "Red";
            truck2.Number = 9876;
            Debug.Log(truck2.Name + truck2.Color + truck2.Number);

            // User 클래스의 인스턴스 생성
            User user1 = new User("홍길동");
            user1.BirthYear = 2000;
            Debug.Log($"이름:{user1.Name}, 나이:{user1.Age}");

            // user1.Message = "안녕하세요";     불가능. 접근 제한자 에러, 읽기 전용
            Debug.Log(user1.Message);

            */

            // 속성 초기화
            // Student 클래스와 인스턴스 생성
            Student s1 = new Student();
            s1.Name = "홍길동";
            s1.Age = 20;
            Debug.Log($"이름: {s1.Name}, 나이: {s1.Age}, 번호: {s1.Number}");

            // 개체 이니셜 라이져 사용, 개체 초기화
            Student s2 = new Student() { Name = "백두산", Age = 25, Number = 2 };

            // 주소는 함수를 이용하여 사용해야함
            s2.SetAddress("서울시");

            Debug.Log($"이름: {s2.Name}, 나이: {s2.Age}, 번호: {s2.Number}, 주소: {s2.GetAddress()}");


        }

        


    }
}

/*
 
 Property(속성) : 필드의 값을 읽거나 쓰거나 연산하는 방법을 제공하는 클래스 맴버
: 필드는 기본적으로 private(외부에서 접근을 제한하기 위해)
: 속성은 제한된 외부에서 읽거나 쓰기가 가능하도록 한다.(원래는 Get, Set함수 써야됨)

: 네이밍: 속성 이름은 첫 문자를 대문자로 쓰기.

Property 형식
public [반환타입] 속성이름 
{
    get {return 필드이름;}
    set;{필드 이름 = value;}   
}
 
 
 */