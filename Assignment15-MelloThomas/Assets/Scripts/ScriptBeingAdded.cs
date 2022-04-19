using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBeingAdded : MonoBehaviour
{
    public float valueOfScript = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(valueOfScript, 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
