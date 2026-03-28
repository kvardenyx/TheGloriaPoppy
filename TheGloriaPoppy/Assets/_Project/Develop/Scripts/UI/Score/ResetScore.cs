using UnityEngine;

namespace _Project.Scripts
{
    public class ResetScore : MonoBehaviour
    {
        public void ResetRecord()
        {
            PlayerPrefs.SetInt("Record", 0);
        }
    }
}