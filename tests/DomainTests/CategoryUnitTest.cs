using CleanArch.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace DomainTests
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName ="Create category with valid state")]
        public void CreateCategory_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArch.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Create category with invalid state")]
        public void CreateCategory_WithInvalidParameters_ResultObjectInvalidState()
        {
            Action action = () => new Category(-3, "Category Name");
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }

        [Fact(DisplayName = "Create category name length with valid state")]
        public void CreateCategory_WithInValidName_ResultObjectInvalidState()
        {
            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 charecters is required");
        }

        [Fact(DisplayName = "Create category name empty with invalid state")]
        public void CreateCategory_WithNameEmpty_ResultObjectInvalidState()
        {
            Action action = () => new Category(3, "");
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required");
        }

        [Fact(DisplayName = "Create category name null with invalid state")]
        public void CreateCategory_WithNameNull_ResultObjectInvalidState()
        {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<CleanArch.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required");
        }
    }
}
