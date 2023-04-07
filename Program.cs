using Dapper;
using ModeleBD;
using System.Data.SqlClient;
namespace ModeleBD;
public class PozycjeZamowienia
{
    public int IDZamowienia { get; set; }
    public int IDProduktu { get; set; }
    public int Ilosc { get; set; }
}

public class Program 
{
   
    public static void Main(string[] arg )
    {
string connectionString = @"Data Source=DESKTOP-IJ0SFAF\SQLEXPRESS;Initial Catalog=Modele;Integrated Security=True";
string insertSql = "select* from PozycjeZamówienia";

using (var connection = new SqlConnection(connectionString))
{
    var pozycjeZamowienia = connection.Query<PozycjeZamowienia>(insertSql);
    foreach(var item in pozycjeZamowienia)
     {

       Console.WriteLine($"{item.IDZamowienia} {item.IDProduktu} {item.Ilosc}");

      }




}


    }


}

