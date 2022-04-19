using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private Slider valueChangerSlider;
    public float Value;
    //public float sliderValue;



    // Start is called before the first frame update
    void Awake()
    {
        valueChangerSlider = GameObject.Find("ValueChangerSlider").GetComponent<Slider>();
        Value = GameObject.FindWithTag("GameController").GetComponent<AddToChild>().changeValueOfScript;
        
      
    }

   
    public void ChangeValueSlider()
    {
        Value = valueChangerSlider.value * 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
