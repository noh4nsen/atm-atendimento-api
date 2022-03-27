using Atm.Atendimento.Api.Features.Orçamentos.Commands.InserirOrcamentoFeature;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Atm.Atendimento.Api.Features.Orçamentos
{
    [Route("orcamento")]
    [ApiController]
    public class OrcamentoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrcamentoController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] InserirOrcamentoCommand request)
        {
            return Ok(await _mediator.Send(request));
        }
    }
}
