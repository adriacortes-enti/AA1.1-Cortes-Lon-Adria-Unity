using UnityEngine;
using TMPro;

public class E40 : MonoBehaviour
{
    public TextMeshProUGUI Text;
    int counter;
    public void ClickedButton()
    {
        counter++;
        Text.text = counter.ToString();
    }
}
