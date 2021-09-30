using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Button StartButton;

    public void OnButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
