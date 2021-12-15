using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArch.Infra.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "Values('Livro Código Limpo','450 folhas',99.00, 35,'livroCodLimpo.png',1)");

            mb.Sql("Insert into Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "Values('Notebook','Dell',9980.00, 20, 'noteDell.png',2)");

            mb.Sql("Insert into Products(Name, Description, Price, Stock, Image, CategoryId)" +
                "Values('Mochila','Mochila Dell',280.00, 20, 'mochilaDell.png',3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Products");
        }
    }
}
