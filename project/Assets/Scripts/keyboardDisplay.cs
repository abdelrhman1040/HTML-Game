using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardDisplay : MonoBehaviour
{
    public TMP_InputField inputField;
    public InputField input;
    public string add;

    private void Start()
    {
        input.text = PlayerPrefs.GetString("myname");
    }

    private void Update()
    {
        inputField.text = input.text + add;
        PlayerPrefs.SetString("myname", input.text);
        PlayerPrefs.Save();
    }

    public void ADD()
    {
        add = "_";
    }
}