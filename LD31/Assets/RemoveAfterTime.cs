using UnityEngine;
using System.Collections;

public class RemoveAfterTime : MonoBehaviour
{
	public int timeTillDespawn;
	public int timeLeft;
	void Update()
	{
		timeLeft-=1;
		if(timeLeft<1)
		{
			Destroy(this.gameObject);
		}
	}
}
