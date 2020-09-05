using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Configuracion
{
    [HideInInspector]
    public int screenWidth = 1920;
    [HideInInspector]
    public int screenHeight = 1080;

    public int elementos;// = 100;
    public Vector3 minValue;
    public Vector3 maxValue;

    public Configuracion()
    {
        //minValue = new Vector3(-500, -500, -500);
        //maxValue = new Vector3( 500,  500,  500);
    }
}
