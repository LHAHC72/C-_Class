using UnityEngine;

// Array(배열) : 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇
// 선언: 데이터 타입[] 변수 이름

public class ArrayDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열 선언, 배열 만들기
        int[] numbers;

        // [2] 배열의 요소 수 생성, 배열 크기(길이) 정정 - 그릇(방)갯수 n개 지정
        // C#에서는 배열크기 결정 되면 각각 방이 모두 0으로 초기화
        numbers = new int[10]; // 0 ... n-1개 

        // [3] 배열 초기화 - 배열 변수에 값 저장
        numbers[0] = 3840;
        numbers[1] = 2160;

        // [4] 배열 사용
        Debug.Log($"{numbers[0]}*{numbers[1]} = {numbers[0] * numbers[1]}");

        // 값 저장 안한 배열은 자동적으로 0으로 설정.
        Debug.Log($"{numbers[0]}*{numbers[1]}*{numbers[2]} = {numbers[0] * numbers[1] * numbers[2]}");



    }

}
