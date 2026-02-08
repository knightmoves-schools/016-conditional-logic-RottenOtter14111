using System.ComponentModel.DataAnnotations;

namespace knightmoves;
public class Registration
{
    // Add your code here
    public bool OldEnough = false;
    public string ValidateAge()
    {
        if (OldEnough)
        {
            return "Old enough";
        }
        return "";
    }
}
