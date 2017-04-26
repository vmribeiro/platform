using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using StoreDBEF;

namespace StoreDBEF.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    [Migration("20170426143633_createEndereco")]
    partial class createEndereco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StoreDBEF.Entidades.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Estado");

                    b.Property<int>("InfoUsuarioId");

                    b.Property<string>("Rua");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("StoreDBEF.Entidades.InfoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Nome");

                    b.Property<string>("Rg");

                    b.Property<string>("Sobrenome");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("StoreDBEF.Entidades.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("InfoUsuarioId");

                    b.Property<string>("Numero");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("StoreDBEF.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int>("InfoUsuarioId");

                    b.Property<string>("Senha");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("StoreDBEF.Entidades.Endereco", b =>
                {
                    b.HasOne("StoreDBEF.Entidades.InfoUsuario")
                        .WithMany()
                        .HasForeignKey("InfoUsuarioId");
                });

            modelBuilder.Entity("StoreDBEF.Entidades.InfoUsuario", b =>
                {
                    b.HasOne("StoreDBEF.Entidades.Usuario")
                        .WithOne()
                        .HasForeignKey("StoreDBEF.Entidades.InfoUsuario", "UsuarioId");
                });

            modelBuilder.Entity("StoreDBEF.Entidades.Telefone", b =>
                {
                    b.HasOne("StoreDBEF.Entidades.InfoUsuario")
                        .WithMany()
                        .HasForeignKey("InfoUsuarioId");
                });
        }
    }
}
