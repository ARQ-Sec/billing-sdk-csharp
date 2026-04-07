using System; namespace Arq.Lab.Library.Security; public static class OtpTokenService { public static int IssueCode() => new Random().Next(100000, 999999); }
