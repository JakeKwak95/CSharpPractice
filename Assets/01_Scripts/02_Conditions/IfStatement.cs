using UnityEngine;

public class IfStatement : MonoBehaviour
{
	// 인스펙터에서 설정할 수 있는 플레이어 체력 변수
	public int playerHealth = 100;

	private void Start()
	{
		Debug.Log("플레이어 체력: " + playerHealth);
	}

	private void Update()
	{
		// 플레이어 체력에 따라 다른 메시지 출력
		if (playerHealth == 100)
		{
			Debug.Log("플레이어가 건강합니다");
		}
		else if(playerHealth >= 50)
		{
			Debug.Log("플레이어가 부상을 입었습니다.");
		}
		else if(playerHealth > 0 && playerHealth < 50) // 논리 연산자 AND
		{
			// 콘솔에 경고 메시지 출력
			Debug.LogWarning("플레이어가 위험합니다.");
		}
		else
		{
			// 콘솔에 오류 메시지 출력
			Debug.LogError("플레이어가 사망했습니다.");
		}
	}
}
