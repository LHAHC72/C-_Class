using UnityEngine;

// 이중 for문: for문 안에 for문
// 삼중 for문: for문 안에 for문 안에 for문

    
public class ForStar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // *로 삼각형 만들기
        for(int i = 1; i <= 5 ; i++)
        {
            for(int j = 1; j<= i ; j++)  // i만큼 반복해라
            {
                Debug.Log("*");
            }

            

        }
    }

    
}
