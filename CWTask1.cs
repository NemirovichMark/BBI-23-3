using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Xml.Schema;

struct Goods
{
    private string _Name;
    private string _Description;
    private double _Price;
    private string _Articul;
    public string Name => _Name;
    public string Articul => _Articul;
    public string Description => _Description;
    public string Price => _Price;
    public Goods(string name, double price)
    {
        _Name = name;
        _Description = "Для товара " + name + " описание не задано";
        _Price = price;
        _Articul = Guid.NewGuid().ToString();
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Название: " + _Name);
        Console.WriteLine("Описание: " + _Description);
        Console.WriteLine("Цена: " + _Price);
        Console.WriteLine("Артикул: " + _Articul);
        Console.WriteLine();
    }
    public void ChangeDescription(string newDescription)
    {
        if (newDescription.Length < 20 || newDescription.Length > 200)
        {
            Console.WriteLine("Описание должно быть не короче 20 символов и не длиннее 200 символов.");
        }
        else
        {
            _Description = newDescription;
            Console.WriteLine("Описание товара успешно изменено.");
        }
    }
}
class Program
{
    static void Main
    {
        Good [] goods = new goods[]
        {
            new Goods("Телефон", 100);
            new Goods("Ноутбук", 500);
            new Goods("Фотоаппарат", 300);
            new Goods("Наушники", 50);
            new Goods("Планшет", 200);
        }
        goods.Description[1] = ("Мощный ноутбук с большим экраном.");
        goods.Description[2] = ("Отличный фотоаппарат для профессиональных съемок.");
        goods.Description[3] = ("Планшет с высоким разрешением экрана.");
}

        
       Array.Sort(goods, (x, y) => x.price.CompareTo(y.price));

       Console.WriteLine("Товары:");
       Console.WriteLine("---------------------------------------------------");

      foreach (var goods in Good)
      {
         goods.DisplayInfo();
      }

    }
    
}