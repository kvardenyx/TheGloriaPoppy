using UnityEngine;

namespace _Project.Scripts.Panel
{
    public class PanelController : MonoBehaviour
    {
        [SerializeField] private Transform canvasTransform;

        private GameObject _pausePanelInstante;
        [SerializeField] private GameObject pausePanel;
        [SerializeField] private GameObject lossePanel;

        [SerializeField] private HealthController _healthController;

        [SerializeField] private PanelController _panelController;

        private void OnEnable()
        {
            _healthController.PlayerIsDead += OnLossePanel;
        }

        private void OnDisable()
        {
            _healthController.PlayerIsDead -= OnLossePanel;
        }
        
        private void OnLossePanel()
        {
            Time.timeScale = 0f;

            var panel = Instantiate(lossePanel, canvasTransform);
            var panelText = panel.GetComponent<LosseTextViewer>();
            panelText.WriteText(PlayerPrefs.GetInt("Score"), PlayerPrefs.GetInt("Record"));
        }
        
        public void OnPausePanel()
        {
            Time.timeScale = 0f;

            _pausePanelInstante = Instantiate(pausePanel, canvasTransform);
        }

        public void OnContinueGame()
        {
            Time.timeScale = 1f;

            if (_pausePanelInstante != null)
            {
                Destroy(_pausePanelInstante);
            }
        }
    }
}