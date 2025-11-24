using UnityEngine;

public class MultipleInterfaceExample : MonoBehaviour
{
    public GameObject[] exampleBirds;

	private void Start()
	{
		foreach (GameObject bird in exampleBirds)
        {
            WhatCanYouDo(bird);
		}
	}

	void WhatCanYouDo(GameObject gameObject)
    {
        ISwimable swimable = gameObject.GetComponent<ISwimable>();
        IFlyable flyable = gameObject.GetComponent<IFlyable>();
        if (swimable != null)
        {
            swimable.Swim();
        }
        if (flyable != null)
        {
            flyable.Fly();
		}
	}

}
