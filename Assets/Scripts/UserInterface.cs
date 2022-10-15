using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public delegate void UpdateCoinsUI();
public delegate void ShowLoseWindow();
public delegate void ShowWinWindow();
public class UserInterface : MonoBehaviour
{
	[SerializeField] private TextMeshProUGUI coinsText;
	[SerializeField] private GameObject loseWindow;
	[SerializeField] private GameObject winWindow;

    public static UpdateCoinsUI updateCoinsUI;
	public static ShowLoseWindow showLoseWindow;
	public static ShowWinWindow showWinWindow;
	
    private int coins;

	private void Start()
	{
		updateCoinsUI += UpdateCoinsUI;
		showLoseWindow += ShowLoseWindow;
		showWinWindow += ShowWinWindow;
	}

	private void OnDestroy()
	{
		updateCoinsUI -= UpdateCoinsUI;
		showLoseWindow -= ShowLoseWindow;
		showWinWindow -= ShowWinWindow;
	}

	private void UpdateCoinsUI()
	{
		coins += 1;
		coinsText.text = coins.ToString();
	}

	private void ShowLoseWindow()
	{
		loseWindow.SetActive(true);
	}

	private void ShowWinWindow()
	{
		winWindow.SetActive(true);
	}

	public void RestartGameButton()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
