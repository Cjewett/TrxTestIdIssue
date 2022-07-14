namespace TrxTesting
{
    public static class GreaterEnergyProgram
    {
        public static EnergyProgram GreateEnergyProgram(
            int programId = 1
            , string programName = "name"
            , string[] eligiblePostalCodes = null
            , string launchDate = ""
            , string endDate = ""
            )
        {
            var program = new EnergyProgram();
            program.ProgramId = programId.ToString();
            program.ProgramNumericId = programId;
            program.ProgramName = programName;
            program.EndDate = endDate;
            program.LaunchDate = launchDate;
            program.EligiblePostalCodes = eligiblePostalCodes;

            return program;
        }
    }
}
