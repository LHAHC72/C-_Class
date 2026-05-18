using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Indexer
{

    public class Car
    {
        // 필드
        private string[] names;

        // 속성 - names의 길이를 반환하는 읽기 전용 속성
        public int Length { get { return names.Length; } }

        // 생성자 - 매개변수로 길이를 입력받아 요소수 생성
        public Car(int length)
        {
            names = new string[length];
        }

        // 인덱서
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        // 반복기 - 인덱서를 foreach문에서 사용하기 위해 정의한다.
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}