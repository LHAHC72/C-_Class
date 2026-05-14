using UnityEngine;

namespace PrivatePublic
{
    // 유저를 관리하는 클래스
    public class User
    {
        // 필드(전역변수, 맴버변수) 선언, public or private
        public string name;     // 이름, public
        private int age;        // 나이, private
        string address;         // 주소, private

        // 함수 메서드, public, private
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }
        private void Bye()
        {
            Debug.Log("안녕히계세요");
        }

        // private 한 age 를 외부에서 공개하고자 할 때 public 한 메서드를 이용한다.
        // 매개 변수로 나이를 입력받아 
        public void SetAge(int value)
        {
            age = value;
        }
        public int GetAge()
        {
            return age;
        }

    }
}

