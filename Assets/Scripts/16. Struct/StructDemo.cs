using UnityEngine;

// [1] 구조체 정의, 선언
// 명함 데이터를 관리하는 구조체
public struct BusinessCard
{
    public string name;    // 이름을 저장하는 변수
    public int age;        // 나이를 저장하는 변수
    public string address; // 주소를 저장하는 변수

    // 함수도 가능하지만 이번 수업에서는 pass

    // 여기서 사용하는 public 키워드?
    // 코드블록 밖에서 사용이 가능하도록 한다. 정도로 당장은 알아두기
}

public class StructDemo : MonoBehaviour
{
 
    void Start()
    {
        /*
        // [2] 구조체 형식의 변수 선언
        BusinessCard myCard;

        //[3] 구조체에 속해있는 변수들의 초기화
        myCard.name = "홍길동";
        myCard.age = 22;
        myCard.address = "서울시 천호동";

        //[4] 구조체 사용
        Debug.Log($"이름:{myCard.name}, 나이:{myCard.age}, 주소:{myCard.address}");
        */

        //[5]구조체 형식의 배열 변수 선언, 요소 수 생성
        BusinessCard[] cards = new BusinessCard[2];

        //[6] 구조체에 속해있는 변수들의 초기화
        cards[0].name = "백두산";
        cards[0].age = 25;
        cards[0].address = "인천시";

        cards[1].name = "임꺽정";
        cards[1].age = 35;
        cards[1].address = "수원시";

        // [7] 사용
        for(int i = 0; i<cards.Length; i++)
        {
            PrintUserInfo(cards[i].name, cards[i].age);
        }


    }

    // 매개변수로 이름과 나이를 입력받아 출력하는 함수
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"이름:{name}, 나이:{age}");
    }

    // 매개변수로 구조체(BusinessCard)를 입력받아 이름과 나이를 출력하는 함수
    void PrintUserInfo(BusinessCard bizCard)
    {
        Debug.Log($"이름:{bizCard.name}, 나이:{bizCard.age}, 주소:{bizCard.address}");
    }

}

// Variable(변수) : 프로그램에서 사용할 데이터를 저장해 놓는 그릇, 하나
// Array(배열) : 하나의 이름으로 같은 데이터 형식을 여러개 보관해 놓는 그릇, 복수(같은 데이터 형식)
// 데이터 형식 : int, long, bool, float, double, string, char ... 
// 변수 선언시 : (데이터 형식) 변수이름;

// Struct(구조체) : 하나의 이름으로 서로 다른 데이터 형식의 데이터와 함수들을 묶어 관리하는데에 데이터 구조
// 구조체 = 사용자 정의 데이터 형식 : 개발자가 만든 데이터 형식
// 따라서 구조체 사용 할 때도 변수를 선언해서 사용
// 변수 선언 : (개발자가 만든 구조체) 변수이름;

/*
 구조체 형식

struct (구조체 이름)
{
    서로 다른 형식의 데이터들...
    함수들...
}
 
 */