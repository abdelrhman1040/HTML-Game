using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class discord : MonoBehaviour
{
    public string Message;
    public string Subject;
   // public GameObject message;
    //public GameObject subject;
    string webhook_link = "https://discord.com/api/webhooks/1168242308349698179/eek4tFU3e2yev_q73sCf1xvKlNe-VVAOdfRlWj_40-0cBAedkE9ooa2SVB1IiO1f8Tjg";

    public void Store()
    {
      //  Message = message.GetComponent<Text>().text;
      //  Subject = subject.GetComponent<Text>().text;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Msg();
        }
    }

    private void Start()
    {
       
    }

    public void Msg()
    {
        StartCoroutine(SendWebhook(webhook_link,  Message, (success) =>
       {
         //  if (success)

       }));

        IEnumerator SendWebhook(string link, string message, System.Action<bool> action)
        {
            WWWForm form = new WWWForm(); form.AddField("content", message); using (UnityWebRequest www = UnityWebRequest.Post(link, form))
            {
                yield return www.SendWebRequest();

                if (www.isNetworkError || www.isHttpError)
                {
                    Debug.Log(www.error);
                    action(false);
                }
                else
                    action(true);
            }
        }
    }
}
