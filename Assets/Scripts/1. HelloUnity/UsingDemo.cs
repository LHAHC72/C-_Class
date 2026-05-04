// using UnityEngine 을 사용하지 않을경우
// using UnityEngine;

public class UsingDemo : UnityEngine.MonoBehaviour // using UnityEngine을 직접 붙여도 됨.
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Debug.Log("Hello, Unity"); // using을 안해서 Debug를 못사용, UnityEngine을 직접 붙여줌.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
