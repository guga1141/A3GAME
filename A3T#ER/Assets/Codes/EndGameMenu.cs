using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    
    


        public void Restart()
        {
            SceneManager.LoadScene(1);

        }
        public void QuitGame()
        {
            Debug.Log("THE PLAYER HAS LEFT");

            Application.Quit();
        }

    
}
