using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace QulisoftTestTask.Ui
{
    public class ButtonSceneLoader : MonoBehaviour
    {
        [SerializeField] private bool _isRestart = false;
        [SerializeField] private bool _isQuit = false;
    
        [SerializeField] private string _sceneToLoadName;

        [SerializeField] private Button _button;

        private void OnEnable()
        {
            _button.onClick.AddListener(LoadScene);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(LoadScene);
        }

        private void LoadScene()
        {
            if (_isRestart)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                return;
            }
            if (_isQuit)
            {
                Application.Quit();
                return;
            }

            SceneManager.LoadScene(_sceneToLoadName);
        }
    }
}