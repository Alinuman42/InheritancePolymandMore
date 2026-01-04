using UnityEngine;

public class Name : MonoBehaviour
{
    private string yourName;

    public Name(string yourName)
    {
        this.yourName = yourName;
    }

    public void SetName(string yourName)
    {
        this.yourName = yourName;
    }

    public string GetName()
    {
        return yourName;
    }



    private void Update()
    {
        
    }


    
}
