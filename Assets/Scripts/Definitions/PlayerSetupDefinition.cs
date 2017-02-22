﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerSetupDefinition {
		
	public string Name;

	public Transform Location;

	public Color AccentColor;

	public List<GameObject> StartingUnits = new List<GameObject>();

	private List<GameObject> activeUnits = new List<GameObject> ();

	public List<GameObject> ActiveUnits { get { return activeUnits; } }

	public bool IsAI;

	public float Credits;
}
