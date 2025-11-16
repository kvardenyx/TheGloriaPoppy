using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class LossePanelText : MonoBehaviour
    {
        public Text _scoreText;
        public Text _recordText;
        
        public void Init(int score, int record)
            {
                _scoreText.text = score.ToString();
                _recordText.text = record.ToString();
            }
    }
}