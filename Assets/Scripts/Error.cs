using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ErrorWBtn()
    {
        GameManager.I.ReturnW();
    }

    public void ErrorDBtn()
    {
        GameManager.I.ReturnD();
    }
}
