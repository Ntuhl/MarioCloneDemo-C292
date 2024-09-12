using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    //public static UIManager instance


    private void Update()
    {
        Reset();
    }

    [SerializeField] private TextMeshProUGUI cointext;
    private int coinCount;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(instance);
        }

    }

    public void UpdateCoinText(int coinValue)
    {
        coinCount += coinValue;
        cointext.text = "x" + coinCount;
    }

    public void Reset()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
