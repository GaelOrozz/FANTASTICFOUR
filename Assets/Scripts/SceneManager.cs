using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerscript : MonoBehaviour
{
 public void LoadScene(string Landscape)
    {
        SceneManager.LoadScene(Landscape);
    }
}
