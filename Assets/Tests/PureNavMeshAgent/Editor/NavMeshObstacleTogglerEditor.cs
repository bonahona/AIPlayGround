using UnityEditor;
using UnityEngine;

namespace Tests.PureNavMeshAgent {
    [CustomEditor(typeof(NavMeshObstacleToggler))]
    public class NavMeshObstacleTogglerEditor : Editor
    {
        public override void OnInspectorGUI() {
            base.OnInspectorGUI();
            EditorGUILayout.Space();
            if(GUILayout.Button("Toggle")) {
                (target as NavMeshObstacleToggler).Toggle();
            }
        }
    }
}
