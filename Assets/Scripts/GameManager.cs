using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject FallObject;
    public GameObject ClearCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        FallObject.SetActive(true);
    }
    public void GameClear()
    {
        ClearCanvas.SetActive(true);
        FallObject.SetActive(false);
    }
}
