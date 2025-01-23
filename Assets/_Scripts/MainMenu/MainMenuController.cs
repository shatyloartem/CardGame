using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Scripts.MainMenu
{
    public class MainMenuController : MonoBehaviour
    {
        private const string GameScene = "GameScene", EditScene = "EditScene";

        [SerializeField] private Button _playButton, _editButton;

        private void Awake()
        {
            SetButton(_playButton, GameScene);
            SetButton(_editButton, EditScene);
        }

        private void OnDestroy()
        {
            _playButton.onClick.RemoveAllListeners();
            _editButton.onClick.RemoveAllListeners();
        }

        private static void SetButton(Button button, string scene) => 
            button.onClick.AddListener(() => SceneManager.LoadScene(scene));
    }
}
