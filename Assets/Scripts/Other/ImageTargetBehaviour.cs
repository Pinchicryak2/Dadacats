using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class serves both as an augmentation definition for an ImageTarget  in the editor
/// as well as a tracked image target result at runtime
/// </summary>
public class ImageTargetBehaviour : MonoBehaviour
{
	void OnGUI () {
		
		// call this block
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
			// or ask to quit
		}
	}
}