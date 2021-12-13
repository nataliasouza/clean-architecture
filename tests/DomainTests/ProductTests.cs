using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace DomainTests
{
    public class ProductTests
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 10, "www.algumalink.com");
            action.Should().NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithIdInvalid_ResultObjectInvalidState()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 10, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id Value");
        }

        [Fact]
        public void CreateProduct_WithNameNull_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, null, "Product Description", 9.99m, 10, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required");
        }

        [Fact]
        public void CreateProduct_WithNameEmpty_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "", "Product Description", 9.99m, 10, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name. Name is required");
        }

        [Fact]
        public void CreateProduct_WithNameInvalid_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "Pr", "Product Description", 9.99m, 10, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 charecters is required");
        }

        [Fact]
        public void CreateProduct_WithDescriptionInvalid_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "Product Name", "Prod", 9.99m, 10, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithValueInvalid_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "Product Name", "Product Description", -1, 10, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithStockInvalid_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "Product Name", "Product Description", 5.00m, -1, "www.algumalink.com");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact]
        public void CreateProduct_WithLinkImgEmpty_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "Product Name", "Product Description", 5.00m, 31, "");
            action.Should().Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid link image, not is null or empty");
        }

        [Fact]
        public void CreateProduct_WithLinkImgNull_ResultObjectInvalidState()
        {
            Action action = () => new Product(3, "Product Name", "Product Description", 5.00m, 51, null);
            action.Should().NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();                
        }
    }
}
