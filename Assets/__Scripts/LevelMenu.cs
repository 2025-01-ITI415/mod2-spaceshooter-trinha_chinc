using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    public Button[] buttons;
   

    public void Openlevel(int levelId){
        string levelName = "Level " + levelId;
        SceneManager.LoadScene(levelName);
    }
}
