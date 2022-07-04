using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

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

    public void setState(string state)
    {
        this.MenuState = state;

        switch (state)
        {
            case "none":
                MainPanel.SetActive(true);

                break;
            case "start":
                //code for scene change

                break;

            case "settings":
                MainPanel.SetActive(false);
                OptionPanel.SetActive(true);
                break;

            case "credits":
                MainPanel.SetActive(false);
                CreditsPanel.SetActive(true);
                break;

            case "exit":
                ExitPanel.SetActive(true);
                break;


            case "back":
                MainPanel.SetActive(true);
                break;


            default:
                break;
        }


    }




    //public void setStateStart()
    //{

    //    //code for scene change
    //    this.MenuState = "start";
    //}

    //public void setStateOptions()
    //{   

    //    this.MenuState = "options";
    //    this.OptionsPanel = 
    //}

    //public void setStateMain()
    //{
    //    this.MenuState = "main";
    //}

    //public void setStateStart()
    //{
    //    this.MenuState = state;
    //}

    //public void setStateStart()
    //{
    //    this.MenuState = state;
    //}

    //public void setStateStart()
    //{
    //    this.MenuState = state;
    //}

    //private void MenuManager()
    //{

    //}

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
