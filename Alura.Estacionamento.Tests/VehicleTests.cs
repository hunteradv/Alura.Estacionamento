using Alura.Estacionamento.Modelos;
using System;
using Xunit;

namespace Alura.Estacionamento.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void TestVehicleAccelerate()
        {
            var vehicle = new Veiculo();
            vehicle.Acelerar(10);

            Assert.Equal(100, vehicle.VelocidadeAtual);
        }

        [Fact]
        public void TestVehicleBrake()
        {
            var vehicle = new Veiculo();
            vehicle.Frear(10);

            Assert.Equal(-150, vehicle.VelocidadeAtual);
        }
    }
}
