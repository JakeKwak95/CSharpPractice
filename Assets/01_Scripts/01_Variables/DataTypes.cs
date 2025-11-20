using UnityEngine;

public class DataTypes : MonoBehaviour
{
	// 기본 자료형
	int score = 0;
	float speed = 5.5f;
	bool isGameOver = false;
	string playerName = "Player";

	// Start는 게임이 시작될 때 실행
	void Start()
	{
		Debug.Log("=== Data Types Example ===");
		Debug.Log("Score: " + score);
		Debug.Log("Speed: " + speed);
		Debug.Log("Is Game Over? " + isGameOver);
		Debug.Log("Player Name: " + playerName);

		// 값 변경
		score = 10;
		speed = 7.2f;
		isGameOver = true;
		playerName = "New Player";

		Debug.Log("=== After Update ===");
		Debug.Log($"Score: {score}, Speed: {speed}, GameOver: {isGameOver}, Name: {playerName}");
	}
}
