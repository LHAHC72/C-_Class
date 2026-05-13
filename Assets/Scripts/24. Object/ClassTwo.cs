using UnityEngine;

public class ClassTwo
{
    // 정적(static) 메소드
    public static void Hi()
    {
        Debug.Log("반갑습니다.");
    }

    // [2] 인스턴스 맴버 메소드 : Static 키워드가 없는 함수
    public void Hello()
    {
        Debug.Log("또 만나요");
    }
}
