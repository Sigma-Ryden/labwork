namespace Lab11._1
{
    class ServiceCenter
    {
        public delegate void ServiceCenterDelegate(Computer ComputerInServiceCenter);

        public void ReinstallWindows(Computer computer)
        {
            Computer.ReinstallWindows_ed = true;
        }
        public void ReplaceMotherboard(Computer computer)
        {
            Computer.ReplaceMotherboard_ed = true;
        }
        public void ReplacePowerSupply(Computer computer)
        {
            Computer.ReplacePowerSupply_ed = true;
        }
        public void AddRAM(Computer computer)
        {
            Computer.AddRAM_ed = true;
        }
        public void ReplaceVideoCard(Computer computer)
        {
            Computer.ReplaceVideoCard_ed = true;
        }
        public void ToConfigurePrograms(Computer computer)
        {
            Computer.ToConfigurePrograms_ed = true;
        }
    }
}
