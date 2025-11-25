using UnityEngine;

// 풀링에 사용할 오브젝트에 부착되는 클래스
public class PoolingObject : MonoBehaviour
{
	void Update()
	{
		// 화면 밖으로 나가면 오브젝트 풀에 반환
		if (transform.position.y < -5f)
		{
			ObjectPooling.Instance.ReturnObjectToPool(gameObject);
		}
	}
}
