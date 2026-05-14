using UnityEngine;
using Korea.Suwan;  // Korea.Suwan에 있는 클래스를 바로 가져다 사용
using Su = Korea.Suwan; // Korea.Suwan을 Su라는 별칭으로 지정

public class NameSpaceNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] using을 선언해서 클래스 가져오기 - 인스턴스 생성
        Car seoul = new Car();
        seoul.Run();    // 수원 자동차가 달린다.

        Korea.Seoul.Car se = new Korea.Seoul.Car();
        se.Run();   // 서울 자동차

        Korea.Suwan.Car sw = new Korea.Suwan.Car();
        sw.Run();   // 수원 자동차

        Su.Car suwan = new Su.Car();
        suwan.Run();    // 수원 자동차

        Korea.Seoul.Truck tr = new Korea.Seoul.Truck();
        tr.Run(); // 서울 트럭이 달린다.

    }

}
