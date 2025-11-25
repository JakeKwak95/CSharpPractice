using System.Collections;
using UnityEngine;

// Invoke : 메서드는 일정 시간 후에 특정 메서드를 호출하거나, 반복적으로 호출하는 기능을 제공
// 매개변수 사용 불가
public class InvokeExample : MonoBehaviour
{
	private void Start()
	{
		// 첫번째 매개변수 : 호출할 메서드 이름 문자열
		// 두번째 매개변수 : 지연 시간(초), 0이 디폴트
		Invoke(nameof(InvokeMethod), 2f);
		Invoke(nameof(InvokeMethod), 5f);

		// 세번째 매개변수 : 반복 호출 간격(초)
		InvokeRepeating(nameof(InvokeRepeatMethod), 1f, 1.5f);

		// 4초 후에 모든 Invoke 및 InvokeRepeating 호출 취소
		Invoke(nameof(CancelInvoking), 4f);

		// Invoke(nameof(InvokeMethod), 5f); 은 최소되어 호출 되지 않음
		// 시작과 동시에 코루틴 실행
		StartCoroutine(CoTest());

		// 게임 오브젝트 비활성화
		gameObject.SetActive(false);


		// 코루틴의 경우 게임오브젝트가 비활성화 될 시 중단, 비활성화 된 상태에서 코루틴 시작 시도 시 에러 발생
		// 인보크의 경우 게임오브젝트가 비활성화 되더라도 계속 호출
	}

	void InvokeMethod()
	{
		// :0.0 : 소수점 첫째 자리까지 표시
		Debug.Log($"Invoke 호출됨! {Time.time:0.0}");
	}

	void InvokeRepeatMethod()
	{
		Debug.Log($"Invoke 반복 호출됨! {Time.time:0.0}");
	}

	void CancelInvoking()
	{
		// 모든 Invoke 및 InvokeRepeating 호출 취소
		CancelInvoke();
		Debug.Log($"모든 Invoke 호출 취소됨! {Time.time:0.0}");

		// 특정 메서드의 Invoke 호출 취소
		// CancelInvoke(nameof(InvokeMethod));
	}

	IEnumerator CoTest()
	{
		// Start가 호출된 프레임에서 실행
		Debug.Log("한 프레임 전");
		// 다음 프레임으로 넘김
		yield return null;
		// 다음 프레임에서 실행
		Debug.Log("한 프레임 후");
	}
}
