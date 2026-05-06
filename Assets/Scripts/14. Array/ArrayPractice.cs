using UnityEngine;

// [Q] 크기 3에 정수형 배열 하나 생성, 각 배열에 1, 2, 3 저장 후 출력

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 배열 생성
        int[] numbers;

        // 크기 지정
        numbers = new int[3];

        // 배열 초기화, 값 출력 
        for(int i = 0; i < 3; i++)
        {
            numbers[i] = i + 1;
            Debug.Log(numbers[i]);
        }

  
        
    }

}
