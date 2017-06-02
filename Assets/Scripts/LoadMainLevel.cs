using UnityEngine;
using System.Collections;

public class LoadMainLevel : MonoBehaviour {

	// Function That Gets Mouse Click and Changes Scene
    void OnMouseDown()
    {
        // Load Main Level
        Application.LoadLevel(1);
    }
}
