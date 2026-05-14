using UnityEngine;

namespace PrivatePublic
{
    public class Say
    {
        // [1] 필드(맴버) 선언하고 초기화
        string message = "안녕하세요";   // string 변수 필드 - private
        int[] numbers = {1,2,3,4,5};    // 정수형 배열 필드 public
        public string categoriName;

        // [2] message를 출력하는 맴버 함수 선언
        public void Hi()

        {
            this.message = "반갑습니다";
            Debug.Log(message);
        }

        // [3] numbers를 출력하는 맴버 함수 선언
        public void PrintNumber()
        {
            foreach(int i in numbers)
            {
                Debug.Log(i);
            }
        }



    }

}


