using UnityEngine;


//Random클래스 : 랜덤 값 구하는 함수들
public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 랜덤 클래스의 인스턴스
        // 클래스이름 객체이름 = new 클래스이름();
        // Random random = new Random(); <= 이게 안되는 이유, Unity 내부에도, C#내부에도 Random 클래스를 만들었기에 뭘 쓸지 모름
        System.Random random = new System.Random(); // C#(닷넷)에서 제공하는 내장 클래스 Random 사용

        // 랜덤값
        Debug.Log(random.Next());  // 임의에 정수를 반환하는 함수
        Debug.Log(random.Next(5));  // 0 ~ 4 사이의 정수값 중 랜덤 값 반환
        Debug.Log(random.Next(1,10));  // 1 ~ 9 사이의 정수값 중 랜덤 값 반환

    }

}
