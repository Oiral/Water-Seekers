using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursor : MonoBehaviour
{

    public static LockCursor instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Debug.Log("Multiple Lock Cursor Game Objects", gameObject);
            return;
        }

        Lock(true);
    }

    public bool locked = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Lock(!locked);
        }
    }

    public void Lock(bool val)
    {
        Cursor.lockState = val? CursorLockMode.Locked: CursorLockMode.None;
        Cursor.visible = !val;
        locked = val;
    }
}
