using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SavePlayerPos : MonoBehaviour
{
    public GameObject Player;
    public string SceneName;
    private float Px;
    private float Py;
    private void Start()
    {       
       
    }
    public void save()
    {
        ;
        SceneName = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("LevelNAme", SceneName);
        PlayerPrefs.Save();

    }
    public void load()
    {
       
        
        SceneName = PlayerPrefs.GetString("LevelNAme", SceneName);
        SceneManager.LoadScene(SceneName);
        PlayerPrefs.Save();



    }

    public void Reset()
    {
        SceneManager.LoadScene("Piso 1");
    }

}
