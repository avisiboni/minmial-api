public class UserService {
    public string GetUserName(string firstName ) => string.IsNullOrEmpty(firstName)?"John" :firstName;
        }