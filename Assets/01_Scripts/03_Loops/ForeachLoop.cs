using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
	private void Start()
	{
		// 배열 : 여러 개의 같은 타입 데이터를 하나의 변수에 저장하는 자료구조
		string[] enemies = { "Slime", "Goblin", "Orc" };

		// 배열이나 컬렉션의 각 요소를 순회할 때 사용
		// in 의 오른쪽에 있는 컬렉션의 각 요소를 왼쪽 변수에 하나씩 할당하며 반복
		foreach (string enemy in enemies)
		{
			Debug.Log("발견한 적: " + enemy);
		}

		int[] scores = { 10, 20, 30, 40 };
		int totalScore = 0;

		foreach (int score in scores)
		{
			Debug.Log("얻은 점수: " + score);
			totalScore += score;
		}

		Debug.Log("총 점수: " + totalScore);

		// foreach 문은 읽기 전용이므로 요소를 수정할 수 없음
		foreach (int score in scores)
		{
			// score = 100; // 오류 발생: foreach 변수는 읽기 전용
		}

		// 배열 요소를 수정하려면 for 문을 사용해야 함
		for (int i = 0; i < scores.Length; i++)
		{
			Debug.Log("수정 전 점수: " + scores[i]);
			scores[i] += 10; // for 문을 사용하여 배열 요소 수정
			Debug.Log("수정 후 점수: " + scores[i]);
		}

		// 다음 예제를 위해 점수 배열 초기화
		scores = new int[] { 10, 20, 30, 40 };

		// continue 문 예제, 루프 건너뛰기
		totalScore = 0;
		foreach (int score in scores)
		{
			if (score == 30)
			{
				Debug.Log(score + " (패스)");
				continue; // continue 만날 시 루프 건너뜀, 즉 30 점수는 패스
			}

			Debug.Log("얻은 점수: " + score);
			totalScore += score;
		}
		Debug.Log("총 점수: " + totalScore);

		// break 문 예제, 루프 탈출
		foreach (int score in scores)
		{
			if (score >= 30)
			{
				Debug.Log("30점 이상 점수 발견! 점수: " + score);
				break; // break 만나면 foreach 루프 탈출
			}
			Debug.Log("얻은 점수: " + score);
		}
	}
}
