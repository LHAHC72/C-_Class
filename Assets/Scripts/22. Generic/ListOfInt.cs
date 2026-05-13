using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 배열 - 정수형 배열 변수 선언하고 요소수(크기) 생성

        int[] arrNumbers = new int[3];  // 배열은 선언할 때 방의 크기를 지정하지 않으면 에러

        // 배열 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        arrNumbers[2] = 30;

        // 배열 사용
        for(int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }


        // [2] 제네릭 리스트 사용 : int 전용 <int>
        // List<T> 의 인스턴스를 int 전용으로 생성하고 리스트에 값을 40, 50, 60 을 저장하라
        List<int> ListNumbers = new List<int>();
        ListNumbers.Add(40);
        ListNumbers.Add(50);
        ListNumbers.Add(60);

        foreach (int i in ListNumbers)
        {
            Debug.Log(i);
        }

        // [3] 제네릭 리스트 클래스 : List<T> : List<int>, List<string>, List<object>, ...
        // <string> 전용 리스트 인스턴스 생성
        List<string> colors = new List<string>();
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        // 리스트 사용
        foreach (var c in colors)
        {
            Debug.Log(c);
        }

        // 동일
        /*for (int i = 0; i < colors.Count; i++)
        {
            Debug.Log(colors[i]);
        }*/


    }

  
}
