namespace DXApplication_Exercise_04.Migrations
{
    using nucs.JsonSettings;
    using nucs.JsonSettings.Fluent;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Windows.Forms;

    internal sealed class Configuration : DbMigrationsConfiguration<DXApplication_Exercise_04.MyContext>
    {
        SettingsBag settings { get; } = JsonSettings.Construct<SettingsBag>(AppVariable.fileName
                                         + @"\config.json").EnableAutosave().LoadNow();

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "DXApplication_Exercise_04.MyContext";
            string DataPath1 = Application.StartupPath + @"\DBSql1";
            //AppDomain.CurrentDomain.SetData("DataDirectory", DataPath1);
            try
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", settings[AppVariable.ConnectionPath] ?? DataPath1);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        protected override void Seed(DXApplication_Exercise_04.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
