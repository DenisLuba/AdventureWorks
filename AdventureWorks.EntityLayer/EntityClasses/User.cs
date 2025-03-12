namespace AdventureWorks.EntityLayer.EntityClasses;

public class User
{
    public int UserId { get; set; }
    public string LoginId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Emali { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string PhoneType { get; set; }
    public bool IsFullTime { get; set; }
    public bool IsEnrolledIn401k { get; set; }
    public bool IsEnrolledInHealthCare { get; set; }
    public bool IsEnrolledInHSA { get; set; }
    public bool IsEnrolledInFlexTime { get; set; }
    public bool IsActive { get; set; }
    public DateTime BirthDate { get; set; }
    public TimeSpan StartTime { get; set; }

    public User()
    {
        LoginId = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        Emali = string.Empty;
        Password = string.Empty;
        Phone = string.Empty;
        PhoneType = string.Empty;
        StartTime = new TimeSpan(6, 0, 0);
    }
}