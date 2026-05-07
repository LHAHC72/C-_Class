using UnityEngine;

// 가변형 배열 : 두번 째 요소의 길이가 가변적이다.

public class ArrayTwo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 가변형 배열 선언하고 첫번째 요소 수 생성

        // 정수형 배열을 관리하는 배열이고 정수형 배열이 2개의 방을 가지고 있음.
        int[][] intArray = new int[2][];

        // [2] 두번째 요소수를 각각 따로 생성
        intArray[0] = new int[3] {1,2,3};
        intArray[1] = new int[2] {4,5};

        // [3] 사용하기
        for(int i = 0; i<intArray.Length; i++)
        {
            for(int j = 0; j<intArray.Length; j++)
            {
                Debug.Log(intArray[i][j]);
            }
            Debug.Log("===");
        } 

    }

    
}
