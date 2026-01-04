using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuUI : Name
{
    public TMP_InputField TMP_InputField;
    public TextMeshProUGUI textmesh;
    public string nameBYInputField;
    public MenuUI(string yopurName) : base(yopurName)
    {
        
    }

    private void Update()
    {
        if(TMP_InputField.text != "")
        {
             nameBYInputField = TMP_InputField.text;
            PlayerPrefs.SetString("name2", nameBYInputField);
            SetName(nameBYInputField);
            PlayerPrefs.Save();

            textmesh.text = "Your name : "+ GetName() + "Your Score" + PlayerPrefs.GetFloat("scoreBoard");
            
        }

        else
        {
            textmesh.text = "Your Score / Your Name";
        }
         
    }




    public void StartNewScene()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
       Application.Quit();


    }




}
