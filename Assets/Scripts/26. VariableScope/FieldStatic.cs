using UnityEngine;

namespace PrivatePublic
{
    public class FieldStatic : MonoBehaviour
    {
        
        void Start()
        {
            // [1] 스태틱 필드, 메서드 접근해서 사용
            // 스태틱 접근: 클래스이름. 스태틱맴버이름
            Truck.name = "덤프트럭";
            string tName = Truck.GetName();
            Debug.Log(tName);

            // Truck.age = 21; 에러
            // [2] private 한 인스턴스 필드 접근
            // public 한 메서드를 이용하여 접근한다.
            Truck truck = new Truck();
            truck.SetAge(21);
            Debug.Log(truck.GetAge());
        }


    }

}

