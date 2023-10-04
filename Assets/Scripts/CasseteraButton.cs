using UnityEngine;
using UnityEngine.UI;

public class CasseteraButton : MonoBehaviour
{
    [SerializeField] private Cassetera cassetera;
    Button playButton => GetComponent<Button>();

    private void Awake()
    {
        playButton.onClick.AddListener(cassetera.PressPlay);
    }
}