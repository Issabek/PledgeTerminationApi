//using Moq;
//using MediatR;
//using AutoMapper;
//using OtbasyBank.Api.Models;
//using System.Threading.Tasks;
//using System.Collections.Generic;
//using Microsoft.Extensions.Logging;
//using OtbasyBank.Api.Models.Replies;
//using OtbasyBank.Application.Queries;
//using OtbasyBank.Api.Controllers.Test;


//using Xunit;

//namespace OtbasyBank.IntegrationTests
//{
//    public class DefaultWeatherIntegrationTest
//    {
//        private readonly Mock<IMediator> _mockMediator;
//        private readonly Mock<ILogger<WeatherController>> _mockLogger;
//        private readonly Mock<IMapper> _mockMapper;

//        public DefaultWeatherIntegrationTest()
//        {
//            _mockLogger = new Mock<ILogger<WeatherController>>();
//            _mockMediator = new Mock<IMediator>();
//            _mockMapper = new Mock<IMapper>();
//        }

//        [Fact]
//        public async Task RetrieveWeather_NotEmpty()
//        {
//            var query = new RetrieveWeatherInfoQuery();
//            var reply = await _mockMediator.Object.Send(query);
//            var mappedReply = _mockMapper.Object.Map<GenericReply<IEnumerable<WeatherForecast>>>(reply);
//            Assert.NotEmpty(mappedReply.Data);
//        }

//        [Fact]
//        public async Task RetrieveWeather_NotNull()
//        {
//            var query = new RetrieveWeatherInfoQuery();
//            var reply = await _mockMediator.Object.Send(query);
//            var mappedReply = _mockMapper.Object.Map<GenericReply<IEnumerable<WeatherForecast>>>(reply);
//            Assert.NotNull(mappedReply);
//        }

//        [Fact]
//        public async Task RetrieveWeather_IsSuccess()
//        {
//            var query = new RetrieveWeatherInfoQuery();
//            var reply = await _mockMediator.Object.Send(query);
//            var mappedReply = _mockMapper.Object.Map<GenericReply<IEnumerable<WeatherForecast>>>(reply);
//            Assert.True(mappedReply.IsSuccess);
//        }
//    }
//}