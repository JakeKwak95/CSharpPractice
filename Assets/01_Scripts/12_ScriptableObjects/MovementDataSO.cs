using UnityEngine;

// 유니티 6 이상 버젼에서 자동으로 추가
[CreateAssetMenu(fileName = "MovementDataSO", menuName = "Scriptable Objects/MovementDataSO")]
public class MovementDataSO : ScriptableObject
{
    public float moveSpeed = 5f;
    public float moveRange = 10f;
	public float rotateSpeed = 180f;
}
