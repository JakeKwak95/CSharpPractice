using UnityEngine;

// 1. 메서드 오버로딩(Method Overloading)
// 2. 마우스 올려서 툴팁 확인하기
// 3. 서머리 주석(Summary Comments)

public class Overloading : MonoBehaviour
{
	private void Start()
	{
		Debug.Log("=== Method Overloading Example ===");
		// 동일한 메소드 이름이지만 매개변수의 타입과 개수가 다름
		// 컴파일러는 호출 시점에 전달된 인자(전달하는 매개변수)에 따라 적절한 메소드를 선택

		// 메서드 위에 마우스를 올리면 어떤 메서드가 호출되는지 확인할 수 있음
		// 오버로드의 수도 표시됨
		Debug.Log("Add(int, int): " + Add(5, 10));
		Debug.Log("Add(float, float): " + Add(3.5f, 2.5f));
		Debug.Log("Add(string, string): " + Add("Hello", "World"));
	}

	// 서머리 추가 시 툴팁에 설명이 표시됨

	/// <summary>
	/// 정수끼리 더합니다.
	/// <paramref name="a"/> 와 <paramref name="b"/> 를 더한 값을 반환합니다.
	/// </summary>
	int Add(int a, int b)
	{
		return a + b;
	}

	/// <summary>
	/// 실수끼리 더합니다.
	/// </summary>
	float Add(float a, float b)
	{
		return a + b;
	}

	/// <summary>
	/// 문자열을 연결합니다.
	/// </summary>
	string Add(string a, string b)
	{
		return a + " " + b;
	}
}
