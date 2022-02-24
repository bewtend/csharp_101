
namespace csharp_learning
{
    public class lesson_25
    {
        public static void _interface()
        {
            FileLogger _file = new FileLogger();
            _file.wLog();

            DatabaseLogger _db = new DatabaseLogger();
            _db.wLog();

            LogManager _logManager = new LogManager(new SmsLogger());
            _logManager.wLog();

            NewDatabaseLogger _dbNew = new NewDatabaseLogger();
            _dbNew.wLog();
            _dbNew.Log();
        }
    }

}