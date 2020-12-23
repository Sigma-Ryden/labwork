namespace Lab11._1
{
    class Computer
    {
        static public bool ReinstallWindows_ed { get; set; }
        static public bool ReplaceMotherboard_ed { get; set; }
        static public bool ReplacePowerSupply_ed { get; set; }
        static public bool AddRAM_ed { get; set; }
        static public bool ReplaceVideoCard_ed { get; set; }
        static public bool ToConfigurePrograms_ed { get; set; }

        public override string ToString()
        {
            return
            $"ReinstalledWindows: {ReinstallWindows_ed}" +
            $"\nReplacedMotherboard: {ReplaceMotherboard_ed}" +
            $"\nReplacedPowerSupply: {ReplacePowerSupply_ed}" +
            $"\nAddedRAM: {AddRAM_ed}" +
            $"\nReplacedVideoCard: {ReplaceVideoCard_ed}" +
            $"\nToConfiguratedPrograms: {ToConfigurePrograms_ed}";
        }
    }
}