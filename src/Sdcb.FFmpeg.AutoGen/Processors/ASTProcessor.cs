using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CppSharp.AST;
using Sdcb.FFmpeg.AutoGen.Definitions;
using MacroDefinition = Sdcb.FFmpeg.AutoGen.Definitions.MacroDefinition;

namespace Sdcb.FFmpeg.AutoGen.Processors
{
    internal class ASTProcessor
    {
        private readonly List<IDefinition> _units;

        public ASTProcessor()
        {
            _units = new List<IDefinition>();
            IgnoreUnitNames = new HashSet<string>();
            TypeAliases = new Dictionary<string, string>();
            WellKnownMacros = new Dictionary<string, string>();
            FunctionProcessor = new FunctionProcessor(this);
            StructureProcessor = new StructureProcessor(this);
            EnumerationProcessor = new EnumerationProcessor(this);
            MacroProcessor = new MacroProcessor(this);
        }

        public HashSet<string> IgnoreUnitNames { get; }
        public Dictionary<string, string> TypeAliases { get; }
        public Dictionary<string, string> WellKnownMacros { get; }
        public MacroProcessor MacroProcessor { get; }
        public EnumerationProcessor EnumerationProcessor { get; }
        public StructureProcessor StructureProcessor { get; }
        public FunctionProcessor FunctionProcessor { get; }

        public Dictionary<string, FunctionExport> FunctionExportMap { get; init; }
        public IReadOnlyList<IDefinition> Units => _units;

        public bool IsKnownUnitName(string name)
        {
            return _units.Any(x => x.Name == name);
        }

        public void AddUnit(IDefinition definition)
        {
            if (IgnoreUnitNames.Contains(definition.Name)) return;

            switch (definition)
            {
                // for
                case FunctionDefinitionBase df:
                {
                    // check for existing functions with same parameters
                    // we care about the parameters, as we want to allow functions with same name but different parameters (overloads)
                    var existingWithSameName = _units.OfType<FunctionDefinitionBase>().Where(x => x.Name == definition.Name);
                    var existingWithSameParameters = existingWithSameName.Where(v => v.Parameters.SequenceEqual(df.Parameters)).ToList();

                    foreach (var d in existingWithSameParameters)
                    {
                        _units.Remove(d);
                    }

                    break;
                }
                default:
                {
                    // don't allow adding if existing definition with same name
                    var existing = _units.FirstOrDefault(x => x.Name == definition.Name);
                    if (existing != null)
                        _units.Remove(existing);
                    break;
                }
            }
            _units.Add(definition);
        }

        public void Process(IEnumerable<TranslationUnit> units)
        {
            MetricHelper.RecordTime("Macro/Enumeration/Structure/Functions Process", () =>
            {
                foreach (var translationUnit in units)
                {
                    MacroProcessor.Process(translationUnit);
                    EnumerationProcessor.Process(translationUnit);
                    StructureProcessor.Process(translationUnit);
                    FunctionProcessor.Process(translationUnit);
                }
            });

            MetricHelper.RecordTime("MacroPostProcess", () =>
            {
                MacroDefinition[] macros = Units.OfType<MacroDefinition>().ToArray();
                EnumerationDefinition[] enums = Units.OfType<EnumerationDefinition>().ToArray();
                MacroPostProcessor.Process(macros, enums, WellKnownMacros);
            });
        }
    }
}