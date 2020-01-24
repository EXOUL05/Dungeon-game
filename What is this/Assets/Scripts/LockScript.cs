using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public bool isLocked;
    public ItemsScript itemsScript;
    // Start is called before the first frame update
    void Start()
    {
        isLocked = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocked == true)
        {
            itemsScript.enabled = false;
        }
        else if(isLocked == false)
        {
            itemsScript.enabled = true;
        }
    }
}
