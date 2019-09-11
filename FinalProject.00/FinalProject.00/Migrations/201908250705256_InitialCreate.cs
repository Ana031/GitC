namespace FinalProject._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EstadoCivil = c.String(),
                        RG = c.Int(nullable: false),
                        CPF_CNPJ = c.Int(nullable: false),
                        NomeFantasia = c.String(),
                        Cep = c.Int(nullable: false),
                        Endereco = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        Telefone = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
