﻿namespace RetailCorrector.ModuleManager.Data
{
    public readonly partial struct LocalModule
    {
        public Guid Id { get; }
        public string Name { get; }
        public Version Version { get; }
        public string Path { get; }

        public LocalModule(string filepath)
        {
            var assemblyName = System.Reflection.AssemblyName.GetAssemblyName(filepath)!;
            var infoName = Patterns.AssemblyNameRegex().Match(assemblyName.Name!);
            Id = new Guid(infoName.Groups["guid"].Value);
            Name = infoName.Groups["guid"].Value;
            Version = assemblyName.Version!;
            Path = filepath;
        }
    }
}
