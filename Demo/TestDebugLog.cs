using UnityEngine;

namespace PufferSoftware.Utilities
{
    public class TestDebugLog : MonoBehaviour
    {
        private void Awake()
        {
            PSDebug.Log("Classic Log!");
            PSDebug.LogWarning("Warning Log!");
            PSDebug.LogError("Error Log!");
        }
    }
}