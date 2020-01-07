using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchRotate : MonoBehaviour
{
  
    public void OnMouseDown()
    {
        Debug.Log("clicked");
        if (!GameControl.youWin)
        {
            transform.Rotate(0f, 0f, 90f);
        }
    }
}
