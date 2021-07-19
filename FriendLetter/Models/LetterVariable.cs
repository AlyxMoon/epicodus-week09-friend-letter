namespace FriendsLetter.Models
{
  public class LetterVariable
  {
    public string Recipient { get; set; }
    public string Sender { get; set; }

    public LetterVariable(string recipient, string sender)
    {
      Recipient = recipient;
      Sender = sender;
    }
  }
}