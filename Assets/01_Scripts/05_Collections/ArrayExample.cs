using UnityEngine;

public class ArrayExample : MonoBehaviour
{
	int[] intArray = new int[3]; // new 키워드로 길이가 3인 int형 배열 선언 및 생성
	string[] stringArray = { "Apple", "Banana", "Cherry" }; // 선언과 동시에 초기화

	private void Start()
	{
		// 배열 초기화 메소드 호출
		InitializeArray(intArray); // 배열은 참조 타입이므로 메소드 내에서 값 변경 가능 (추후 값 타입과 참조 타입에 대해 다룸)

		// 배열 요소 접근 및 출력
		GetArrayMember(intArray, 0);
		ChangeArrayMemberValue(0, 100);
		GetArrayMember(intArray, 0);

		// 배열의 길이 넘어가는 인덱스 접근 시도 시 예외(에러) 발생
		// index 는 0부터 시작하므로 길이가 3인 배열의 유효한 인덱스는 0, 1, 2
		GetArrayMember(intArray, 3);

		Debug.Log("메롱~"); // 메서드 내에서 예외가 발생하여 발생 지점 아래인 이 로그는 출력되지 않음
	}

	private void InitializeArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = i;
			Debug.Log($"배열 초기화[{i}]: {array[i]}");
		}
	}

	private void ChangeArrayMemberValue(int index, int newValue)
	{
		intArray[index] = newValue;
		Debug.Log($"배열 값 변경[{index}]: {intArray[index]}");
	}

	// 순서 : 예외 발생 후 방지 코드 주석 처리 풀기
	private void GetArrayMember(int index)
	{
		// 배열의 길이를 넘어가는 인덱스 접근 방지
		// if (intArray.Length <= index) return;

		Debug.Log($"배열 접근[{index}]: {intArray[index]}");
	}
}
