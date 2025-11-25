using UnityEngine;

public class MovingCubeWithSO : MonoBehaviour
{
    public MovementDataSO movementData;

	private void Update()
	{
		Vector3 pos = transform.position;
		pos.x = movementData.moveRange * Mathf.Sin(Time.time * movementData.moveSpeed);
		transform.position = pos;
		transform.Rotate(Vector3.forward, movementData.rotateSpeed * Time.deltaTime);
	}
}
