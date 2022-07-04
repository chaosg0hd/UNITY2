using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollUp : MonoBehaviour
{
    [SerializeField]

    private GameObject CreditsPanel;

    // Start is called before the first frame update
    void Start()
    {
        CreditsPanel.transform.position = new Vector3(500, -800, 0);
        ;
    }

    // Update is called once per frame
    void Update()
    {
        CreditsPanel.transform.position = CreditsPanel.transform.position + new Vector3(0, .5f , 0);

        
    }


}
