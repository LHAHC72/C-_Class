using UnityEngine;

// OrOperator(Or 연산자, ||) : 하나라도 참이면 참
// 결과 : true, false
// 두개의 불형을 연산할 때 둘 중 하나만 참이면 참이고 나머지는 거짓

public class OrOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 둘 다 참일 때는 참
        Debug.Log(true|| true);  // true 

        // [2] 둘 중에 하나라도 참이라면 참
        Debug.Log(true || false); // true
        Debug.Log(false || true); // true

        // [3] 둘 다 거짓이면 거짓
        Debug.Log(false || false); // false
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
