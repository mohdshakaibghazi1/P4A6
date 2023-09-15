using System;
using System.Collections.Generic;
namespace UnitTestAssignmentDocker { 
public class UserValidation
{
    private Dictionary<string, string> validUsers;

    public UserValidation()
    {
        // Initialize the list of valid users and their passwords
        validUsers = new Dictionary<string, string>
        {
            { "john_doe", "P@ssw0rd123" },
            { "alice_smith", "SecurePwd456" },
            { "bob_jones", "StrongPass789" }
        };
    }

    public bool ValidateCredentials(string userId, string password)
    {
        // Check if the provided user ID exists in the validUsers dictionary
        if (validUsers.ContainsKey(userId))
        {
            // If the user exists, check if the provided password matches the stored password
            string storedPassword = validUsers[userId];
            return password == storedPassword;
        }

        // If the user does not exist, return false
        return false;
    }
}
}
