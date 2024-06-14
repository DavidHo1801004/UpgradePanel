using System;

using UnityEditor;
using UnityEngine;

using User.Manager.General;

namespace User.Manager.General
{
    public class GameStateManager : MonoBehaviour
    {
        public static GameStateManager Instance { get; private set; }

        public static Action OnLevelUp;

        private void Awake()
        {
            if (!Instance)
            {
                Instance = this;
            }
            else
            {
                Destroy(Instance);  
            }
        }

        public void LevelUp()
        {
            OnLevelUp?.Invoke();
        }
    }
}

[CustomEditor(typeof(GameStateManager))]
public class GameStateManagerEditor : Editor
{
    private GameStateManager asTarget;

    public override void OnInspectorGUI()
    {
        asTarget = (GameStateManager)base.target;

        base.OnInspectorGUI();

        if (GUILayout.Button("Level Up"))
        {
            asTarget.LevelUp();
        }
    }
}