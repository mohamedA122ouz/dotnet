using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace supports.Models;
public class Product {

    public float Price { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
    [Key]
    public int ID { get; set; }
    public int Quantity { get; set; }

    public bool enableSize { get; set; }

    public int CompanyID { get; set; }
    [ForeignKey("CompanyID")]
    public Company? Comp { get; set; }

    public void ChangeTo(Product ob2)
    {
        this.Price = ob2.Price;
        this.Quantity = ob2.Quantity;
        this.enableSize = ob2.enableSize;
        this.CompanyID = ob2.CompanyID;
    }
}