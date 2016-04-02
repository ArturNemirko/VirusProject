﻿using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour {

	public float maxHP = 100.0f;
	public float curHP = 100.0f;
	public Color MaxDamageColor = Color.red; 
	public Color MinDamageColor = Color.green;

	private void Awake()
	{
		GlobalVars.Basis = gameObject.GetComponent<Base>();
	}

	public void ChangeHP(float adjust)
	{
		curHP -= adjust;
	}

	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Renderer>().material.color = Color.Lerp(MaxDamageColor, MinDamageColor, curHP/maxHP);
		if (curHP <= 0)
		{
			Destroy(gameObject);
		}
	}

	private void OnDestroy()
	{
		GlobalVars.Basis = null;
	}
}
