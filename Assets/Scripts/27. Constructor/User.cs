using UnityEngine;


namespace Constructor
{
    // 유저를 관리하는 클래스
    public class User
    {
        // [1] 필드
        private string name;    // private는 기본이라 생략은 가능하지만 수업에서는 명시적으로 쓰기
        private int age;

        // [2] (매개변수가 없는) 생성자 = 기본 생성자 
        public User()
        {
            name = "홍길동";
            age = 20;
        }

        // [3] 매개변수가 있는 생성자(메소드 오버로드)
        /*public User(string name)
        {
            this.name = name;
            age = 20;
        }*/

        public User(string name, int age = 20)
        {
            this.name = name;
            this.age = age;
        }

        // [4] 이름을 반환하는 함수
        public string GetName()
        {
            return name;
        }

        // [5] 유저 정보를 출력하는 함수
        public void ShowUserInfo()
        {
            Debug.Log($"이름:{name}, 나이:{age}");
        }

    }
}