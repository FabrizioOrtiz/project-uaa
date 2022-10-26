using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miscript : MonoBehaviour
{
    private bool booleano = true;
    private int cont;
    // Start is called before the first frame update
    private void Awake()
    {
        cont=0;
    }
        
    void Start()
    {
        Debug.Log(cont);
    }

    // Update is called once per frame
    void Update()
    {
        if(booleano)
            Debug.Log(cont++);
    }
}
