using System;
using System.Collections.Generic;

namespace OtbasyBank.Domain.Entities
{
    public partial class FrontEnd
    {
        /// <summary>
        /// Идентификатор фронта
        /// </summary>
        public string Id { get; set; } = null!;
        /// <summary>
        /// Описание
        /// </summary>
        public string Title { get; set; } = null!;
    }
}
