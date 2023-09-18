using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Getable : MonoBehaviour
{
	static Dictionary<Type, GameObject> Dictionary { get; set; } = new Dictionary<Type, GameObject>();

	public static B Get<B>() where B : Getable
	{
		var type = typeof(B);
		if (Dictionary.ContainsKey(type))
			return Dictionary[type].GetComponent<B>();
		return null;
	}

	public virtual void Awake()
	{
		Dictionary.Add(GetType(), gameObject);
	}

	public virtual void OnDestroy()
	{
		Dictionary.Remove(GetType());
	}
}