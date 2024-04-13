namespace PUPPointsBusinessServices;

public class StudentDataService
{
    public bool VerifyUser(string name)
    {

        StudentDataService dataService = new StudentDataService();

        return dataService.GetVerifyuser(name);
    }

    private bool GetVerifyuser(string name)
    {
        throw new NotImplementedException();
    }
}