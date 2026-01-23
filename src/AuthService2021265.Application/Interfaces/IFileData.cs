namespace AuthService2021265.Application.Interface;

public interface IFileData
{
    byte[] Data { get; }
    string ContentType { get; }
    string FileName { get; }
    long Size { get; }
}