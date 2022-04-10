using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLauncher : MonoBehaviour
{
    public void Launch(object obj)
    {
        var body = (obj as GameObject).GetComponent<Rigidbody>();
        (obj as GameObject).SetActive(true);
        body.transform.position = transform.position;
        body.transform.rotation = transform.rotation;
    }
}
