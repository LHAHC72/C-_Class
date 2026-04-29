using UnityEngine;


// bool : 불형, 논리 자료형, 참(true) 또는 거짓(false)값을 저장
public class BooleanDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] bool 변수 선언하고 초기화
        bool bIn = true; // 참       
        Debug.Log("bIn: " +  bIn);

        bool isOut = false; // 거짓
        Debug.Log("isOut: " +  isOut);

        // bool형 변수 앞에는 b 나 is 를 붙이는게 보통 규칙
    }

}
