using Unity.VisualScripting;
using UnityEngine;

public enum BirdType
{ 
	None = -1,

	Duck,
	Eagle,
	Penguin,

	Max
}

// 팩토리 패턴 : 객체를 생성하는 전담 클래스를 만듭니다.
// 각 객체의 생성 로직을 캡슐화하여 클라이언트 코드가 구체적인 클래스에 의존하지 않도록 합니다.
// 생성 로직을 변경하고 싶을때는 팩토리 클래스만 수정하면 됩니다.
public class FactoryPattern : MonoBehaviour
{
	// 타 클래스에서 접근할 수 있도록 싱글톤 인스턴스를 제공합니다.
	public static FactoryPattern Instance { get; private set; }

	private void Awake()
	{
		if (Instance == null)
			Instance = this;
		else
			Destroy(gameObject);
	}

	// 새의 타입, 위치, 회전을 받아 해당 새를 생성하는 메서드입니다.
	public ExampleBirdBase CreateBird(BirdType type, Vector3 pos, Quaternion rot, Transform parent = null)
	{
		// 타입의 이름으로 새로운 게임 오브젝트를 생성합니다.
		GameObject bird = GameObject.CreatePrimitive(PrimitiveType.Cube);
		bird.name = type.ToString();
		// 위치와 회전을 설정하고 부모를 지정합니다.
		bird.transform.SetPositionAndRotation(pos, rot);
		bird.transform.SetParent(parent);

		Material material = bird.GetComponent<Renderer>().material;

		// 지정된 타입에 따라 적절한 컴포넌트를 추가하고 반환합니다.
		switch (type)
		{
			case BirdType.Duck:
				material.color = Color.yellow;
				return bird.AddComponent<ExampleDuck>();
			case BirdType.Eagle:
				material.color = Color.gray;
				return bird.AddComponent<ExampleEagle>();
			case BirdType.Penguin:
				material.color = Color.white;
				return bird.AddComponent<ExamplePenguin>();
		}

		// 유효하지 않은 타입인 경우 null을 반환합니다.
		return null;
	}
}
