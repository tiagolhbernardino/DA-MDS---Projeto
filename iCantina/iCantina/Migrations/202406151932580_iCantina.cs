namespace iCantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iCantina : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Single(nullable: false),
                        Ativo = c.String(),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Single(nullable: false),
                        DataHora = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.Cliente_Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Nif = c.String(),
                        Saldo = c.Single(),
                        NumeroEstudante = c.Int(),
                        Email = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemFaturas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Single(nullable: false),
                        Fatura_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Faturas", t => t.Fatura_Id)
                .Index(t => t.Fatura_Id);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        QdDesponivel = c.Int(nullable: false),
                        PrecoEstudante = c.Single(nullable: false),
                        PrecoProfessor = c.Single(nullable: false),
                        Extra_Id = c.Int(),
                        Prato_Id = c.Int(),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Extras", t => t.Extra_Id)
                .ForeignKey("dbo.Pratoes", t => t.Prato_Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Extra_Id)
                .Index(t => t.Prato_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.String(),
                        Ativo = c.String(),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Single(nullable: false),
                        NumeroHoras = c.DateTime(nullable: false),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.cliente_Id)
                .Index(t => t.cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pratoes", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Multas", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Menus", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Extras", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "cliente_Id", "dbo.Utilizadors");
            DropForeignKey("dbo.Faturas", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Menus", "Prato_Id", "dbo.Pratoes");
            DropForeignKey("dbo.Menus", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.ItemFaturas", "Fatura_Id", "dbo.Faturas");
            DropForeignKey("dbo.Faturas", "Cliente_Id", "dbo.Utilizadors");
            DropIndex("dbo.Reservas", new[] { "cliente_Id" });
            DropIndex("dbo.Multas", new[] { "Reserva_Id" });
            DropIndex("dbo.Pratoes", new[] { "Reserva_Id" });
            DropIndex("dbo.Menus", new[] { "Reserva_Id" });
            DropIndex("dbo.Menus", new[] { "Prato_Id" });
            DropIndex("dbo.Menus", new[] { "Extra_Id" });
            DropIndex("dbo.ItemFaturas", new[] { "Fatura_Id" });
            DropIndex("dbo.Faturas", new[] { "Menu_Id" });
            DropIndex("dbo.Faturas", new[] { "Cliente_Id" });
            DropIndex("dbo.Extras", new[] { "Reserva_Id" });
            DropTable("dbo.Reservas");
            DropTable("dbo.Multas");
            DropTable("dbo.Pratoes");
            DropTable("dbo.Menus");
            DropTable("dbo.ItemFaturas");
            DropTable("dbo.Utilizadors");
            DropTable("dbo.Faturas");
            DropTable("dbo.Extras");
        }
    }
}
