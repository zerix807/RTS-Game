﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour {

	private List<Interactive> Selections = new List<Interactive>();

		// Update is called once per frame
	void Update () {
		if (!Input.GetMouseButtonDown (0))
			return;

		var es = UnityEngine.EventSystems.EventSystem.current;
		if (es != null && es.IsPointerOverGameObject ())
			return;

		if (Selections.Count > 0) {
			if (!Input.GetKey (KeyCode.LeftShift) && !Input.GetKey (KeyCode.RightShift)) {
				foreach (var sel in Selections) {
					if (sel != null)
						sel.Deselect ();
				}
				Selections.Clear ();
			}
		}

		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (!Physics.Raycast (ray, out hit))
			return;

		var interact = hit.transform.GetComponent<Interactive> ();

		if (interact == null)
			return;

		Selections.Add (interact);
		interact.Select ();

	}
}
