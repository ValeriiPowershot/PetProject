using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class EntryPoint : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);

            GameInstaller.Install();

            SceneManager.LoadScene("MainMenu");
        }
    }
}
