using UnityEngine;
using UnityEngine.UI;

public class AnimatedCassetera : MonoBehaviour
{
    SpriteRenderer SpriteRenderer => gameObject.GetComponent<SpriteRenderer>();
    Image image => gameObject.GetComponent<Image>();

    private void FixedUpdate()
    {
        image.sprite = SpriteRenderer.sprite;
    }

}