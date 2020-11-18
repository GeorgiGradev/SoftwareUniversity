namespace FootballTeamGenerator.Exceptions
{
    public static class GlobalExceptions
    {
        public static string InvalidStatExceptionMessage = "{0} should be between {1} and {2}.";

        public static string EmptyNameExceptionMessage = "A name should not be empty.";

        public static string MissingPlayerExceptionMessage = "Player {0} is not in {1} team.";

        public static string NonExistentTeamExceptionMessage = "Team {0} does not exist.";
    }
}
