using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {
    [Header("Colours")]
    [SerializeField] Color32 red = new(255, 0, 0, 255);
    [SerializeField] Color32 green = new(0, 255, 0, 255);
    [SerializeField] Color32 blue = new(0, 0, 255, 255);
    [SerializeField] Color32 yellow = new(255, 255, 0, 255);
    [Header("Sprites")]
    [SerializeField] private Sprite reverse; // Sprite for reverse card
    [SerializeField] private Sprite skip; // Sprite for skip card
    [SerializeField] private Sprite drawTwo; // Sprite for draw two card
    [SerializeField] private Sprite drawFour; // Sprite for draw four card
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
}
