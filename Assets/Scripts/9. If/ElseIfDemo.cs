using UnityEngine;

// 학점을 출력하는 프로그램
// 점수가 90 이상이면 A 출력, 80 이상이면 B 출력, 70 이상이면 C 출력, 
// 60 이상이면 D 출력, 나머지는 F 출력
// 학점: A

public class ElseIfDemo : MonoBehaviour
{
    // 스코어 입력
    public int score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 학점을 저장하는 변수 선언, 초기화
        char grade;


        if (score >= 90)
        {
            Debug.Log('A');
            grade = 'A';
        }

        else if (score >= 80)
        {
            Debug.Log('B');
            grade = 'B';
        }

        else if (score >= 70)
        {
            Debug.Log('C');
            grade = 'C';
        }

        else if (score >= 60)
        {
            Debug.Log('D');
            grade = 'D';
        }

        else
            Debug.Log('F');
            grade = 'F';

        Debug.Log(grade);

    }

    

}

/*
 elseif문 : if문과 같이 사용


if(조건식1)
{
    실행문1
}
else if(조건식2)
{
    실행문2
}
else
{
    실행문3
}

실행문 4

 
[1] 만약 조건식 1이 참이면
실행문 1 -> 실행문 4 실행

[2] 조건식 1이 거짓이고 조건식 2가 참일경우
실행문 2 -> 실행문 4 실행

[3] 조건식1, 조건식 2 둘 다 거짓일 경우
실행문 3 -> 실행문 4 실행

[4] 조건식 1, 조건식 2 둘 다 참일 경우
실행문 1 -> 실행문 4 실행
 
 */