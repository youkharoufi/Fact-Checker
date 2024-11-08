using FactChecker.Api.Application.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactChecker.Api.Application.UseCases
{
    public class AudioToTextUseCases(ILogger<AudioToTextUseCases> logger) : IAudioToTextUseCases
    {
        private readonly ILogger<AudioToTextUseCases> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public void CreateLog()
        {
            _logger.LogInformation("Youssef");
        }
    }

}
