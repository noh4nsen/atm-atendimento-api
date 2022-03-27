﻿// <auto-generated />
using System;
using Atm.Atendimento.Dados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Atm.Atendimento.Dados.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20220327033753_DbCreate")]
    partial class DbCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Atm.Atendimento.Domain.CustoServico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid?>("OrcamentoId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ServicoId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrcamentoId");

                    b.HasIndex("ServicoId");

                    b.ToTable("CustoServico");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.ModoPagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<bool>("CartaoCredito")
                        .HasColumnType("boolean");

                    b.Property<bool>("CartaoDebito")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Dinheiro")
                        .HasColumnType("boolean");

                    b.Property<bool>("Pix")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ModoPagamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Orcamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("CarroId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DataAgendamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataHoraFim")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DataHoraInicio")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<double?>("Duracao")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("PagamentoId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PagamentoId");

                    b.ToTable("Orcamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal?>("Desconto")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("ModoPagamentoId")
                        .HasColumnType("uuid");

                    b.Property<bool>("PagamentoEfetuado")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("Percentual")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorFinal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ModoPagamentoId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Peca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Descricao")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<Guid?>("OrcamentoId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("ValorCobrado")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrcamentoId");

                    b.ToTable("Peca");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Servico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("CustoServicoAtual")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal?>("ValorAtual")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("Atm.Atendimento.Dto.CarroOrcamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdExterno")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("CarroOrcamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Dto.ClienteOrcamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdExterno")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ClienteOrcamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Dto.ProdutoOrcamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("IdExterno")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("OrcamentoId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Percentual")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("OrcamentoId");

                    b.ToTable("ProdutoOrcamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.CustoServico", b =>
                {
                    b.HasOne("Atm.Atendimento.Domain.Orcamento", "Orcamento")
                        .WithMany("CustoServicos")
                        .HasForeignKey("OrcamentoId");

                    b.HasOne("Atm.Atendimento.Domain.Servico", "Servico")
                        .WithMany("CustoServico")
                        .HasForeignKey("ServicoId");

                    b.Navigation("Orcamento");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Orcamento", b =>
                {
                    b.HasOne("Atm.Atendimento.Dto.CarroOrcamento", "Carro")
                        .WithMany()
                        .HasForeignKey("CarroId");

                    b.HasOne("Atm.Atendimento.Dto.ClienteOrcamento", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Atm.Atendimento.Domain.Pagamento", "Pagamento")
                        .WithMany()
                        .HasForeignKey("PagamentoId");

                    b.Navigation("Carro");

                    b.Navigation("Cliente");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Pagamento", b =>
                {
                    b.HasOne("Atm.Atendimento.Domain.ModoPagamento", "ModoPagamento")
                        .WithMany()
                        .HasForeignKey("ModoPagamentoId");

                    b.Navigation("ModoPagamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Peca", b =>
                {
                    b.HasOne("Atm.Atendimento.Domain.Orcamento", "Orcamento")
                        .WithMany("Pecas")
                        .HasForeignKey("OrcamentoId");

                    b.Navigation("Orcamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Dto.ProdutoOrcamento", b =>
                {
                    b.HasOne("Atm.Atendimento.Domain.Orcamento", "Orcamento")
                        .WithMany("Produtos")
                        .HasForeignKey("OrcamentoId");

                    b.Navigation("Orcamento");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Orcamento", b =>
                {
                    b.Navigation("CustoServicos");

                    b.Navigation("Pecas");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Atm.Atendimento.Domain.Servico", b =>
                {
                    b.Navigation("CustoServico");
                });
#pragma warning restore 612, 618
        }
    }
}
