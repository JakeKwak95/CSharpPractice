using UnityEngine;

// 제네릭 : 타입에 대한 일반화된 코드를 작성할 수 있도록 해주는 기능
// 타입에 의존하지 않고, 다양한 타입에 대해 재사용 가능한 코드를 작성할 수 있음
// 주로 클래스, 메서드, 인터페이스 등에 사용됨
public class GenericExample : MonoBehaviour
{
	// 빠른 테스트를 위해 ContextMenu 어트리뷰트 사용
	[ContextMenu("Invoke Start")]
    void Start()
    {
		// GetComponent<T>() 메서드는 제네릭 메서드의 예시
		// 제네릭으로 사용할 타입을 <> 안에 T로 명시(Type의 약자)
		Transform playerTransform = GetComponent<Transform>();

		// TryGetComponent<T>() 메서드도 제네릭 메서드의 예시 -> T 컴포넌트가 존재하는지 확인 후 반환
		// 매개변수로 out 키워드를 사용하여 컴포넌트를 반환
		// 매개변수에 타입이 명시되어 있으면 <> 안에 타입을 명시하지 않아도 됨
		if (TryGetComponent(out Rigidbody rb))
		{
			Debug.Log("Rigidbody 컴포넌트를 성공적으로 가져왔습니다.");
		}
		else
		{
			Debug.Log("Rigidbody 컴포넌트를 찾을 수 없습니다.");
		}

		GetRandomItemFromArray(new int[] { 1, 2, 3, 4, 5 });
		GetRandomItemFromArray(new string[] { "사과", "바나나", "체리", "포도" });

		// 제네릭 제약조건 사용 예시
		// ExampleBirdBase를 상속받지 않은 GenericExample 클래스는 사용 불가
		// ***MonoBehaviour를 상속받은 클래스는 new 키워드로 인스턴스화하지 않지만, 제약 조건을 보여주기 위해 예시로 작성***
		// ExampleBirdBase notBird = GetIfBird<ExampleBirdBase>(new GenericExample()); // 오류 발생
		// ExampleBirdBase bird = GetIfBird<ExampleBirdBase>(new ExampleDuck());
	}

	// 제네릭 메서드 예시
	// 배열에서 랜덤한 아이템을 출력하는 메서드(어떤 타입이든 가능)
	void GetRandomItemFromArray<T>(T[] array)
	{
		int randomIndex = Random.Range(0, array.Length);
		T randomItem = array[randomIndex];
		Debug.Log($"가챠! : {randomItem}");
	}

	// 제네릭 제약조건 예시
	// T가 ExampleBirdBase를 상속받은 타입이어야만 사용 가능
	// where 제네릭 T : 제약조건 
	T GetIfBird <T>(T item) where T : ExampleBirdBase
	{
		return item;
	}
}
