using System.Collections.Generic; // List<T> 사용을 위해 System.Collections.Generic 네임스페이스 포함
using UnityEngine;

public class ListExample : MonoBehaviour
{
	// 문자열을 요소로 갖는 빈 List 생성
	// 배열과 달리 길이를 미리 지정하지 않아도 됨
	// 리스트에 요소 추가에 따라 자동으로 크기 조절
	List<string> enemies = new List<string>();

	private void Start()
	{
		// List에 요소 추가
		enemies.Add("Orc");
		enemies.Add("Slime");
		enemies.Add("Goblin");

		// 중복 요소도 허용
		enemies.Add("Orc");

		// List는 다른 타입 요소 추가 불가
		// enemies.Add(1);

		Debug.Log("적 리스트 크기: " + enemies.Count);

		foreach (string enemy in enemies)
		{
			Debug.Log("적 발견: " + enemy);
		}

		Debug.Log("첫 번째 적은: " + enemies[0]);

		// List에서 요소 제거
		enemies.Remove("Goblin");
		Debug.Log("Goblin 제거 후 적 수: " + enemies.Count);

		if (enemies.Contains("Goblin"))
		{
			Debug.Log("Goblin 이 존재합니다!");
		}
		else
		{
			Debug.Log("Goblin 이 존재하지 않습니다!");
		}

		enemies.Remove("Orc"); // 첫 번째 Orc만 제거
		Debug.Log("Orc 하나 제거 후 적 수: " + enemies.Count);

		if (enemies.Contains("Orc"))
		{
			Debug.Log("Orc 가 아직도 존재합니다!");
		}
		else
		{
			Debug.Log("Orc 가 모두 제거되었습니다!");
		}

		// 리스트의 요소들 확인
		foreach (string enemy in enemies)
		{
			Debug.Log("적 발견: " + enemy);
		}

		enemies.RemoveAt(0); // 인덱스로 요소 제거
	    Debug.Log("인덱스 0 요소 제거 후 적 수: " + enemies.Count);

		// 최종 리스트 출력
		foreach (string enemy in enemies)
		{
			Debug.Log("최종 적 리스트: " + enemy);
		}

	}
}
