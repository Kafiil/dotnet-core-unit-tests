using System;
using PrimeServices;
using Xunit;

namespace PrimeServiceTests
{
    public class PrimeServiceTests
    {
        private PrimeService _primeService;
        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(-1)]
        public void Should_return_false_for_values_less_than_2(int value)
        {
            //Given
            var candidate = value;
            //When 
            var result = _primeService.IsPrime(candidate);
            //Then
            Assert.False(result, $"{value} should not be a prime");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(-3)]
        [InlineData(5)]
        [InlineData(-5)]
        [InlineData(7)]
        [InlineData(-7)]
        public void Should_return_true_for_primes_less_than_10(int value)
        {
            //Given
            var candidate = value;
            //When
            var result = _primeService.IsPrime(candidate);
            //Then
            Assert.True(result, $"{value} should be prime");
        }

        [Theory]
        [InlineData(21212128)]
        [InlineData(-21212128)]
        [InlineData(12220)]
        [InlineData(-12220)]
        [InlineData(4)]
        [InlineData(-4)]
        [InlineData(6)]
        [InlineData(-6)]
        [InlineData(9)]
        [InlineData(-9)]
        [InlineData(8989810)]
        public void Should_return_false(int value)
        {
            //Given
            var candidate = value;
            //When
            var result = _primeService.IsPrime(candidate);
            //Then
            Assert.False(result, $"{value} should not  be prime");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(-3)]
        [InlineData(12)]
        [InlineData(9)]
        [InlineData(103)]
        public void Should_return_the_same_value_for_positif_and_negatif_value(int value)
        {
            //Given
            var positif = Math.Abs(value);
            var negatif = positif * (-1);
            //When
            var positifResult = _primeService.IsPrime(positif);
            var negatifResult = _primeService.IsPrime(negatif);
            //Then
            Assert.Equal(positifResult, negatifResult);
        }
    }
}
