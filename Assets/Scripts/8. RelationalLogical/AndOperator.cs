using UnityEngine;

// AndOperator(And 연산자, &&) : 둘 다 참일 때 참
// 결과 : true, false
// 두개의 불형을 연산할 때 둘 다 참이면 참이고 나머지는 거짓

public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 둘 다 참일 때만 참
        Debug.Log(true && true);  // true 

        // [2] 둘 중에 하나라도 거짓이면 거짓
        Debug.Log(true && false); // false
        Debug.Log(false && true); // false

        // [3] 둘 다 거짓이면 거짓
        Debug.Log(false && false); // false

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
