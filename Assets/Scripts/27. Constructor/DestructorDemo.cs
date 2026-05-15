using UnityEngine;


namespace Constructor
{
    public class Destructor : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // 소멸자 테스트
            DestructorTest destructorTest = new DestructorTest();

            // 인스턴스 사용
            destructorTest.Run();

            // 소멸자 호출 - 가비지 컬렉터(GC)가 하는 일
            // ~DestructorTest();   호출 불가, 사용자가 하는게 아님

            // Car 클래스의 인스턴스(객체)생성
            // 하얀차, 파란차, 빨간차 만들기
            Car whiteCar = new Car();
            whiteCar.Run();

            Car blueCar = new Car("파랑");
            blueCar.Run();

            Car redCar = new Car("빨강");
            redCar.Run();

            // 폐차: GC가 알아서




        }


    }
}

/*
 
Destructor(소멸자) : 클래스가 사용된 후 가장 마지막에 호출되는 메서드 
: 생성된 인스턴스(객체)가 메모리 상에서 없어질 때 호출
: 클래스에서 사용된 메모리 해제... 등
: 


class Dog(클래스 이름)
{
    // 생성자
    public Dog()
    {
    }

    // 소멸자
    ~Dog()
    {
        개체가 소멸할 때 필요한 기능 수행
    }

}
 
 */ 