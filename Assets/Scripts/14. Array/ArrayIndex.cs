using UnityEngine;

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 크기가 3인 정수형 배열 선언하고 1,2,3 으로 초기화

        

        int[] numbers = new int[3] { 1, 2, 3 };

        // int[] numbers = { 1, 2, 3 };  이것도 됨

        
     
        // 배열의 인덱스를 관리하는 변수 선언: 배열의 크기가 3이므로 0~2를 벗어나선 안됨. 0으로 초기화
        
        int index = 0;

        Debug.Log(numbers[index++]); // 1
        Debug.Log(numbers[index++]); // 2                                                                                                                          
        Debug.Log(numbers[index++]); // 3

        Debug.Log(numbers[--index]); // 3
        Debug.Log(numbers[--index]); // 2
        Debug.Log(numbers[--index]); // 1

    }

 
}
