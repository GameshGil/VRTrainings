using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    private Outline outline;

    private void Start()
    {
        outline = gameObject.GetComponent<Outline>();
        outline.enabled = false;
    }

    public void OutlineOn()
    {
        outline.enabled = true;
    }

    public void OutlineOff()
    {
        outline.enabled = false;
    }
}
