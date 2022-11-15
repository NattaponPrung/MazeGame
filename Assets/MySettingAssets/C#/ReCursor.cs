using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReCursor : MonoBehaviour
{
    void OnLevelWasLoaded(int level)
    {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        
    }
}
