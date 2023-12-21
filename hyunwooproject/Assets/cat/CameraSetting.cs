using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSetting : MonoBehaviour
{
    catcantroller catControl;
    private void Start()
    {
        catControl = GameObject.FindObjectOfType<catcantroller>();
    }

    private void Update()
    {
        Vector3 catPos = catControl.gameObject.transform.position;
        transform.position = new Vector3(catPos.x, catPos.y, transform.position.z);
    }
}
