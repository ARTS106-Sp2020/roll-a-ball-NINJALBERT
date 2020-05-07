using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator infoDialog;

    public void StartGame() 
    {
    	SceneManager.LoadScene("Roll-a-ball");
    }

    public void Quit()
    {
	Application.Quit();
    }

    public void OpenInfo()
    {
	startButton.SetBool("isHidden", false);
	infoDialog.SetBool("isHidden", false);
    }

    public void CloseInfo()
    {
	startButton.SetBool("isHidden", true);
	infoDialog.SetBool("isHidden", true);
    }

}
