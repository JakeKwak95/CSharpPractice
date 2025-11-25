using UnityEngine;

public class MovingCubeWithoutSO : MonoBehaviour
{
	public float moveSpeed = 2f;
	public float moveRange = 5f;
	public float rotateSpeed = 90f;

	private void Update()
	{
		Vector3 pos = transform.position;
		pos.x = moveRange * Mathf.Sin(Time.time * moveSpeed);
		transform.position = pos;
		transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
	}
}
