using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    [SerializeField] GameObject LockObject = new GameObject();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ThisObject = this.gameObject;
        ThisObject.transform.position = LockObject.transform.position;
    }
}
