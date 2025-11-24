using UnityEngine;

public class ExamplePenguin : MonoBehaviour, ISwimable
{
    public void Swim()
    {
        Debug.Log($"{name} : 나 수영 할 수 있어!");
    }
}
