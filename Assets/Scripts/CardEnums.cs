public enum CardColor {
    RED,
    GREEN,
    BLUE,
    YELLOW,
    NONE
}
public enum CardValue {
    ZERO,
    ONE,
    TWO,
    THREE,
    FOUR,
    FIVE,
    SIX,
    SEVEN,
    EIGHT,
    NINE,
    REVERSE,
    SKIP,
    DRAW_TWO,
    DRAW_FOUR
}
public class Card {
    public CardColor cardColor;
    public CardValue cardValue;

    public Card(CardColor color, CardValue value) {
        cardColor = color;
        cardValue = value;
    }
}
