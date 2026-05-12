using UnityEngine;

public class ExceptionDemo : MonoBehaviour
{

    // 인스펙터창에서 입력
    public int x = 0;
    public int y = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int[] arr = new int[2];
        arr[100] = 5;
        arr[0] = 1;
        Debug.Log(arr[0]);*/

        /*try    
        {
            // 배열 선언하고 값 저장
            int[] arr = new int[2];
            arr[100] = 5;

            arr[0] = 1;
            Debug.Log(arr[0]);
        }
        catch  
        {        
            Debug.Log("에러가 발생했습니다.");
        }*/

        int result = 0;

        try // 예외가 발생할 가능성이 있는 구문이 들어오는 곳
        {
            result = x / y;
            Debug.Log($"{x}/{y} = {result}");
        }
        catch(System.Exception ex)   // try절에서 예외가 발생하면 catch 절을 실행
        {
            Debug.Log($"{ex.Message} 에러가 발생했습니다.");
        }
        finally // try절에서 예외가 발생하면 catch절을 실행
        {
            Debug.Log("프로그램을 계속 실행");
        }
        
        
    }

  
}

/*

에러, 오류
- 문법 오류
- 런타임 오류
- 알고리즘 오류
 
예외처리(Exception Headling) 
- try-catch-finally 구문을 사용하여 예외처리

1. 예외가 발생할 만한 명령문 부분을 try 구문으로 묶는다
try
{
    명령문...
}
catch{System.Exception e}
{
    2. try 구문 안에 명령문이 예외가 발생하면 처리할 내용을 작성
    처리할 내용...
    
}

 
 
 
 
*/