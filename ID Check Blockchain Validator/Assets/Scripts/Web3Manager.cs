using UnityEngine;
using Nethereum.Web3;
using System.Threading.Tasks;

public class Web3Manager : MonoBehaviour
{
    private string url = "https://sepolia.infura.io/v3/https://sepolia.infura.io/v3/0d1c2ab3f6f34b129b8ac13b0e8c99a1";
    //Permission need here... enter your own addresses please. Personel ETH contracts :)
    private string contractAddress = "0xCA9fC26D4288b4142F5da88E1dd3FB9088fbBDc8";

    private string abi = @"[
        {
            ""inputs"": [
                {
                    ""internalType"": ""address"",
                    ""name"": ""user"",
                    ""type"": ""address""
                }
            ],
            ""name"": ""getIdentity"",
            ""outputs"": [
                {
                    ""internalType"": ""string"",
                    ""name"": """",
                    ""type"": ""string""
                }
            ],
            ""stateMutability"": ""view"",
            ""type"": ""function""
        },
        {
            ""inputs"": [
                {
                    ""internalType"": ""string"",
                    ""name"": ""name"",
                    ""type"": ""string""
                }
            ],
            ""name"": ""register"",
            ""outputs"": [],
            ""stateMutability"": ""nonpayable"",
            ""type"": ""function""
        },
        {
            ""inputs"": [
                {
                    ""internalType"": ""address"",
                    ""name"": """",
                    ""type"": ""address""
                }
            ],
            ""name"": ""users"",
            ""outputs"": [
                {
                    ""internalType"": ""string"",
                    ""name"": """",
                    ""type"": ""string""
                }
            ],
            ""stateMutability"": ""view"",
            ""type"": ""function""
        }
    ]";

    private Web3 web3;

    void Start()
    {
        web3 = new Web3(url);
    }

    public async Task<string> GetIdentity(string address)
    {
        var contract = web3.Eth.GetContract(abi, contractAddress);
        var func = contract.GetFunction("getIdentity");
        return await func.CallAsync<string>(address);
    }
}
