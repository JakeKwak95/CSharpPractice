using System.Collections.Generic;
using UnityEngine;

public class ExtentionsExample : MonoBehaviour
{
	[ContextMenu("Ivoke Start Method")]
	void Start()
	{
		Vector3 exampleVector3 = new(3f, 4f, 0f); // 타입 생략 가능
		Debug.Log($"Vector3의 가장 큰 값은 : {exampleVector3.GetLargest()}");

		List<string> names = new() { "Alice", "Bob", "Charlie", "Diana" }; // 타입 생략 가능
		Debug.Log($"랜덤으로 선택된 이름은 : {names.GetRandomMember()}");

		// var : 컴파일러가 변수의 타입을 추론하도록 하는 키워드
		// new GameObject() : GameObject 타입의 인스턴스를 생성
		// duck의 타입은 AddComponent<ExampleDuck>() 메서드에 의해 ExampleDuck으로 추론
		var duck = new GameObject("Duck").AddComponent<ExampleDuck>();
		// ExampleDuck은 ExampleBirdBase를 상속받으므로 CanFly 확장 메서드 사용 가능
		Debug.Log($"오리에게 날 수 있냐고 물어보니? : {duck.CanFly()}");
	}
}

// 확장 메서드 : 기존 클래스에 새로운 메서드를 추가하는 기능
// 보통 static 클래스와 static 메서드로 작성
// static : 정적 키워드로 인스턴스를 생성하지 않고도 접근 가능한 멤버, 모든 클래스에서 공유
public static class ExtensionMethods
{
	// Vector3의 axis 값 중 가장 큰 값을 반환하는 확장 메서드
	public static float GetLargest(this Vector3 v)
	{
		float largest = v.x;
		// {}(대활호)의 내용이 한줄일 경우 {} 생략 가능
		if (v.y > largest) largest = v.y;
		if (v.z > largest) largest = v.z;
		return largest;
	}

	// 제네릭과 익스텐션 메서드의 결합 1
	// List<T>의 임의의 멤버를 반환하는 확장 메서드
	public static T GetRandomMember<T>(this List<T> list)
	{
		if (list == null || list.Count == 0)
		{
			Debug.LogWarning("리스트가 비어있거나 null입니다.");
			return default;
		}
		int randomIndex = Random.Range(0, list.Count);
		return list[randomIndex];
	}


	// 제네릭과 익스텐션 메서드의 결합 2
	// ExampleBirdBase를 상속받는 모든 타입에 대해 CanFly 확장 메서드 정의
	public static bool CanFly<T>(this T a) where T : ExampleBirdBase
	{
		return a.GetComponent<IFlyable>() != null;
	}
}