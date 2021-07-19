namespace FriendLetter.Models
{
  public class LetterVariable
  {
    public string Recipient { get; set; }
    public string Sender { get; set; }
    public string Destination { get; set; }
    public string DesiredDestination { get; set; }

    public LetterVariable () {}
    public LetterVariable(
      string recipient, 
      string sender, 
      string destination = "Iceland", 
      string desiredDestination = "Hawaii"
    )
    {
      Recipient = recipient;
      Sender = sender;
      Destination = destination;
      DesiredDestination = desiredDestination;
    }
  }
}