using System;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.Panel
{
    public class LosseTextViewer : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        [SerializeField] private Text recordText;

        private void Start()
        {
            scoreText = GetComponent<Text>();
            recordText = GetComponent<Text>();
        }

        public void WriteText(int score, int record)
        {
            scoreText.text = score.ToString("Scored:" + score);
            recordText.text = record.ToString("Record:" + record);
        }
    }
}