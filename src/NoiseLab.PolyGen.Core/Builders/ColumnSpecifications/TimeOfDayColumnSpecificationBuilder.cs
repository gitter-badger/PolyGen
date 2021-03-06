using NoiseLab.PolyGen.Core.Database;

namespace NoiseLab.PolyGen.Core.Builders.ColumnSpecifications
{
    public class TimeOfDayColumnSpecificationBuilder : ColumnSpecificationBuilderBase
    {
        public new TimeOfDayColumnSpecificationBuilder Nullable()
        {
            base.Nullable();
            return this;
        }

        public new TimeOfDayColumnSpecificationBuilder PrimaryKey()
        {
            base.PrimaryKey();
            return this;
        }

        public new TimeOfDayColumnSpecificationBuilder Identity()
        {
            base.Identity();
            return this;
        }

        public new TimeOfDayColumnSpecificationBuilder Computed()
        {
            base.Computed();
            return this;
        }

        protected internal override AbstractDataType DataType { get; } = AbstractDataType.TimeOfDay;

        internal TimeOfDayColumnSpecificationBuilder(ColumnBuilder columnFactory)
            : base(columnFactory)
        {
        }
    }
}