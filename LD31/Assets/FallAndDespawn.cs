using UnityEngine;
using System.Collections;

public class FallAndDespawn : MonoBehaviour
{
	public GameObject thisLevelSet;
	public GameObject otherLevelSet;
	public GameObject extraObj;
	public int ticksUntilSwitchA = 480;
	public int ticksUntilSwitchB = 480;

	void Update()
	{
		ticksUntilSwitchA-=1;
		if(ticksUntilSwitchA<1)
		{
			ticksUntilSwitchB-=1;
			thisLevelSet.rigidbody.isKinematic=false;
			thisLevelSet.rigidbody.useGravity=true;
		}
		if(ticksUntilSwitchB<1)
		{
			thisLevelSet.SetActive(false);
			extraObj.SetActive(false);
			otherLevelSet.SetActive(true);
		}
	}
}
