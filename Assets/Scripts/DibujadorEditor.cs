using System.Collections;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Dibujador), true)]
public class DibujadorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Dibujador objectoDibujador = (Dibujador) target;

        if(GUILayout.Button("Mostrar"))
        {
            objectoDibujador.Mostrar();
        }

        if(GUILayout.Button("Ocultar"))
        {
            objectoDibujador.Ocultar();
        }
    }
}
