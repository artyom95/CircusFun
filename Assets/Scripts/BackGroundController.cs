using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

/*
 * 	This script is used to generate the background repeatedly. 
 */ 

public class BackGroundController : MonoBehaviour
{
	[SerializeField]
	private GameObject _backGround;	//	The background prefab which should be generated repeatedly.

	// Use this for initialization
	private void Start () 
	{
		InvokeRepeating (nameof(InstanceBackGround),0.03f, 5.0f);
	}

	private void InstanceBackGround()
	{
		Instantiate (_backGround);
	}
}