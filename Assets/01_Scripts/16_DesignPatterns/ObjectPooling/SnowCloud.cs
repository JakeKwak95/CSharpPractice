using UnityEngine;

// 오브젝트 풀링을 사용하여 눈송이를 생성하는 클래스
public class SnowCloud : MonoBehaviour
{
	[SerializeField] float spawnSize = 5f;
	[SerializeField] float interval = 0.1f;

	void Start()
	{
		// interval 간격으로 Snow 메서드를 반복 호출
		InvokeRepeating(nameof(Snow), 0f, interval);
	}

	private void Snow()
	{
		Vector3 randomPos = new(Random.Range(-spawnSize, spawnSize), spawnSize, Random.Range(-spawnSize, spawnSize));
		var snowflake = ObjectPooling.Instance.GetPooledObject(randomPos);
	}
}
