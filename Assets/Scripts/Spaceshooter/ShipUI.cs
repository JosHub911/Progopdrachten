using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;



public class ShipUI : MonoBehaviour
{
    [SerializeField] TMP_Text intro;
    [SerializeField] TMP_Text message;
    [SerializeField] Image itemImage;

    void Start() => StartCoroutine(ShowIntro());

    IEnumerator ShowIntro()
    {
        intro.enabled = true;
        intro.text = "...text here...";
        yield return new WaitForSeconds(5f);
        intro.enabled = false;
    }

    public void ShowMessage(string msg)
    {
        StartCoroutine(MessageRoutine(msg));
    }

    IEnumerator MessageRoutine(string msg)
    {
        message.enabled = true;
        message.text = msg;
        yield return new WaitForSeconds(3f);
        message.enabled = false;
    }

    public void UpdateItemUI(Color? c)
    {
        if (c == null)
        {
            itemImage.enabled = false;
        }
        else
        {
            itemImage.enabled = true;
            itemImage.color = (Color)c;
        }
    }
}
