using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Scripts.Utilities
{
    [RequireComponent(typeof(Button))]
    public class BackToMainMenu : MonoBehaviour
    {
        private const string MainMenuSceneName = "MainMenu";

        private Button _button;
        
        private void Awake()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => SceneManager.LoadScene(MainMenuSceneName));
        }

        private void OnDestroy() => _button.onClick.RemoveAllListeners();
    }
}
