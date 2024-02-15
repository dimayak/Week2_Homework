using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] UIRewardScreen _rewardScreen;

    void Start()
    {
        _rewardScreen.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        CoinManager.OnAllCoinsCollected += CoinManager_OnAllCoinsCollected;
    }

    private void OnDisable()
    {
        CoinManager.OnAllCoinsCollected -= CoinManager_OnAllCoinsCollected;
    }

    private void CoinManager_OnAllCoinsCollected(int totalCoinsCount)
    {
        _rewardScreen.gameObject.SetActive(true);
        _rewardScreen.SetCoinsCount(totalCoinsCount);
    }
}
