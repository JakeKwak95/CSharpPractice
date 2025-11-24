using UnityEngine;

public class InterfaceVsInheritance : MonoBehaviour
{
	// 클래스를 상속받은 경우 인스펙터에서 할당 할 수 있다
	public ExampleBirdBase[] exampleBirdBases;

	private void Start()
	{
		foreach (ExampleBirdBase bird in exampleBirdBases)
		{
			// ExampleBirdBase 기본 클래스의 메서드를 호출하기 때문에 별도의 형변환이 필요 없다
			bird.IntroduceYourSelf();
		}
	}

}
