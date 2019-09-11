namespace FinalProjectWEBAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAndAlter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradors",
                c => new
                    {
                        IdAdm = c.Int(nullable: false, identity: true),
                        CodAdm = c.Int(nullable: false),
                        NomeAdm = c.String(),
                        EmailAdm = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdAdm);
            
            CreateTable(
                "dbo.Cors",
                c => new
                    {
                        IdCor = c.Int(nullable: false, identity: true),
                        CodCor = c.Int(nullable: false),
                        Descricao = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCor);
            
            CreateTable(
                "dbo.Locacaos",
                c => new
                    {
                        IdLocacao = c.Int(nullable: false, identity: true),
                        CodLocacao = c.Int(nullable: false),
                        AceitaTermodeUso = c.Boolean(nullable: false),
                        TipoVeiculoFK = c.Int(),
                        MarcaFK = c.Int(nullable: false),
                        ModeloFK = c.Int(nullable: false),
                        CorFK = c.Int(nullable: false),
                        Placa = c.String(),
                        PeriodoFK = c.Int(),
                        UsuarioFK = c.Int(),
                        Status = c.String(),
                        TermoDeUsoFK = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdLocacao)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioFK)
                .ForeignKey("dbo.Cors", t => t.CorFK, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.MarcaFK, cascadeDelete: true)
                .ForeignKey("dbo.Modeloes", t => t.ModeloFK, cascadeDelete: true)
                .ForeignKey("dbo.Periodoes", t => t.PeriodoFK)
                .ForeignKey("dbo.TermoDeUsoes", t => t.TermoDeUsoFK, cascadeDelete: true)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculoFK)
                .Index(t => t.TipoVeiculoFK)
                .Index(t => t.MarcaFK)
                .Index(t => t.ModeloFK)
                .Index(t => t.CorFK)
                .Index(t => t.PeriodoFK)
                .Index(t => t.UsuarioFK)
                .Index(t => t.TermoDeUsoFK);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        IdUsuario = c.Int(nullable: false, identity: true),
                        CodUsuario = c.Int(nullable: false),
                        NomeUsuario = c.String(),
                        EmailUsuario = c.String(),
                        PCD = c.Boolean(nullable: false),
                        Idoso = c.Boolean(nullable: false),
                        PeriodoNoturno = c.Boolean(nullable: false),
                        ForaDaCidade = c.Boolean(nullable: false),
                        Carona = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUsuario);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        IdMarca = c.Int(nullable: false, identity: true),
                        CodMarcas = c.Int(nullable: false),
                        Descricao = c.String(),
                        TipoVeiculoFK = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdMarca)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculoFK)
                .Index(t => t.TipoVeiculoFK);
            
            CreateTable(
                "dbo.TipoVeiculoes",
                c => new
                    {
                        IdVeiculo = c.Int(nullable: false, identity: true),
                        CodVeiculo = c.Int(nullable: false),
                        Descricao = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdVeiculo);
            
            CreateTable(
                "dbo.Modeloes",
                c => new
                    {
                        IdModelo = c.Int(nullable: false, identity: true),
                        CodModelo = c.Int(nullable: false),
                        Descricao = c.String(),
                        MarcaFK = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdModelo)
                .ForeignKey("dbo.Marcas", t => t.MarcaFK)
                .Index(t => t.MarcaFK);
            
            CreateTable(
                "dbo.Periodoes",
                c => new
                    {
                        IdPeriodo = c.Int(nullable: false, identity: true),
                        CodPeriodo = c.Int(nullable: false),
                        QtdDeVagas = c.Int(nullable: false),
                        DatInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        TipoVeiculoFK = c.Int(),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPeriodo)
                .ForeignKey("dbo.TipoVeiculoes", t => t.TipoVeiculoFK)
                .Index(t => t.TipoVeiculoFK);
            
            CreateTable(
                "dbo.TermoDeUsoes",
                c => new
                    {
                        IdTermo = c.Int(nullable: false, identity: true),
                        CodTermo = c.Int(nullable: false),
                        Descricao = c.String(),
                        Vigente = c.Boolean(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        UsuarioCriacao = c.Int(nullable: false),
                        UsuarioAlteracao = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdTermo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locacaos", "TipoVeiculoFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "TermoDeUsoFK", "dbo.TermoDeUsoes");
            DropForeignKey("dbo.Locacaos", "PeriodoFK", "dbo.Periodoes");
            DropForeignKey("dbo.Periodoes", "TipoVeiculoFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "ModeloFK", "dbo.Modeloes");
            DropForeignKey("dbo.Modeloes", "MarcaFK", "dbo.Marcas");
            DropForeignKey("dbo.Locacaos", "MarcaFK", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "TipoVeiculoFK", "dbo.TipoVeiculoes");
            DropForeignKey("dbo.Locacaos", "CorFK", "dbo.Cors");
            DropForeignKey("dbo.Locacaos", "UsuarioFK", "dbo.Usuarios");
            DropIndex("dbo.Periodoes", new[] { "TipoVeiculoFK" });
            DropIndex("dbo.Modeloes", new[] { "MarcaFK" });
            DropIndex("dbo.Marcas", new[] { "TipoVeiculoFK" });
            DropIndex("dbo.Locacaos", new[] { "TermoDeUsoFK" });
            DropIndex("dbo.Locacaos", new[] { "UsuarioFK" });
            DropIndex("dbo.Locacaos", new[] { "PeriodoFK" });
            DropIndex("dbo.Locacaos", new[] { "CorFK" });
            DropIndex("dbo.Locacaos", new[] { "ModeloFK" });
            DropIndex("dbo.Locacaos", new[] { "MarcaFK" });
            DropIndex("dbo.Locacaos", new[] { "TipoVeiculoFK" });
            DropTable("dbo.TermoDeUsoes");
            DropTable("dbo.Periodoes");
            DropTable("dbo.Modeloes");
            DropTable("dbo.TipoVeiculoes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Locacaos");
            DropTable("dbo.Cors");
            DropTable("dbo.Administradors");
        }
    }
}
