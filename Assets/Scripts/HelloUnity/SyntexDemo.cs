 using UnityEngine;

// 문법(Syntex) : 문법은 반드시 지켜야 함
// 코딩 컨벤션(코딩 스타일) : 프로그래밍 작성 가이드, 약속

public class SyntexDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //들여쓰기
        Debug.Log("들여쓰기는 공백 4칸 혹은 탭을 사용");

        //공백(White Space) : C#에서는 공백 무시
        Debug.Log("C#");
        Debug.Log( "C#" );
        Debug.
            Log(
            "C#"
            );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// 주석문(comment) : 주석문은 컴파일, 실행에 영향을 주지 않는 코드

/* 
다중 주석문(Mult comment)
*/