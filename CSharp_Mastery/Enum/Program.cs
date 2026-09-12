using Enums;

Member member = new Member
{
    Name = "Mohammed Yonose",
    UserName = "m.yonose",
    Password = "123456",
    Status = MembershipStatus.Inactive
};
if (member.Status == MembershipStatus.Blocked)
    Console.WriteLine("Member is active");

else if (member.Status == MembershipStatus.Inactive)
    Console.WriteLine("Member is Inactive");

else if (member.Status == MembershipStatus.Blocked)
    Console.WriteLine("Member is blocked");

int x = (int)member.Status;
Console.WriteLine(x);

MembershipStatus status = (MembershipStatus)x;
Console.WriteLine(status);
         