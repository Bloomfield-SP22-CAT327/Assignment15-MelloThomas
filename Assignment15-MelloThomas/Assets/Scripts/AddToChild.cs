using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToChild : MonoBehaviour
{
    public float changeValueOfScript = 10.0f;
    public float Value;
    public ScriptBeingAdded Bloop;

    // Start is called before the first frame update
    void Start()
    {
        //Value = GameObject.FindWithTag("GameController").GetComponent<GameController>().Value;
        foreach (Transform child in transform)
        {
            AttachScript(child.gameObject);
        }
    }

    void AttachScript(GameObject target)
    {
        ScriptBeingAdded sos = target.AddComponent<ScriptBeingAdded>();
        sos.valueOfScript = changeValueOfScript;

    }
    void DettachScript()
    {
        Bloop = GameObject.FindWithTag("Child").GetComponent<ScriptBeingAdded>();

        Destroy(Bloop);

    }

    void Update()
    {

        Value = GameObject.FindWithTag("GameController").GetComponent<GameController>().Value;

        if (changeValueOfScript != Value)
        {
            changeValueOfScript = Value;
            DettachScript();
            Start();
        }
                
    }
}
