using UnityEngine;
using System.Collections;

public class LevelTP : MonoBehaviour
{
	public RestartDeath rD;
	public GameObject thisLevelSet;
	public GameObject otherLevelSet;
	public int ticksUntilSwitch = 480;
	public bool complete = false;

	void Update()
	{
		if(complete)
		{
			ticksUntilSwitch-=1;
			thisLevelSet.rigidbody.isKinematic=false;
			thisLevelSet.rigidbody.useGravity=true;
		}
		if(ticksUntilSwitch<1)
		{
			thisLevelSet.SetActive(false);
			otherLevelSet.SetActive(true);
			rD.gameObject.transform.position=rD.startingPos;
		}
	}
}
