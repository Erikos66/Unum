using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {
    [Header("Colours")]
    [SerializeField] Color32 red = new(255, 0, 0, 255);
    [SerializeField] Color32 green = new(0, 255, 0, 255);
    [SerializeField] Color32 blue = new(0, 0, 255, 255);
    [SerializeField] Color32 yellow = new(255, 255, 0, 255);
    [SerializeField] Color32 black = new(0, 0, 0, 255);
    [Header("Sprites")]
    [SerializeField] private Sprite reverse; // Sprite for reverse card
    [SerializeField] private Sprite skip; // Sprite for skip card
    [SerializeField] private Sprite drawTwo; // Sprite for draw two card
    [SerializeField] private Sprite drawFour; // Sprite for draw four card
    [Header("Card Components")]
    [SerializeField] private Image cardColor; // Image for the card
    [SerializeField] private Image cardBack; // Image for the back of the card
    [Header("Center Images")]
    [SerializeField] private TMP_Text textCenter; // Text for the center of the card
    [SerializeField] private GameObject imageCenter; // Image for the center of the card
    [SerializeField] private GameObject wildImageCenter; // Wild image for the center of the card
    [SerializeField] private Image C_TLC; // Top left corner of the wild image (RED)
    [SerializeField] private Image C_TRC; // Top right corner of the wild image (GREEN)
    [SerializeField] private Image C_BLC; // Bottom left corner of the wild image (BLUE)
    [SerializeField] private Image C_BRC; // Bottom right corner of the wild image (YELLOW)
    [Header("Top Left Corner")]
    [SerializeField] private TMP_Text textTopLeft; // Text for the top left corner of the card
    [SerializeField] private Image imageTopLeft; // Image for the top left corner of the card
    [SerializeField] private GameObject wildImageTopLeft; // Wild image for the top left corner of the card
    [SerializeField] private Image TL_TLC; // Top left corner of the wild image (RED)
    [SerializeField] private Image TL_TRC; // Top right corner of the wild image (GREEN)
    [SerializeField] private Image TL_BLC; // Bottom left corner of the wild image (BLUE)
    [SerializeField] private Image TL_BRC; // Bottom right corner of the wild image (YELLOW)
    [Header("Bottom Right Corner")]
    [SerializeField] private TMP_Text textBottomRight; // Text for the bottom right corner of the card
    [SerializeField] private GameObject imageBottomRight; // Image for the bottom right corner of the card
    [SerializeField] private GameObject wildImageBottomRight; // Wild image for the bottom right corner of the card
    [SerializeField] private Image BR_TLC; // Top left corner of the wild image (RED)
    [SerializeField] private Image BR_TRC; // Top right corner of the wild image (GREEN)
    [SerializeField] private Image BR_BLC; // Bottom left corner of the wild image (BLUE)
    [SerializeField] private Image BR_BRC; // Bottom right corner of the wild image (YELLOW)

    void SetColor(CardColor cardColor) {
        switch (cardColor) {
            case CardColor.RED:
                this.cardColor.color = red;
                break;
            case CardColor.GREEN:
                this.cardColor.color = green;
                break;
            case CardColor.BLUE:
                this.cardColor.color = blue;
                break;
            case CardColor.YELLOW:
                this.cardColor.color = yellow;
                break;
            case CardColor.NONE:
                this.cardColor.color = black;
                break;
        }
    }
    void SetNumber(CardValue cardValue) {
        switch (cardValue) {
            case CardValue.ZERO:
                textCenter.text = "0";
                break;
            case CardValue.ONE:
                textCenter.text = "1";
                break;
            case CardValue.TWO:
                textCenter.text = "2";
                break;
            case CardValue.THREE:
                textCenter.text = "3";
                break;
            case CardValue.FOUR:
                textCenter.text = "4";
                break;
            case CardValue.FIVE:
                textCenter.text = "5";
                break;
            case CardValue.SIX:
                textCenter.text = "6";
                break;
            case CardValue.SEVEN:
                textCenter.text = "7";
                break;
            case CardValue.EIGHT:
                textCenter.text = "8";
                break;
            case CardValue.NINE:
                textCenter.text = "9";
                break;
            case CardValue.REVERSE:
                imageCenter.SetActive(true);
                imageCenter.GetComponent<Image>().sprite = reverse;
                break;
            case CardValue.SKIP:
                imageCenter.SetActive(true);
                imageCenter.GetComponent<Image>().sprite = skip;
                break;
            case CardValue.DRAW_TWO:
                imageCenter.SetActive(true);
                imageCenter.GetComponent<Image>().sprite = drawTwo;
                break;
            case CardValue.DRAW_FOUR:
                wildImageCenter.SetActive(true);
                C_TLC.color = red;
                C_TRC.color = green;
                C_BLC.color = blue;
                C_BRC.color = yellow;
                break;
        }
    }
}
