using UnityEngine;

public class ExamplePenguin : ExampleBirdBase, ISwimable
{
	protected override void Eat()
	{
		Debug.Log($"{name} : 물고기를 먹어!");
	}
	public override void IntroduceYourSelf()
	{
		Eat();
		Swim();
	}

	public void Swim()
	{
		Debug.Log($"{name} : 나 수영 할 수 있어!");
	}
}
