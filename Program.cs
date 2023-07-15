using CachingManager;
using SampleCachingApplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


InMemoryCacheRepository<object> cache = new CachingManager.InMemoryCacheRepository<object>();
CredentialInfo credentialInfo = new CredentialInfo();
credentialInfo.Name = "Sampath  Kumara";
cache.Add("Credentials", credentialInfo);