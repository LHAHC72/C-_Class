using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] float형 변수 선언하고 초기화
        float f = 3.14f; // float에서 값 뒤에 f 입력, 또한 대문자로 사용해도 인식
        Debug.Log(f);

        //[2] double형 변수 선언하고 초기화
        double d = 3.141592; // 여기서 double형은 뒤에 d를 생략 가능
        Debug.Log(d);

        //[3] decimal형 변수 선언하고 초기화
        decimal m = 3.14m;
        Debug.Log(m);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*

실수형 데이터
float : 32bit 실수형 데이터 형식
double : 64bit 실수형 데이터 형식
decimal : 128bit 실수형 데이터 형식

*/