using UnityEngine;

public class CompareValues : MonoBehaviour
{
	int integerA = 10;
	int integerB = 20;

	float floatA = 10f;

	private void Start()
	{
		Debug.Log("IntegerA: " + integerA + ", IntegerB: " + integerB);

		// == 연산자
		if (integerA == integerB)
		{
			Debug.Log("두 점수는 같습니다!");
		}
		else
		{
			Debug.Log("두 점수는 다릅니다!");
		}

		// !=
		if (integerA != integerB)
		{
			Debug.Log("IntegerA 와 IntegerB 는 같지 않습니다.");
		}

		// >, <
		if (integerA > integerB)
		{
			Debug.Log("IntegerA 가 더 큽니다!");
		}
		else if (integerA < integerB)
		{
			Debug.Log("IntegerB 가 더 큽니다!");
		}
		else
		{
			Debug.Log("두 점수는 같습니다!");
		}

		// >=, <=
		if (integerA >= 10)
		{
			Debug.Log("IntegerA 가 10 이상입니다.");
		}

		// 서로 다른 자료형 비교
		if (floatA == integerA)
		{
			Debug.Log("FloatA 와 IntegerA 는 같습니다.");
		}
		else
		{
			Debug.Log("FloatA 와 IntegerA 는 다릅니다.");
		}

		// float과 integer 나눗셈 결과 비교
		if (floatA / 3 == integerA / 3)
		{
			Debug.Log($"FloatA / 3: {floatA / 3} 와 IntegerA / 3: {integerA / 3} 는 같습니다.");
		}
		else
		{
			// 정수 나눗셈은 소수점 이하를 버리기 때문에 결과가 다릅니다.
			Debug.Log($"FloatA / 3: {floatA / 3} 와 IntegerA / 3: {integerA / 3} 는 다릅니다.");
		}

		// 부동소수점 비교 주의점
		if (floatA + 0.0000001f == 10.0000001f)
		{
			Debug.Log("FloatA + 0.0000001f 와 10.0000001f 는 같습니다.");
		}
		else
		{
			// 컴퓨터가 소수점 계산을 할 때 발생하는 매우 작은 오차 때문에 같지 않을 수 있습니다.
			Debug.Log("FloatA + 0.0000001f 와 10.0000001f 는 다릅니다.");
		}

		// 부동소수점 비교 시에는 Mathf.Approximately() 함수를 사용하는 것이 좋습니다.
		if (Mathf.Approximately(floatA + 0.0000001f, 10.0000001f))
		{
			// 매우 작은 오차 범위 내에서는 같다고 판단합니다.
			Debug.Log("FloatA + 0.0000001f 와 10.0000001f 는 같습니다.");
		}
		else
		{
			Debug.Log("FloatA + 0.0000001f 와 10.0000001f 는 다릅니다.");
		}
	}
}
