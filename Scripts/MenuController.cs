using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    private int volume; 

    void Start()
    {
        this.loadPrefs();
    }

    public void loadPrefs()
    {
        this.volume = PlayerPrefs.GetInt("Volume", 0);
    }

    public void saveVolume(int volume)
    {
        PlayerPrefs.SetInt("Volume", volume);
        PlayerPrefs.Save();
    }

    [SerializeField]
    private string MenuState = "none";

    [SerializeField]
    private GameObject MainPanel;

    [SerializeField]
    private GameObject OptionPanel;

    [SerializeField]
    private GameObject CreditsPanel;

    [SerializeField]
    private GameObject ExitPanel;

    [SerializeField]
    private GameObject CurrentPanel;

    [SerializeField]
    private GameObject PreviousPanel;


    public void setState(string state)
    {
        this.MenuState = state;


        switch (state)
        {
            case "none":

                //CurrentPanel = MainPanel;
                MainPanel.SetActive(true);

                break;

            case "start":

                SceneManager.LoadScene(1);

                break;

            case "settings":

                PreviousPanel = CurrentPanel;
                PreviousPanel.SetActive(false);
                CurrentPanel = OptionPanel;
                OptionPanel.SetActive(true);                             
                
                break;

            case "credits":

                PreviousPanel = CurrentPanel;
                PreviousPanel.SetActive(false);
                CurrentPanel = CreditsPanel;
                CreditsPanel.SetActive(true);

                break;

            case "exit":

                MainPanel.SetActive(false);
                ExitPanel.SetActive(true);

                break;


            case "back":

                CurrentPanel.SetActive(false);
                CurrentPanel = PreviousPanel;
                CurrentPanel.SetActive(true);

                break;


            default:
                break;
        }


    }

    public void endGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false; 
    }


   

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
