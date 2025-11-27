using UnityEngine;

public class ExampleEagle : ExampleBirdBase, IFlyable
{
	protected override void Eat()
	{
		Debug.Log($"{name} : Áã¸¦ ¸Ô¾î!");
	}

	public override void IntroduceYourSelf()
	{
		Eat();
		Fly();
	}

	public void Fly()
    {
        Debug.Log($"{name} : ³ª ³¯ ¼ö ÀÖ¾î!");
    }
}