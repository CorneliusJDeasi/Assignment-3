using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavControl : MonoBehaviour
{
    public void LoadMyScene(string name) 
    {
        SceneManager.LoadScene(name);
    }
}
