using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager I;
    public GameObject errorW;
    public GameObject errorD;

    //public GameObject banlance;
    //public GameObject currentMoney;
    public Text currentMoney;
    public Text banlance;

    private void Awake()
    {
        if (I != null)
        {
            Destroy(gameObject);
            return;
        }
        I = this;
        DontDestroyOnLoad(gameObject);
    }

    public void gameOverW()
    {
        errorW.SetActive(true);
    }

    public void ReturnW()
    {
        errorW.SetActive(false);
    }

    public void gameOverD()
    {
        errorD.SetActive(true);
    }

    public void ReturnD()
    {
        errorD.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
