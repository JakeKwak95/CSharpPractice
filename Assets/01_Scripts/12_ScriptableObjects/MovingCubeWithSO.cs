using UnityEngine;

public class MovingCubeWithSO : MonoBehaviour
{
	// ScriptableObject 참조
	public MovementDataSO movementData;

	private void Update()
	{
		// ScriptableObject의 데이터 사용
		Vector3 pos = transform.position;
		pos.x = movementData.moveRange * Mathf.Sin(Time.time * movementData.moveSpeed);
		transform.position = pos;
		transform.Rotate(Vector3.forward, movementData.rotateSpeed * Time.deltaTime);
	}
}
