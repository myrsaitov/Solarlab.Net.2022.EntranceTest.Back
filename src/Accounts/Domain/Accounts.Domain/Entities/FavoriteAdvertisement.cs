﻿using Sev1.Accounts.Domain.Base.Entities;
using System.Collections.Generic;

namespace Sev1.Accounts.Domain
{
    /// <summary>
    /// Доменная модель избранного объявления
    /// </summary>
    public class FavoriteCongratulation : EntityMutable<string>
    {
        /// <summary>
        /// Идентификатор объявления
        /// </summary>
        public string CongratulationId { get; set; }

        /// <summary>
        /// Пользователи, которые добавили его в избранное
        /// </summary>
        public ICollection<User> Users { get; set; }
    }
}