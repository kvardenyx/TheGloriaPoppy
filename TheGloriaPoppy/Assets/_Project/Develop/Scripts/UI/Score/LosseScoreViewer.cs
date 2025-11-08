using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    public class LoseScoreViewer : MonoBehaviour
    {
        private int _score;
        private int _record;
        
        private Text _currentScoreText;
        [SerializeField] private Text _currentRecord;

        private void Start()
        {
            _currentScoreText = gameObject.GetComponent<Text>();
            _currentRecord = _currentRecord.GetComponent<Text>();
            
            _score = PlayerPrefs.GetInt("Score");
            _record = PlayerPrefs.GetInt("Record");

            _currentScoreText.text = "Scored: " + _score.ToString();
            _currentRecord.text = "Record: " + _record.ToString();
        }
    }
}