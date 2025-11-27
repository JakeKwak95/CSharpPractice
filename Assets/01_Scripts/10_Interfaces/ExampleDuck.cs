using UnityEngine;

public class ExampleDuck : ExampleBirdBase, ISwimable, IFlyable
{
	protected override void Eat()
	{
		Debug.Log($"{name} : 벌레를 먹어!");
	}

	public override void IntroduceYourSelf()
	{
		Eat();
		Swim();
		Fly();
	}

	public void Swim()
	{
		Debug.Log($"{name} : 나 수영 할 수 있어!");
	}

	public void Fly()
	{
		Debug.Log($"{name} : 나 날 수 있어!");
	}
}
