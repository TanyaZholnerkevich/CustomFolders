using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NoiseGenerator))]
    public class NoiseGenerationEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (GUILayout.Button("Save"))
            {
                var myTarget = target as NoiseGenerator;
                if (myTarget != null)
                {
                    myTarget.SaveTexture();
                }
            }
        }
    }
