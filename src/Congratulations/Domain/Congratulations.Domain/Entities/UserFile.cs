using System.Collections.Generic;
using Sev1.Congratulations.Domain.Base.Entities;

namespace Sev1.Congratulations.Domain
{
    /// <summary>
    /// Доменная модель ссылки на файл пользователя
    /// </summary>
    public class UserFile : Entity<int?>
    {
        /// <summary>
        /// Идентификатор файла в БД файлов
        /// </summary>
        public int? FileId { get; set; }
        /// <summary>
        /// Идентификатор родительского объявления
        /// </summary>
        public int? CongratulationId { get; set; }
    }
}