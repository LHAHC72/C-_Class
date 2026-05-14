using UnityEngine;

namespace PrivatePublic
{
    public class FieldDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Say 클래스의 인스턴스 생성
            Say say = new Say();  // 같은 네임스페이스 안에 있기 때문에 가능.
            say.Hi(); 
            say.PrintNumber();

            // 접근 제한자 에러
            // Debug.Log(say.message); 불가능. 메시지는 string 보호필드는 기본 private이기 때문

            say.categoriName = "책"; // public으로 선언하자 가능.
            Debug.Log(say.categoriName);

            // Person 클래스의 인스턴스 생성
            Person person = new Person();
            person.ShowProfile();



        }
    }

}

