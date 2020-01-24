using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ObjectBuilderScript))]
public class MapGenerator : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        ObjectBuilderScript myScript = (ObjectBuilderScript)target;
        if (GUILayout.Button("Generate Map"))
        {
            myScript.GenerateMap();
        }
        if (GUILayout.Button("Clear Map"))
        {
            myScript.ClearMap();
        }
    }
}


