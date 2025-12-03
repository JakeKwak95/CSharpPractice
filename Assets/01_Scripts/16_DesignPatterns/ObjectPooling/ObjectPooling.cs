using System.Collections.Generic;
using UnityEngine;

// 오브젝트 풀링 : 미리 생성된 오브젝트를 재사용하여 성능을 최적화하는 디자인 패턴
// ObjectPooling 클래스는 오브젝트 풀을 관리하고, 오브젝트를 요청하거나 반환하는 기능을 제공
// 빈번하게 생성되고 파괴되는 오브젝트들을 객체 풀링을 통해 최적화
public class ObjectPooling : MonoBehaviour
{
	public static ObjectPooling Instance { get; private set; }

	// 오브젝트 풀링에 대한 설정 데이터를 담고 있는 ScriptableObject
	// 스크립터블 오브젝트를 통해 여러 데이터 프리셋을 쉽게 관리하고 재사용 가능
	[SerializeField] PoolingDataSO poolingData;
	// 오브젝트 풀에 있는 게임 오브젝트들을 저장하는 큐(선입선출 FIFO 구조)
	Queue<PoolingObject> objectPool = new Queue<PoolingObject>();

	private void Awake()
	{
		if (Instance == null)
			Instance = this;
		else
			Destroy(gameObject);
	}

	private void Start()
	{
		InitializePool();
	}

	// 오브젝트 풀 초기화 : 미리 지정된 수만큼 오브젝트를 생성하여 비활성화 상태로 큐에 추가
	public void InitializePool()
	{
		for (int i = 0; i < poolingData.InitialPoolSize; i++)
		{
			var poolObject = Instantiate(poolingData.PoolingObject, Vector3.zero, Quaternion.identity, transform);
			poolObject.gameObject.SetActive(false);
			objectPool.Enqueue(poolObject);
		}
	}

	// 오브젝트 풀에서 오브젝트 요청 : 큐에서 오브젝트를 꺼내 활성화 상태로 반환
	// 오브젝트 풀이 비어있을 경우, 초기화 메서드를 호출하여 오브젝트를 추가 생성
	public PoolingObject GetPooledObject(Vector3 pos = default, Quaternion rot = default)
	{
		if (objectPool.Count > 0)
		{
			PoolingObject pooledObject = objectPool.Dequeue();
			pooledObject.transform.SetPositionAndRotation(pos, rot);
			pooledObject.gameObject.SetActive(true);
			return pooledObject;
		}
		else
		{
			InitializePool();
			return GetPooledObject(pos, rot);
		}
	}

	// 오브젝트 풀에 오브젝트 반환 : 오브젝트를 비활성화 상태로 변경하고 큐에 다시 추가
	public void ReturnPooledObject(PoolingObject returnedObject)
	{
		returnedObject.gameObject.SetActive(false);
		objectPool.Enqueue(returnedObject);
	}
}
