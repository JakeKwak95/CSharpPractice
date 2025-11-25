using System.Collections;
using UnityEngine;

// 추적자의 상태를 정의하는 열거형
public enum ChaserState
{
	None = -1,

	Idle,
	Patrolling,
	Chasing,
	Attacking
}


// 스테이트 패턴(State Pattern) : 객체의 상태를 클래스로 정의하고, 각 상태에 따른 행동을 메서드로 구현하여 상태 전환을 쉽게 관리할 수 있도록 하는 패턴

// FSM 패턴: 객체가 가질 수 있는 상태들을 미리 정의해두고, 각 상태에 따른 동작을 별도의 메서드로 구현한 후
// 상태 전환 시 해당 메서드를 호출하여 동작을 수행하는 패턴
public class StatePattern : MonoBehaviour
{
	// 현재 상태를 저장하는 변수
	ChaserState currentState = ChaserState.None;

	// 각 상태에 필요한 변수들
	[Header("Idle State")]
	[SerializeField] float idleDuration = 1f;

	[Header("Patrolling State")]
	[SerializeField] Transform[] patrolPoints;
	int currentPatrolIndex = 0;
	[SerializeField] float patrolSpeed = 3f;

	[Header("Chasing State")]
	[SerializeField] Transform chaseTarget;
	[SerializeField] float chaseSpeed = 5f;
	[SerializeField] float chaseRange = 5f;

	[Header("Attacking State")]
	[SerializeField] float attackRange = 1f;

	private void Start()
	{
		// 초기 상태를 순찰 상태로 설정
		ChangeState(ChaserState.Patrolling);
	}

	void ChangeState(ChaserState newState)
	{
		// 특정 상태로 이미 전환된 경우, 중복 전환 방지
		// early return 패턴 사용
		if (currentState == newState) return;

		currentState = newState;

		// 상태에 맞는 코루틴 시작 전에 모든 코루틴 정지
		StopAllCoroutines();

		// 상태에 해당하는 코루틴 시작
		// 코루틴 이름과 상태 이름이 동일하므로, currentState.ToString() 사용
		StartCoroutine(currentState.ToString());
	}

	IEnumerator Idle()
	{
		// 대기 시간 동안 대기
		// 자주 호출되는 경우 최적화를 위해선 WaitForSeconds 캐싱 고려
		yield return new WaitForSeconds(idleDuration);
		// 대기 후 순찰 상태로 전환
		ChangeState(ChaserState.Patrolling);
	}

	IEnumerator Patrolling()
	{
		// 순찰 지점들을 순서대로 이동
		// 코루틴의 while 문에 true를 사용하여 Update처럼 동작하도록 함
		while (true)
		{
			// 타겟이 추적 범위 내에 들어오면 추적 상태로 전환
			if (Vector2.Distance(transform.position, chaseTarget.position) <= chaseRange)
			{
				// currentPatrolIndex 증가, 이때 값이 포인트의 개수보다 커지면 순환하도록 모듈로 연산 사용
				currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;

				ChangeState(ChaserState.Chasing);
				yield break;
			}
			// 타겟 포인트에 도달할 때까지 이동
			else if (Vector2.Distance(transform.position, patrolPoints[currentPatrolIndex].position) > 0.05f)
			{
				transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, patrolSpeed * Time.deltaTime);
				yield return null;
			}
			else
			{
				currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;

				// 도달 시 대기 상태로 전환
				ChangeState(ChaserState.Idle);

				yield break;
			}
		}
	}

	IEnumerator Chasing()
	{
		while (true)
		{
			// 타겟이 추적 범위를 벗어나면 순찰 상태로 전환
			if (Vector2.Distance(transform.position, chaseTarget.position) > chaseRange)
			{
				ChangeState(ChaserState.Patrolling);
				yield break;
			}
			// 타겟이 공격 범위 내에 들어오면 공격 상태로 전환
			else if (Vector2.Distance(transform.position, chaseTarget.position) <= attackRange)
			{
				ChangeState(ChaserState.Attacking);
				yield break;
			}
			// 타겟을 향해 이동
			transform.position = Vector2.MoveTowards(transform.position, chaseTarget.position, chaseSpeed * Time.deltaTime);
			yield return null;
		}
	}

	IEnumerator Attacking()
	{
		while (Vector2.Distance(transform.position, chaseTarget.position) <= attackRange)
		{
			// 공격 동작 수행 (여기서는 단순히 로그 출력)
			Debug.Log("공격!");
			yield return null;
		}

		// 타겟이 공격 범위를 벗어나면 추적 상태로 전환
		ChangeState(ChaserState.Chasing);
		yield break;
	}

}
