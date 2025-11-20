using System.Collections.Generic;
using UnityEngine;

// 리스트에 비해 자주 사용되는 자료구조는 아니지만
// 특수 한 상황에서 유용하게 사용될 수 있음
public class QueueStackExample : MonoBehaviour
{
	// 큐 : 선입선출(FIFO : 퍼스트 인 퍼스트 아웃) 방식
	// Enqueue(값) : 값 추가
	// Dequeue() : 값 제거 및 반환
	Queue<int> numberQueue = new Queue<int>();

	// 스택 : 후입선출(LIFO : 라스트 인 퍼스트 아웃) 방식
	// Push(값) : 값 추가
	// Pop() : 값 제거 및 반환
	Stack<int> numberStack = new Stack<int>();

	void Start()
	{
		// Queue에 값 추가
		numberQueue.Enqueue(1);
		numberQueue.Enqueue(2);
		numberQueue.Enqueue(3);

		for (int i = 0; i < 4; i++)
		{
			if (numberQueue.Count > 0)
			{
				int dequeuedNumber = numberQueue.Dequeue();
				Debug.Log($"Dequeued Number: {dequeuedNumber}");
			}
			else
			{
				Debug.Log("큐가 비었습니다");
			}
		}

		// Stack에 값 추가
		numberStack.Push(1);
		numberStack.Push(2);
		numberStack.Push(3);

		for (int i = 0; i < 4; i++)
		{
			if (numberStack.Count > 0)
			{
				int poppedNumber = numberStack.Pop();
				Debug.Log($"Popped Number: {poppedNumber}");
			}
			else
			{
				Debug.Log("스택이 비었습니다");
			}
		}

		// 큐에 들어간 순서대로 나오는 반면에
		// 스택은 나중에 들어간 값이 먼저 나옴
	}

}
