using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;

        Debug.Log($"처음 i:{i}, j:{j}");

        int temp; // 빈그릇

        temp = i; // 임시 변수에 i 값 저장
        i = j; // i에 j값 대입
        j = temp; // j에 임시 변수 값 저장

        Debug.Log($"변경 i:{i}, j:{j}");

    }

   
}

/*
 
 [Q]
+, - 다른 연산 없이 변수 i,j 의 값을 서로 바꾸어서 저장하세요

[output]
처음 i:100, j:200
변경 i:200, j:100
 
 */