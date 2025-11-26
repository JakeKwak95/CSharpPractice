using UnityEngine;

public class Operators : MonoBehaviour
{
	int a = 10;
	int b = 3;

	void Start()
	{
		Debug.Log("산술 연산자"); // 산술 연산자
		Debug.Log("a + b = " + (a + b));
		Debug.Log("a - b = " + (a - b));
		Debug.Log("a * b = " + (a * b));
		Debug.Log("a / b = " + (a / b));      // 정수 나눗셈
		Debug.Log("a % b = " + (a % b));      // 나머지

		Debug.Log("비교 연산자"); // 비교 연산자
		Debug.Log("a == b ? " + (a == b));
		Debug.Log("a != b ? " + (a != b));
		Debug.Log("a > b ? " + (a > b));
		Debug.Log("a < b ? " + (a < b));

		Debug.Log("논리 연산자"); // 논리 연산자
		bool value = (a > 5 && b < 5);
		Debug.Log("a > 5 AND b < 5 ? " + value);
		value = (a > 20 || b < 5);
		Debug.Log("a > 20 OR b < 5 ? " + value);
		value = !(a > 5);
		Debug.Log("NOT(a > 5) ? " + value);

		Debug.Log("증감 연산자"); // 증감 연산자
		int c = 1;
		Debug.Log("c = " + c);
		Debug.Log("c++ = " + c++);   // 후위 증가: 출력 후 증가
		Debug.Log("c = " + c);
		Debug.Log("++c = " + ++c);   // 전위 증가: 증가 후 출력
		Debug.Log("c = " + c);

		c = 1;
		Debug.Log("c = " + c);
		Debug.Log("c-- = " + c--);   // 후위 감소: 출력 후 감소
		Debug.Log("c = " + c);
		Debug.Log("--c = " + --c);   // 전위 감소: 감소 후 출력
		Debug.Log("c = " + c);
	}
}
