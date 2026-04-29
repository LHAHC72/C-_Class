using UnityEngine;

//TypeConversion : 형식 변환

public class TypeConversionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long 형 변수 선언하고 long형 변수가 저장할 수 있는 가장 큰 수로 초기화 하기
        long l = long.MaxValue;

        Debug.Log($"long의 값 {l}");

        //[2] int 형식의 변수에 l변수에 있는 값을 저장하기 (초기화)
        int i = (int)l; // long 변수의 값을 int 변수 저장시 오류 발생
        Debug.Log($"i의 값: {i}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
