using UnityEngine;


// 기본 클래스
public class ClassMember
{
    // public 키워드, ClassMember가 아닌 다른 클래스에서 사용 가능하게 만듬

    // [1] 정적(static) 메서드
    public static void StaticMethod()
    {
        Debug.Log("[1] 정적 메서드");
    }

    // [2] 인스턴스(Instance) 메서드
    public void InstanceMethod()
    {
        Debug.Log("[2] 인스턴스 메서드");
    }
}
