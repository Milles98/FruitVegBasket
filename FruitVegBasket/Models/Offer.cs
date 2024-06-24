namespace FruitVegBasket.Models;

public class Offer
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public Color BgColor { get; set; }

    public Offer(string title, string description, Color bgColor, string code)
    {
        Title = title;
        Description = description;
        Code = code;
        BgColor = bgColor;
    }
}