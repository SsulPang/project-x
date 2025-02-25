using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Road_Snap))]
public class RoadSnapEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Road_Snap script = (Road_Snap)target;
        if (GUILayout.Button("Snap"))
        {
            script.Snap();
        }
    }
}