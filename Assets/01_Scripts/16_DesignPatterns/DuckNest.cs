using UnityEngine;

public class DuckNest : MonoBehaviour
{
	// 위치, 회전을 설정합니다.
	// 다른 값들의 새를 생성 할 스포너를 만들 수 있습니다.
	[SerializeField] Vector3 position;
	[SerializeField] Quaternion rotation;

	// 생성 로직은 FactoryPattern 클래스에 위임합니다.
	[ContextMenu("Spawn Duck")]
	void SpawnDuck()
	{
		// 오리를 생성하고 자식으로 설정합니다.
		FactoryPattern.Instance.CreateBird(BirdType.Duck, position, rotation, transform);
	}

	[ContextMenu("Spawn Eagle")]
	void SpawnEagle()
	{
		// 독수리를 생성하고 자식으로 설정하지 않습니다.
		FactoryPattern.Instance.CreateBird(BirdType.Eagle, position, rotation);
	}
}
