using UnityEngine;



public class IfElseAll : MonoBehaviour
{
    // 정수 입력
    public int num = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 숫자 판별


        /*// 짝수 판별식 - 입력 받은 수가 짝수면 num은 짝수라고 출력
        if (num % 2 == 0)
        {
            // 실행문
            Debug.Log($"{num}은 짝수");
        }

        else
        {
            Debug.Log($"{num}은 홀수");
        }*/


        // 홀, 짝수 판별식 - 입력 받은 수가 홀수면 num은 홀수라고 출력 아니면 짝수라고 출력
        /*   if (num % 2 != 0)
           {
               Debug.Log($"{num}은 홀수");
           }
           else
           {
               Debug.Log($"{num}은 짝수");
           }*/

        // 입력 받은 수를 3의 배수, 5의 배수, 7의 배수인지 판별하라
        // num 은 3의 배수, num은 5의 배수, num은 7의 배수, numdms 3,5,7의 배수가 아닌 수 로 출력

        if (num % 3 == 0)
        {
            Debug.Log($"{num}은 3의 배수");
        }

        else if (num % 5 == 0)
        {
            Debug.Log($"{num}은 5의 배수");
        }

        else if (num % 7 == 0)
        {
            Debug.Log($"{num}은 7의 배수");
        }

        else
        {
            Debug.Log($"{num}은 3,5,7의 배수가 아닌 수");
        }

    }


}
