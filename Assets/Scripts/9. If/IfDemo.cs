using UnityEngine;

// 조건문: 조건에 맞는 명령문을 
// if, switch

public class IfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 만약 점수가 60점 이상이면 합격을 출력

        int score = 60;

        /* if(score >= 60)
         {
             Debug.Log("합격");
         }*/

        // 실행문이 하나이면 {} 생략 가능
        if (score >= 60)
            Debug.Log("합격");

        // 중첩 if 문
        string name = "홍길동";
        int age = 20;

        // 만약 이름이 홍길동과 같으면 실행문 실행
        if(name == "홍길동")
        {
            if(age == 20) 
            {
                // 실행문
                Debug.Log($"이름은 {name}, 나이는 {age}");
            }
            
        }


             
    }

}

/*
 
 if문
조건식이 참일 때 실행문을 실행
조건식이 거짓이면 실행문을 실행하지 않는다

if문 : 
조건식이 참일 때 실행문을 실행한다.
조건식이 거짓이면 실행하지 않는다.

if(조건식)
{
    실행문1
    실행문2
    실행문3

}

else문 : if문과 같이 사용
만약 조건식이 참이면 실행문1만 실행하고 else의 실행문2는 실행하지 않습니다.
만약 조건식 거짓이면 실행문1은 실행하지 않고 else의 실행문 2를 실행한다.

if(조건문)
{
    실행문1
}
else
{
    실행문2
}



 
 
 */