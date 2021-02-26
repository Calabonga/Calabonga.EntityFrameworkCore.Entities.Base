using System;

namespace Calabonga.EntityFrameworkCore.Entities.Base
{
    /// <summary>
    /// Identifier interface
    /// </summary>
    public interface IHaveId
    {
        /// <summary>
        /// Identifier
        /// </summary>
        Guid Id { get; set; }
    }
}
