using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Save : MonoBehaviour
{
    public KeyCode saveKey;
    public GameObject winScreen;
    public TextMeshProUGUI winText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        winScreen.SetActive(false);

        int randomLetter = Random.Range(0, 26);
        saveKey = KeyCode.A + randomLetter;

        if (winText != null )
        {
            winText.text = "Press " + saveKey.ToString() + " to save yourself";        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(saveKey))
        {
            winScreen.SetActive(true);
        }
    }
}
