namespace FacadePatternTutorial
{
    public interface IEmailFluentInterface
    {
        IEmailFluentInterface Bcc(params string[] BccAddresses);
        IEmailFluentInterface CC(params string[] ccAddresses);
        IEmailFluentInterface To(params string[] toAddresses);
        IEmailFluentInterface WithBody(string body);
        IEmailFluentInterface WithSubject(string subject);
        void Send();
    }
}