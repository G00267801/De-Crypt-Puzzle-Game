using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl2 : MonoBehaviour
{
    [SerializeField]
    private Transform[] SLS_Rocket;

    [SerializeField]
    private GameObject winText;

    public static bool youWin;

    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (SLS_Rocket[0].rotation.z == 0 &&
           SLS_Rocket[1].rotation.z == 0 &&
           SLS_Rocket[2].rotation.z == 0 &&
            SLS_Rocket[3].rotation.z == 0 &&
           SLS_Rocket[4].rotation.z == 0 &&
            SLS_Rocket[5].rotation.z == 0)
        {
            youWin = true;
            winText.SetActive(true);
        }

    }
}

