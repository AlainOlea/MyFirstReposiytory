


public class User {

    private int Id;
    private string Name;
    private string Surname;
    private string UserName;
    private string Email;
    private string Password;

    public User(int id, string name, string surname, string userName, string email, string password)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.UserName = userName;
        this.Email = email;
        this.Password = password;
    }
}

public class Product 
{
    private int Id;
    private string Description;
    private int Cost;
    private double SellingPrice;
    private int Stock;
    private int UserId;
    public Product(int id, string description, int cost, double sellingPrice, int stock, int userId)
    {
        this.Id = id;
        this.Description = description;
        this.Cost = cost;
        this.SellingPrice = sellingPrice;
        this.Stock = stock;
        this.UserId = userId;
    }
}

public class SoldProduct
{
    private int Id;
    private int ProductId;
    private int Stock;
    private int IdVenta;

    public SoldProduct(int id, int productId, int stock, int idVenta)
    {
        this.Id = id;
        this.ProductId = productId;
        this.Stock = stock;
        this.IdVenta = idVenta;
    }
}

public class Venta
{
    private int VentaId;
    private string Comments;


    public Venta(int ventaId, string comments)
    {
        this.VentaId = ventaId;
        this.Comments = comments;
    }
}
