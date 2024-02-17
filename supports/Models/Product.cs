namespace supports.Models;
public class Product {

    public float Price { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int ID { get; set; }
    public int Quantity { get; set; }

    public bool enableSize { get; set; }

    public Company Comp { get; set; }
}