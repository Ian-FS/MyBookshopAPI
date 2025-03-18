namespace MyBookshopAPI;

public class Book {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string[] Gender { get; set; } = [];
    public string Price {  get; set; } = string.Empty;
    public int Quantity { get; set; }
}
