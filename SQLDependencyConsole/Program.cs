using TableDependency.SqlClient;
using TableDependency.SqlClient.Base.Enums;
using Barmate.Models;
using TableDependency.SqlClient.Base.EventArgs;
using System.Data.SqlClient;


//ref https://www.youtube.com/watch?v=D-ohwsutnPs

string connectionString = "Server=DINAND-NB\\SQLEXPRESS;Database=Barmate;Trusted_Connection=True;MultipleActiveResultSets=true";

using (var tbDependency = new SqlTableDependency<Product>(connectionString))
{
    tbDependency.OnChanged += tbDependency_OnChanged;
    tbDependency.Start();
    Console.ReadKey();

}
Console.WriteLine("Hello, World!");


static void tbDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<Product> e )
{
    var entry = e.Entity;
    Console.WriteLine("Type: " + e.ChangeType);
    Console.WriteLine("Name"+ entry.Name);
    Console.WriteLine("Description"+ entry.Description);
    Console.WriteLine("Price" + entry.Price);
    Console.WriteLine("TakeawayPrice" + entry.TakeAwayPrice);
    Console.WriteLine("Active" + entry.VatPercentage);
}