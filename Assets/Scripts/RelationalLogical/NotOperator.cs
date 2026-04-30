using UnityEngine;

// NotOperator(부정연산자, !) : 참이면 거짓, 거짓이면 참

public class NotOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(!true); // 거짓
        Debug.Log(!false); // 참

        bool isOut = false;

        Debug.Log(!isOut); // 참
        Debug.Log(!!isOut); // 거짓
        Debug.Log(!(!(!isOut))); // 참
    }

}
