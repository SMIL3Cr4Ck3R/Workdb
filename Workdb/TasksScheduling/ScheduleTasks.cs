using Hangfire;
using Workdb.Services;

namespace Workdb.TasksSchedualing
{
    public class ScheduleTasks
    {
        public static void monthlyEmployeeSalaryMail(string email)
        {
            RecurringJob.AddOrUpdate(() => MailingService.sendSalaryFeedBackToEmployee(email), Cron.Minutely);
            //RecurringJob.AddOrUpdate(() => MailingService.sendSalaryFeedBackToEmployee(email), Cron.Monthly(10));
        }
    }
}
