using TMPro;
using UnityEngine;

public class Score : MonoBehaviour 
{
    public TextMeshProUGUI mytextmesh;



    
    private void Update()
    {

        mytextmesh.text ="Your name " +  PlayerPrefs.GetString("name2");
        Debug.Log("Is working");
    }

}
