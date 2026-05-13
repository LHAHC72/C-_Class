using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class LinqNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 불형 배열 변수 선언하고 초기화
        bool[] isOuts = {true, false, true, false, true};

        // 배열의 개수 구하기, 배열의 값 중에 true의 개수는?, 또는 false의 개수는?
        Debug.Log(isOuts.Count());

        // true의 개수
        Debug.Log(isOuts.Count(b => b == true)); // 람다식

        // false의 개수
        Debug.Log(isOuts.Count(b => b == false)); // 람다식

        // 정렬
        string[] colors = { "Red", "Green", "Blue" };

        // 오름차순 정렬
        IEnumerable<string> sortedColors = colors.OrderBy(s => s);
        foreach (string color in sortedColors)
        {
            Debug.Log(color);
        }

        // 
        List<string> allColors = new List<string> { "Red", "Green", "Blue" };   // 바로 값 주는 것도 가능
        var sColors = allColors.OrderByDescending(s => s);
        foreach(string color in sColors)
        {
            Debug.Log(color);
        }

    }

   
}
