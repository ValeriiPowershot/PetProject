using Services;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class PlayButtonHandler : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private CurtainService _curtainService;
        [SerializeField] private string _targetSceneName = "GameScene";
        [SerializeField] private float _transitionDelay = 0.5f;

        private void Start()
        {
            _playButton.onClick.AddListener(OnPlayClicked);
        }

        private void OnPlayClicked()
        {
            _playButton.interactable = false;

            _curtainService.Show(() =>
            {
                Invoke(nameof(LoadScene), _transitionDelay);
            });
        }

        private void LoadScene()
        {
            SceneManager.LoadScene(_targetSceneName);
        }
    }
}