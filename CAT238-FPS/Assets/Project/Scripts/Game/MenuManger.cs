using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManger : MonoBehaviour
{
    public void Onplay() 
    {
        SceneManager.LoadScene("Level1");
    }
}
