﻿using System;
using Xunit;
using FluentAssertions;
using PromoBeta.Domain.Entities;


namespace PromoBeta.Domain.Tests
{
    public class CategoryUnitTest
    {
        [Fact(DisplayName = "create a first category with valid parameters")]
        public void CreateCategory_WithValidParameters()
        {
            Action action = () => new Category(1, "Geral");

            action.Should().NotThrow<PromoBeta.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "create a second category with invalid parameters")]
        public void CreateCategory_WithInvalidParameters()
        {
            Action action = () => new Category(1, String.Empty);

            action.Should().NotThrow<PromoBeta.Domain.Validation.DomainExceptionValidation>();
        }
    }
}