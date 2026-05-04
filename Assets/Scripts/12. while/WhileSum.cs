using UnityEngine;

public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // While문을 이용해서 1부터 100까지의 합을 구하는 프로그램을 구현

        // 초기식
        int i = 1;
        int sum = 0;

        while (i <= 100)
        {
            // 반복 실행문
            /*sum += i;*/

            // 짝수의 합만 구한다
            if (i % 2 == 0)
            {
                sum += i;
            }

            // 증감식
            i++;
        }

        Debug.Log(sum);

    }

}
