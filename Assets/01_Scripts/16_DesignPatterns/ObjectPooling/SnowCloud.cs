using UnityEngine;

// 오브젝트 풀링을 사용하여 눈송이를 생성하는 클래스
public class SnowCloud : MonoBehaviour
{
	[SerializeField] float interval = 0.5f;

	void Start()
	{
		// interval 간격으로 Snow 메서드를 반복 호출
		InvokeRepeating(nameof(Snow), 0f, interval);
	}

	private void Snow()
	{
		var snowflake = ObjectPooling.Instance.GetObjectFromPool();
		Vector2 randomPos = new Vector2(Random.Range(-5f, 5f), 5f);
		snowflake.transform.position = randomPos;
	}
}
