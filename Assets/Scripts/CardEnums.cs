public enum DepriciatedCardColor {
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
public class DepriceiatedCard {
    public CardColor cardColor;
    public CardValue cardValue;

    public DepriceiatedCard(CardColor color, CardValue value) {
        cardColor = color;
        cardValue = value;
    }
}
