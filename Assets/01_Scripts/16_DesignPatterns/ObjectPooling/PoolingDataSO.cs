using UnityEngine;

// 오브젝트 풀링에 대한 설정 데이터를 담고 있는 ScriptableObject
[CreateAssetMenu(fileName = "PoolingDataSO", menuName = "Scriptable Objects/PoolingDataSO")]
public class PoolingDataSO : ScriptableObject
{
	// 풀링할 오브젝트 프리팹
	[field: SerializeField] public PoolingObject PoolingObject { get; private set; }
	// 초기 풀 크기
	[field: SerializeField] public int InitialPoolSize { get; private set; } = 10;
}
