using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace MenuUI
{
    public class Menu : MonoBehaviour
    {
        [SerializeField] private GameObject playButton;
        [SerializeField] private GameObject quitButton;
        void Start()
        {
       
        }

        public void Play()
        {
            SceneManager.LoadScene("SandyScene");
        
            EventSystem.current.SetSelectedGameObject(null);
        
            EventSystem.current.SetSelectedGameObject(playButton);
        }

        public void Quit()
        {
            Debug.Log("Quit");
        
            Application.Quit();
        
            EventSystem.current.SetSelectedGameObject(null);
        
            EventSystem.current.SetSelectedGameObject(quitButton);
        }

    }
}
