using UnityEngine;

public class WhileCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 1부터 5까지 값을 출력

        // 초기식
        int i = 1;

        // 조건식
        while(i <= 5)
        {
            Debug.Log(i);
            i++; // 증감식
        }


       

        // 5에서 1까지 값을 출력
        
        // 초기식    
        i = 5;

        // 조건식
        while (i >= 1)
        {
            Debug.Log(i);
            i--; // 증감식
        }
    }

   
}
