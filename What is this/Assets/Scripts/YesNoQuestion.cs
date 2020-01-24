using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YesNoQuestion : MonoBehaviour
{
    public int acceptaVal;
    public bool isBeingUsed;

    private void Update()
    {
        if (isBeingUsed == false)
        {
            acceptaVal = 0;
        }
    }

    private void Start()
    {
        acceptaVal = 0;
    }
    public void Yes()
    {
        acceptaVal = 1;
    }
    public void No()
    {
        acceptaVal = 2;
    }

}
