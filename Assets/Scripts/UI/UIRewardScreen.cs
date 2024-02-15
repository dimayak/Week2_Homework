using UnityEngine;
using TMPro;

public class UIRewardScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _coinText;
    private string _coinsTextOriginal;

    private void Awake()
    {
        _coinsTextOriginal = _coinText.text;
    }

    public void SetCoinsCount(int count)
    {
        _coinText.text = _coinsTextOriginal.Replace("{count}", count.ToString());
    }
}
