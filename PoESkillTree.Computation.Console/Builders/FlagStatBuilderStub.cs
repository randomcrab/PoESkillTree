﻿using PoESkillTree.Computation.Common.Builders.Conditions;
using PoESkillTree.Computation.Common.Builders.Stats;
using static PoESkillTree.Computation.Console.Builders.BuilderFactory;

namespace PoESkillTree.Computation.Console.Builders
{
    public class FlagStatBuilderStub : StatBuilderStub, IFlagStatBuilder
    {
        public FlagStatBuilderStub(string stringRepresentation, Resolver<IStatBuilder> resolver)
            : base(stringRepresentation, resolver)
        {
        }

        public IConditionBuilder IsSet => CreateCondition(This, o => $"{o} is set");

        public override IStatBuilder WithCondition(IConditionBuilder condition) =>
            CreateFlagStat(This, condition, (s, c) => $"{s} ({c})");
    }
}