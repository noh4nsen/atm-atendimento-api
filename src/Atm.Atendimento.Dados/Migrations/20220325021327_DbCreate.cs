using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Atm.Atendimento.Dados.Migrations
{
    public partial class DbCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ValorAtual = table.Column<decimal>(type: "numeric", nullable: true),
                    CustoServicoAtual = table.Column<Guid>(type: "uuid", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orcamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: true),
                    CarroId = table.Column<Guid>(type: "uuid", nullable: true),
                    Descricao = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Desconto = table.Column<decimal>(type: "numeric", nullable: true),
                    ValorFinal = table.Column<decimal>(type: "numeric", nullable: false),
                    ModoPagamento = table.Column<int[]>(type: "integer[]", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DataAgendamento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DataHoraInicio = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DataHoraFim = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Duracao = table.Column<double>(type: "double precision", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orcamento_Carro_CarroId",
                        column: x => x.CarroId,
                        principalTable: "Carro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orcamento_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustoServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    ServicoId = table.Column<Guid>(type: "uuid", nullable: true),
                    OrcamentoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustoServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustoServico_Orcamento_OrcamentoId",
                        column: x => x.OrcamentoId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustoServico_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Peca",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Descricao = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ValorUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    ValorCobrado = table.Column<decimal>(type: "numeric", nullable: false),
                    OrcamentoId = table.Column<Guid>(type: "uuid", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataAtualizacao = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peca", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peca_Orcamento_OrcamentoId",
                        column: x => x.OrcamentoId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrcamentoId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Orcamento_OrcamentoId",
                        column: x => x.OrcamentoId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustoServico_OrcamentoId",
                table: "CustoServico",
                column: "OrcamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CustoServico_ServicoId",
                table: "CustoServico",
                column: "ServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_CarroId",
                table: "Orcamento",
                column: "CarroId");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_ClienteId",
                table: "Orcamento",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Peca_OrcamentoId",
                table: "Peca",
                column: "OrcamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_OrcamentoId",
                table: "Produto",
                column: "OrcamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustoServico");

            migrationBuilder.DropTable(
                name: "Peca");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Orcamento");

            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
