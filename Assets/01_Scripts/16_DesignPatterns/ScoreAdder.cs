using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
	[ContextMenu("Add Score")]
	// *SingletonPattern.Instance는 Awake 메서드에서 초기화되므로, ScoreAdder가 SingletonPattern보다 먼저 실행되지 않도록 주의해야 합니다.
	// 즉, 에딧모드에서 ScoreAdder의 AddScore를 호출하려 하면 NullReferenceException이 발생할 수 있습니다.
	void AddScore()
	{
		// 싱글톤 패턴을 사용하여 전역 인스턴스에 접근하고 점수 추가
		SingletonPattern.Instance.AddScore();

		// 현재 점수 출력
		Debug.Log($"현재 스코어 : {SingletonPattern.Instance.Score}");
	}
}
