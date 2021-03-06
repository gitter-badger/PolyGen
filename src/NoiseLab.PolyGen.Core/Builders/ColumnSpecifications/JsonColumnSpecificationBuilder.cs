using NoiseLab.PolyGen.Core.Database;

namespace NoiseLab.PolyGen.Core.Builders.ColumnSpecifications
{
    public class JsonColumnSpecificationBuilder : ColumnSpecificationBuilderBase
    {
        public new JsonColumnSpecificationBuilder MaxLength(int maxLength)
        {
            base.MaxLength(maxLength);
            return this;
        }

        public new JsonColumnSpecificationBuilder Nullable()
        {
            base.Nullable();
            return this;
        }

        public new JsonColumnSpecificationBuilder PrimaryKey()
        {
            base.PrimaryKey();
            return this;
        }

        public new JsonColumnSpecificationBuilder Identity()
        {
            base.Identity();
            return this;
        }

        public new JsonColumnSpecificationBuilder Computed()
        {
            base.Computed();
            return this;
        }

        protected internal override AbstractDataType DataType { get; } = AbstractDataType.Json;

        internal JsonColumnSpecificationBuilder(ColumnBuilder columnFactory)
            : base(columnFactory)
        {
        }
    }
}