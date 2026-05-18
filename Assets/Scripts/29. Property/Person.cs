using UnityEngine;

namespace Property
{
    // 사람을 관리하는 클래스 
    public class Person
    {
        // 필드
        private string name;    // 이름

        // 속성
        // public한 property를 이용하여 private한 name을 읽고 쓰기
        public string Name
        {
            get { return name; }
            set { name = value; }    // value 값을 필드에 저장
        }

        // 메서드
        // public한 메서드를 이용하여 private한 name을 읽고 쓰기

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }


    }
}