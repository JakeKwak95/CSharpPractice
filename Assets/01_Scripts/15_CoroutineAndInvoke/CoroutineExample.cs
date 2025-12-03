using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

// 코루틴(Coroutine) : 특정 작업을 여러 프레임에 걸쳐 나누어 수행할 수 있게 해주는 기능
// 주로 게임에서 시간 지연, 애니메이션, 비동기 작업 등에 사용
// MonoBehaviour 클래스에서 StartCoroutine 메서드를 통해 시작
// 코루틴 메서드는 IEnumerator 반환 타입을 사용하며, yield return 문을 통해 일시 중지 지점을 지정

// yield return null : 다음 프레임까지 대기
// yield return new WaitForSeconds(초) : 지정한 시간(초) 동안 대기
// yield return new WaitUntil(조건) : 조건이 참이 될 때까지 대기
// yield return new WaitWhile(조건) : 조건이 거짓이 될 때까지 대기

// 코루틴은 StopCoroutine 메서드를 통해 중지할 수 있음


// 코루틴은 게임 오브젝트가 비활성화되거나 파괴될 때 자동으로 중지됨
public class CoroutineExample : MonoBehaviour
{

	Coroutine coroutineToStop;

	private void Start()
	{
		// StartCoroutine(ExampleCoroutine());
		// StartCoroutine(CoPrintNumbers(5));
		// StartCoroutine(CoChangeColor());

		// 메서드 이름 문자열을 사용하여 코루틴 시작 가능
		// 이 경우 매개변수 전달 불가
		// nameof : 컴파일 시점에 메서드 이름을 문자열로 변환
		// StartCoroutine(nameof(CoChangeColor));
		// StartCoroutine("CoChangeColor");

		coroutineToStop = StartCoroutine(CoPrintNumbers(10));
		StartCoroutine(CoStop(coroutineToStop));


	}

	IEnumerator CoStop(Coroutine toStop)
	{
		yield return new WaitForSeconds(3f);
		StopCoroutine(toStop);
		Debug.Log("정지!");
	}

	private IEnumerator ExampleCoroutine()
	{
		Debug.Log("시작");
		yield return new WaitForSeconds(.5f);
		Debug.Log("0.5 초 후");
	}

	// 코루틴 메서드
	// IEnumerator 반환 타입을 사용
	// 매개변수 사용 가능
	private IEnumerator CoPrintNumbers(int end)
	{
		Debug.Log("시작!");

		for (int i = 1; i <= end; i++)
		{
			Debug.Log($"숫자 : {i}");
			yield return new WaitForSeconds(1f); // 1초 대기, 게임의 쿨타임과 같은 기능을 만들 수 있음
		}

		Debug.Log("끝!");
	}

	// 큐브 오브젝트의 색을 변경하는 코루틴 예제
	IEnumerator CoChangeColor()
	{
		// 큐브 오브젝트 생성
		GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
		// Renderer 컴포넌트의 Material 가져오기
		Material material = gameObject.GetComponent<Renderer>().material;

		// 색상 변경을 위한 시작 색상과 끝 색상 정의
		Color startColor = Color.red;
		Color endColor = Color.blue;

		float duration = 5f; // 색상 변경에 걸리는 시간
		float elapsed = 0f; // 경과 시간

		while (elapsed < duration) // duration 동안 반복
		{
			// 경과 시간 업데이트
			elapsed += Time.deltaTime;
			// 경과 시간에 따른 보간 값 계산
			float t = elapsed / duration;
			// 선형 보간을 사용하여 색상 변경
			// Lerp : 두 색상 사이를 t 비율로 보간 (t가 0이면 startColor, 1이면 endColor)
			material.color = Color.Lerp(startColor, endColor, t);
			yield return null; // 다음 프레임까지 대기
		}

		material.color = endColor; // 최종 색상 설정
	}
}
