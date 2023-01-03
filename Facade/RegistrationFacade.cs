namespace Facade;

/// <summary>
/// 外观类
/// </summary>
public class RegistrationFacade
{
    RegisterCourse registerCourse;
    NotifyStudent notifyStudent;

    public RegistrationFacade()
    {
        registerCourse = new RegisterCourse();
        notifyStudent = new NotifyStudent();
    }

    public bool RegisterCourse(string courseName, string studentName)
    {
        if (!registerCourse.CheckAvailable(courseName))
        {
            return false;
        }
        return notifyStudent.Notify(studentName);
    }
}