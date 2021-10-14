using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [Tooltip("tiempo de autodestruccion del gameobject")]
    public float destroyDelay;

    // Start is called before the first frame update
    void OnEnable()
    {
        //Destroy(gameObject, destroy);
        Invoke("HideObject", destroyDelay);
    }
    void HideObject()
    {
        gameObject.SetActive(false);
    }
    
}
