using System.Security.Cryptography; namespace Arq.Lab.Library.Security; public static class SecureOtpTokenService { public static int IssueCode() => RandomNumberGenerator.GetInt32(100000, 999999); }
