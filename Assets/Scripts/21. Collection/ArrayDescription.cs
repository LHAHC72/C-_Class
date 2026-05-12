
using System.Collections;               // 컬렉션
using System.Collections.Generic;       // 컬렉션 제네릭

using UnityEngine;


// 컬렉션(Collect) : 배열처럼 관련 개체의 그룹을 만들고 관리하는 데이터 구조들을 컬렉션이라고 한다.
// : 배열, 리스트, 딕셔너리 ... (다만 배열은 엄밀히 따지면 컬렉션 내부에 있지는 않음. 그래서 배열 기능을 추가하는 컬렉션 제네릭을 추가하였음)

public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arr = {3,2,1,4,5};

        for (int i = 0; i<arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("==================");

        // 정렬(Sort) - 오름차순, 1,2,3,4,5,
        System.Array.Sort(arr);

        // 배열 출력하기
        foreach(int i in arr)
        {
            Debug.Log(i);
        }

        // 배열의 역순
        System.Array.Reverse(arr);

        // 배열 출력하기
        foreach (int i in arr)
        {
            Debug.Log(i);
        }

    }

   
}

/*
 
foreach 반복문 - 컬렉션을 가져와서 컬렉션 길이만큼 반복시킨다


- 컬렉션 변수의 길이만큼 반복하면서 첫번째 방에 있는 데이터부터 마지막 방에 있는 데이터까지 
- a변수에 입력하고 반복 실행문을 실행

foreach( (컬렉션의 데이터타입) a라는변수명 in 컬렉션 변수)
{
    반복 실행문...
}

*/