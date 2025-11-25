using UnityEngine;

public class StringPractice : MonoBehaviour
{
	string firstName = "Bon";
	string lastName = "Jovi";

	void Start()
	{
		Debug.Log("=== String Practice ===");

		// 문자열 합치기
		string fullName1 = firstName + " " + lastName;
		Debug.Log("Full Name (+) : " + fullName1);

		// 문자열 보간 (interpolation)
		// $"..." 내부의 { } 안에는 변수나 계산식, 메서드 호출 등 임의의 C# 표현식을 넣을 수 있다. 가독성이 좋아서 + 연산보다 자주 사용된다.
		string fullName2 = $"{firstName} {lastName}";
		Debug.Log($"Full Name (보간) : {fullName2}");

		// ToUpper / ToLower
		Debug.Log("Uppercase : " + fullName1.ToUpper());
		Debug.Log("Lowercase : " + fullName1.ToLower());

		// 길이
		Debug.Log("Name Length : " + fullName1.Length);

		// 부분 문자열
		Debug.Log("Substring(0, 2) : " + fullName1.Substring(0, 2));

		// Contains
		Debug.Log("Contains 'B' ? :" + fullName1.Contains("B"));
	}
}
