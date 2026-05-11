using UnityEngine;

public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 로또번호 생성기



        int[] numbers = new int[6];

        System.Random random = new System.Random();         // [1] 임의의 숫자 6개 번호 생성 : ( 1 ~ 45 ) 사이의 랜덤값

        for (int i = 0; i < numbers.Length; i++)                
        {           
            numbers[i] = random.Next(1,46);                     // [2] 임의의 숫자 6개를 번호 저장
            int error = 0;

            while (true)    // 무한 반복문
            {
                for(int j = 0; i < j; j++) // 현재 랜덤 값이 이전 랜덤 값과 중복되는지 확인
                {
                    error = 0;  // 에러를 확인하기 위한 변수 선언
                    if(numbers[i] == numbers[j])    // 만약 중복값이 발견되면
                    {
                        numbers[i] = random.Next(1, 46);    // 새로 랜덤 값 부여하고
                        error++;    // 에러 변수에 표시 후
                        break;  // 다시 무한 반복문으로
                    } 
                }
                if(error == 0)  // 만약 에러 변수가 안나오면
                {
                    break;      // 무한 반복문 정지 
                }


            }

            Debug.Log(numbers[i]);                              // [4] 임의의 숫자 6개를 번호 출력
        }

       
        

    }

   
}

/*
 
로또 번호 생성기
1. 6개 번호
2. 1~45 사이의 번호
3. 6개 번호가 중복되선 안됨

3가지 조건이 맞는 6개의 번호를 출력하는 프로그램 구현
[1] 임의의 숫자 6개 번호 생성 : ( 1 ~ 45 ) 사이의 랜덤값
[2] 임의의 숫자 6개를 번호 저장
[3] 중복 제거 기능 추가 
[4] 임의의 숫자 6개를 번호 출력


 
*/