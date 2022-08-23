﻿using Sev1.Congratulations.Domain.Base.Exceptions;

namespace Sev1.Congratulations.AppServices.Services.Category.Exceptions
{
    /// <summary>
    /// Исключение, если категория с таким идентификатором не была найдена
    /// </summary>
    public sealed class CategoryNotFoundException : NotFoundException
    {
        private const string MessageTemplate = "Категория с таким ID[{0}] не была найдена.";
        public CategoryNotFoundException(int? Id) : base(string.Format(MessageTemplate, Id))
        {
        }
    }
}