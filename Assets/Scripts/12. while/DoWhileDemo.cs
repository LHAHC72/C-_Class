using UnityEngine;

public class DoWhileDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 안녕하세요를 3번 출력하는 프로그램 구현

        // for문
        /*for(int i = 0; i < 3; i++)
            {
                Debug.Log("안녕하세요");
            }


        //while문

        // 초기식
        int i = 0;

        while(i < 3)
        {
            // 반복 실행문
            Debug.Log("안녕하세요");

            // 증감식
            i++;
        }

        */

        // [1] 초기식
        int i = 0;

        do
        {
            Debug.Log("안녕하세요");
            i++; // [2] 증감식
        } while (i<3); //[3] 조건식

        




}


}

/*
 == do while

do
{
// 반복 실행문
} while(조건식)



반복 실행문을 실행한다.
조건식이 참이면 반복문을 실행하고
조건식이 거짓이면 while문을 종료한다

 
 
 */