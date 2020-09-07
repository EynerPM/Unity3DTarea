using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dibujador : MonoBehaviour
{
    //ATRIBUTOS
    public Configuracion myConfig;


    // Start is called before the first frame update
    protected virtual void Start()
    {
        //
    }

    protected virtual void Inicializar()
    {
        Screen.SetResolution(myConfig.screenWidth, myConfig.screenHeight, true);
    }

    public void Mostrar()
    {
        this.transform.gameObject.SetActive(true);
    }

    public void Ocultar()
    {
        this.transform.gameObject.SetActive(false);
    }

    protected virtual Vector3 GenerarCentroAleatorio()
    {
        return new Vector3();
    }

}
    
