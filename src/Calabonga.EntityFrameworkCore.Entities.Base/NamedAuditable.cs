namespace Calabonga.EntityFrameworkCore.Entities.Base
{
    /// <summary>
    /// Audit-able with name
    /// </summary>
    public abstract class NamedAuditable : Auditable
    {
        /// <summary>
        /// Name of the entity
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description about what entity for
        /// </summary>
        public string Description { get; set; }
    }
}