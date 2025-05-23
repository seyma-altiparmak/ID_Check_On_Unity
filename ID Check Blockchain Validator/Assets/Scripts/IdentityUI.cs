using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IdentityUI : MonoBehaviour
{
    public TMP_InputField addressInput;
    public TextMeshProUGUI resultText;
    public Web3Manager web3Manager;

    public async void OnCheckIdentity()
    {
        string address = addressInput.text;
        string identity = await web3Manager.GetIdentity(address);

        if (string.IsNullOrEmpty(identity))
            resultText.text = "PLEASE ENTER YOUR OWN ADRESS";
        else
            resultText.text = "IDENTITY: " + identity;
    }
}
