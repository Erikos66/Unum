using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum CardType { Number, Skip, Reverse, DrawTwo, Wild, WildDrawFour, DrawFour }
public enum CardColor { Red, Blue, Green, Yellow, Wild }

public class Card : MonoBehaviour {
    public CardType Type;
    public CardColor Color;
    public int Number; // Only used for number cards

    // Changed from a single Image to an array for multiple backgrounds
    public Image[] CardColorThemes; // Multiple card backgrounds
    public Image[] CardIcons; // If using special card icons
    public TMP_Text[] NumberTexts; // 3 number text elements

    public Sprite[] SpecialCardSprites; // Assign sprites for special cards (Skip, Reverse, Draw Two, etc.)

    public void Initialize(CardType type, CardColor color, int number = -1) {
        Type = type;
        Color = color;
        Number = number;

        UpdateCardVisuals();
    }

    private void UpdateCardVisuals() {
        // Set background colors for all card color themes
        Color bgColor = GetColorFromEnum(Color);
        if (CardColorThemes != null) {
            foreach (var theme in CardColorThemes) {
                if (theme != null) {
                    theme.color = bgColor;
                }
            }
        }

        // Update text for number cards
        if (NumberTexts != null) {
            if (Type == CardType.Number) {
                foreach (var text in NumberTexts) {
                    if (text != null) {
                        text.text = Number.ToString();
                        text.enabled = true;
                    }
                }
            }
            else {
                foreach (var text in NumberTexts) {
                    if (text != null) {
                        text.enabled = false; // Hide numbers for special cards
                    }
                }
            }
        }

        // Set special card icons if applicable
        if (CardIcons != null) {
            if (Type != CardType.Number) {
                Sprite specialSprite = GetSpecialCardSprite(Type);
                foreach (var icon in CardIcons) {
                    if (icon != null) {
                        icon.sprite = specialSprite;
                        icon.enabled = true;
                    }
                }
            }
            else {
                foreach (var icon in CardIcons) {
                    if (icon != null) {
                        icon.enabled = false; // Hide special card icons for number cards
                    }
                }
            }
        }
    }

    // Added to update visuals when properties change in the editor
    private void OnValidate() {
        if (!Application.isPlaying) {
            UpdateCardVisuals();
        }
    }

    private Color GetColorFromEnum(CardColor color) {
        return color switch {
            CardColor.Red => UnityEngine.Color.red,
            CardColor.Blue => UnityEngine.Color.blue,
            CardColor.Green => UnityEngine.Color.green,
            CardColor.Yellow => UnityEngine.Color.yellow,
            _ => UnityEngine.Color.black, // Wild cards
        };
    }

    private Sprite GetSpecialCardSprite(CardType type) {
        int index = type switch {
            CardType.Skip => 0,
            CardType.Reverse => 1,
            CardType.DrawTwo => 2,
            CardType.Wild => 3,
            CardType.WildDrawFour => 4,
            CardType.DrawFour => 5,
            _ => -1,
        };
        if (index >= 0 && SpecialCardSprites != null && index < SpecialCardSprites.Length) {
            return SpecialCardSprites[index];
        }
        return null;
    }
}
