using UnityEngine;

// 싱글톤 패턴 (Singleton Pattern)
// - 오직 하나의 인스턴스만 존재하도록 보장하는 디자인 패턴
// - 전역 접근 지점을 제공하여 어디서든 인스턴스에 접근 가능
// - 주로 설정 관리자, 로깅 시스템, 게임 매니저 등에 사용
// - 장점: 인스턴스 관리가 용이하고, 전역 접근이 가능
// - 단점: 테스트 어려움, 전역 상태로 인한 의존성 증가
// - 구현 방법: 정적 변수와 정적 메서드를 사용하여 인스턴스를 관리

public class SingletonPattern : MonoBehaviour
{
	// 싱글톤 인스턴스 정의
	public static SingletonPattern Instance { get; private set; }

	// 타 클래스에서 접근 가능한 점수 변수
	// private set을 통해 직접 수정 불가
	// 점수는 AddScore 메서드를 통해서만 증가
	public int Score { get; private set; } = 0;

	// 게임 상태 변수
	// 보통 GameManager 같은 싱글톤 클래스에서 관리
	// 게임의 상태를 여러 클래스에서 관리한다는 것이 혼란스러울 수 있으므로
	public GameState CurrentGameState { get; private set; } = GameState.Starting;

	private void Awake()
	{
		if (Instance == null) // 인스턴스(싱글톤 객체)가 없으면 현재 인스턴스를 할당
			Instance = this;
		else // 인스턴스가 이미 존재하면 중복 인스턴스 제거
			Destroy(gameObject);

		// 위 과정으로 인해 씬에서 하나의 인스턴스만 존재하게 됨
	}

	public void AddScore()
	{
		Score += 10;

		// if else 문의 삼항 연산자 사용 예시
		// (조건) ? (조건이 '참'일 경우 실행할 코드) : (조건이 '거짓'일 경우 실행할 코드 )​;
		CurrentGameState = Score >= 30 ? GameState.Clear : GameState.Playing;

		Debug.Log($"현재 게임 상태는 : {CurrentGameState}");
	}
}

public enum GameState
{
	Starting,
	Playing,
	Clear,
	GameOver
}