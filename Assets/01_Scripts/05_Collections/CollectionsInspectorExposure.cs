using System.Collections.Generic;
using UnityEngine;

public class CollectionsInspectorExposure : MonoBehaviour
{
	// 배열과 리스트는 인스펙터에 노출되지만
	public int[] intArray;
    public List<int> intList;
	// 인스펙터에 노출된 컬렉션 변수는 초기화하지 않아도 됨

	// 딕셔너리, 큐, 스택은 인스펙터에 노출되지 않음
	public Dictionary<string, int> stringIntDictionary;
    public Queue<int> intQueue;
    public Stack<int> intStack;
}
