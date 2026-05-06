using UnityEngine;

// 1부터 10까지의 정수의 합을 구하는 프로그램 구현
// 단 합 구하다가 합이 22 이상이 되면 더 이상 합을 구하지 말고 합을 출력

public class BreakPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int sum = 0;

        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            if(sum >= 22)
            {
                Debug.Log(sum);
                break;
            }
        }

        sum = 0;
        int j = 1;
        while (j <= 10)
        {

            if(sum >= 22)
            {
                Debug.Log(sum);
                break;

            }
            // 반복 실행문
            sum += j;

            // 증감식
            j++;
        }

        

    }

    
}
