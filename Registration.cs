using System.ComponentModel.DataAnnotations;

namespace knightmoves;
public class Registration
{
    // Add your code here
    public string ValidateAge(bool oldEnough)
    {
        if (oldEnough)
        {
            return "old enough";
        }
        return "";
    }
}
